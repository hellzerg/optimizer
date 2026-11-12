using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    internal sealed class LockerRow {
        internal int Pid;
        internal string Name;
        internal string Path;
        internal Bitmap Icon;
        internal bool Checked;
    }

    /// <summary>
    /// Owner-drawn, checkable process table (Process / PID / Path) with a pinned header row.
    /// </summary>
    internal sealed class LockerList : ScrollableControl, IThemeable {
        readonly List<LockerRow> _rows = new List<LockerRow>();
        readonly ToolTip _tip = new ToolTip { InitialDelay = 500, ReshowDelay = 100, AutoPopDelay = 15000 };
        int _hover = -1, _focus = -1;
        string _tipShown;
        string _emptyText = string.Empty, _colProcess = "Process", _colPid = "PID", _colPath = "Path";

        public event EventHandler CheckedChanged;
        public event EventHandler<LockerRow> RowActivated;

        public LockerList()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            TabStop = true;
            AutoScroll = true;
        }

        internal IList<LockerRow> Rows { get { return _rows; } }

        internal int RowHeight { get { return Draw.SI(36); } }
        int HeaderHeight { get { return Draw.SI(30); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyText { get { return _emptyText; } set { _emptyText = value ?? string.Empty; Invalidate(); } }

        internal void SetColumns(string process, string pid, string path)
        {
            _colProcess = process; _colPid = pid; _colPath = path;
            Invalidate();
        }

        internal int CheckedCount
        {
            get { int n = 0; foreach (LockerRow r in _rows) if (r.Checked) n++; return n; }
        }

        internal void SetRows(IEnumerable<LockerRow> rows)
        {
            foreach (LockerRow r in _rows) if (r.Icon != null) r.Icon.Dispose();
            _rows.Clear();
            if (rows != null) _rows.AddRange(rows);
            _hover = -1;
            _focus = _rows.Count > 0 ? 0 : -1;
            AutoScrollMinSize = new Size(0, HeaderHeight + _rows.Count * RowHeight);
            Invalidate();
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }

        internal void SetAll(bool on)
        {
            bool changed = false;
            foreach (LockerRow r in _rows) if (r.Checked != on) { r.Checked = on; changed = true; }
            if (!changed) return;
            Invalidate();
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = Parent != null ? Parent.BackColor : palette.Layer1;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                foreach (LockerRow r in _rows) if (r.Icon != null) r.Icon.Dispose();
                _rows.Clear();
                _tip.Dispose();
            }
            base.Dispose(disposing);
        }

        // the header stays pinned, so a blitted scroll would leave it stale
        protected override void OnScroll(ScrollEventArgs se) { base.OnScroll(se); Invalidate(); }
        protected override void OnMouseWheel(MouseEventArgs e) { base.OnMouseWheel(e); Invalidate(); UpdateHover(PointToClient(MousePosition)); }

        int RowAt(Point pt)
        {
            if (pt.Y < HeaderHeight) return -1;
            int i = (pt.Y - HeaderHeight - AutoScrollPosition.Y) / RowHeight;
            return i >= 0 && i < _rows.Count ? i : -1;
        }

        void Columns(out int nameX, out int pidX, out int pathX)
        {
            int w = ClientSize.Width;
            nameX = Draw.SI(40);
            int nameW = Math.Max(Draw.SI(130), Math.Min(Draw.SI(240), (w - nameX) * 30 / 100));
            pidX = nameX + nameW;
            pathX = pidX + Draw.SI(76);
        }

        void UpdateHover(Point pt)
        {
            int i = RowAt(pt);
            if (i != _hover) { _hover = i; Invalidate(); }

            string tip = i >= 0 ? _rows[i].Path : null;
            if (tip != _tipShown)
            {
                _tipShown = tip;
                _tip.SetToolTip(this, string.IsNullOrEmpty(tip) ? null : tip);
            }
            Cursor = i >= 0 ? Cursors.Hand : Cursors.Default;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            UpdateHover(e.Location);
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hover != -1) { _hover = -1; Invalidate(); }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Focus();
            base.OnMouseDown(e);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button != MouseButtons.Left) return;
            int i = RowAt(e.Location);
            if (i < 0) return;
            _focus = i;
            Toggle(i);
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            int i = RowAt(e.Location);
            if (i < 0) return;
            // the first click of the pair already toggled the row; undo it and open the row instead
            Toggle(i);
            RowActivated?.Invoke(this, _rows[i]);
        }

        void Toggle(int i)
        {
            _rows[i].Checked = !_rows[i].Checked;
            Invalidate();
            CheckedChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            Keys k = keyData & Keys.KeyCode;
            return k == Keys.Up || k == Keys.Down || k == Keys.Space || base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_rows.Count == 0) return;
            if (e.KeyCode == Keys.Down) { MoveFocus(Math.Min(_rows.Count - 1, _focus + 1)); e.Handled = true; }
            else if (e.KeyCode == Keys.Up) { MoveFocus(Math.Max(0, _focus - 1)); e.Handled = true; }
            else if (e.KeyCode == Keys.Space && _focus >= 0) { Toggle(_focus); e.Handled = true; }
            else if (e.KeyCode == Keys.A && e.Control) { SetAll(true); e.Handled = true; }
        }

        void MoveFocus(int i)
        {
            _focus = i;
            int top = HeaderHeight + i * RowHeight + AutoScrollPosition.Y;
            int y = -AutoScrollPosition.Y;
            if (top < HeaderHeight) y -= HeaderHeight - top;
            else if (top + RowHeight > ClientSize.Height) y += top + RowHeight - ClientSize.Height;
            AutoScrollPosition = new Point(0, Math.Max(0, y));
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color back = BackColor;
            g.Clear(back);

            const TextFormatFlags cell = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix;
            Font font = Typography.Get(10f, Typography.Weight.Regular);
            Font head = Typography.Get(9f, Typography.Weight.Semibold);
            int w = ClientSize.Width, rowH = RowHeight, headH = HeaderHeight;
            int nameX, pidX, pathX;
            Columns(out nameX, out pidX, out pathX);

            if (_rows.Count == 0)
            {
                TextRenderer.DrawText(g, _emptyText, Typography.Get(10.5f, Typography.Weight.Regular),
                    new Rectangle(Draw.SI(16), 0, Math.Max(0, w - Draw.SI(32)), ClientSize.Height), p.TextSecondary,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
                return;
            }

            int scroll = AutoScrollPosition.Y;
            g.SetClip(new Rectangle(0, headH, w, Math.Max(0, ClientSize.Height - headH)));
            int iconS = Draw.SI(20), box = Draw.SI(18);
            for (int i = 0; i < _rows.Count; i++)
            {
                Rectangle rr = new Rectangle(0, headH + i * rowH + scroll, w, rowH);
                if (rr.Bottom < headH) continue;
                if (rr.Top > ClientSize.Height) break;
                LockerRow row = _rows[i];

                g.SmoothingMode = SmoothingMode.AntiAlias;
                Color fill = row.Checked ? ColorMath.Blend(back, p.Accent, 0.12) : (i == _hover ? ColorMath.Blend(back, p.TextPrimary, 0.06) : Color.Empty);
                if (!fill.IsEmpty)
                {
                    using (GraphicsPath hp = Draw.RoundedRect(new RectangleF(rr.X, rr.Y + 1, rr.Width - 1, rr.Height - 2), Draw.S(5)))
                    using (SolidBrush hb = new SolidBrush(fill))
                    {
                        g.FillPath(hb, hp);
                    }
                }
                if (Focused && i == _focus)
                {
                    using (GraphicsPath fp = Draw.RoundedRect(new RectangleF(rr.X + 0.5f, rr.Y + 1.5f, rr.Width - 2, rr.Height - 3), Draw.S(5)))
                    using (Pen fpen = new Pen(p.StrokeStrong))
                    {
                        g.DrawPath(fpen, fp);
                    }
                }

                RectangleF cb = new RectangleF(Draw.SI(12), rr.Y + (rowH - box) / 2f, box, box);
                using (GraphicsPath cp = Draw.RoundedRect(cb, Draw.S(4)))
                {
                    if (row.Checked)
                    {
                        using (SolidBrush fb = new SolidBrush(p.Accent)) g.FillPath(fb, cp);
                        using (Pen mark = new Pen(p.OnAccent, Draw.S(1.6f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
                        {
                            g.DrawLines(mark, new[]
                            {
                                new PointF(cb.X + cb.Width * 0.26f, cb.Y + cb.Height * 0.52f),
                                new PointF(cb.X + cb.Width * 0.43f, cb.Y + cb.Height * 0.69f),
                                new PointF(cb.X + cb.Width * 0.75f, cb.Y + cb.Height * 0.33f)
                            });
                        }
                    }
                    else
                    {
                        using (SolidBrush fb = new SolidBrush(i == _hover ? p.ControlHover : p.ControlFill)) g.FillPath(fb, cp);
                        using (Pen op = new Pen(i == _hover ? p.TextSecondary : p.StrokeStrong)) g.DrawPath(op, cp);
                    }
                }
                g.SmoothingMode = SmoothingMode.None;

                int tx = nameX;
                if (row.Icon != null)
                {
                    InterpolationMode old = g.InterpolationMode;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.DrawImage(row.Icon, new Rectangle(nameX, rr.Y + (rowH - iconS) / 2, iconS, iconS));
                    g.InterpolationMode = old;
                }
                tx += iconS + Draw.SI(10);

                TextRenderer.DrawText(g, row.Name, font, new Rectangle(tx, rr.Y, Math.Max(0, pidX - tx - Draw.SI(8)), rowH), p.TextPrimary, cell);
                TextRenderer.DrawText(g, row.Pid.ToString(), font, new Rectangle(pidX, rr.Y, Math.Max(0, pathX - pidX - Draw.SI(8)), rowH), p.TextSecondary, cell);
                TextRenderer.DrawText(g, row.Path ?? string.Empty, font, new Rectangle(pathX, rr.Y, Math.Max(0, w - pathX - Draw.SI(10)), rowH), p.TextSecondary,
                    TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.PathEllipsis | TextFormatFlags.NoPrefix);
            }
            g.ResetClip();

            using (SolidBrush hb = new SolidBrush(back)) g.FillRectangle(hb, 0, 0, w, headH);
            TextRenderer.DrawText(g, _colProcess, head, new Rectangle(nameX, 0, Math.Max(0, pidX - nameX - Draw.SI(8)), headH), p.TextSecondary, cell);
            TextRenderer.DrawText(g, _colPid, head, new Rectangle(pidX, 0, Math.Max(0, pathX - pidX - Draw.SI(8)), headH), p.TextSecondary, cell);
            TextRenderer.DrawText(g, _colPath, head, new Rectangle(pathX, 0, Math.Max(0, w - pathX - Draw.SI(10)), headH), p.TextSecondary, cell);
            using (Pen line = new Pen(p.Stroke)) g.DrawLine(line, 0, headH - 1, w, headH - 1);
        }
    }
}
