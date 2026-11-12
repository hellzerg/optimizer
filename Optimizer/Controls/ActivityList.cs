using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    internal enum ActivitySort { Path, Kind, Count, LastSeen }

    /// <summary>
    /// Owner-drawn, sortable and filterable table of <see cref="ActivityEntry"/> rows
    /// (Path / Type / Count / Last seen) with a pinned, clickable header.
    /// </summary>
    internal sealed class ActivityList : ScrollableControl, IThemeable {
        readonly List<ActivityEntry> _view = new List<ActivityEntry>();
        readonly ToolTip _tip = new ToolTip { InitialDelay = 500, ReshowDelay = 100, AutoPopDelay = 15000 };
        IList<ActivityEntry> _source;
        ActivityEntry _selected;
        int _hover = -1, _hoverHead = -1;
        string _tipShown, _filter = string.Empty, _emptyText = string.Empty;
        readonly string[] _cols = { "Path", "Type", "Count", "Last seen" };
        readonly string[] _kinds = { "Created", "Modified", "Deleted", "Renamed" };
        ActivitySort _sort = ActivitySort.LastSeen;
        bool _descending = true;

        public event EventHandler<ActivityEntry> RowActivated;
        public event EventHandler<ActivityEntry> RowMenuRequested;
        public event EventHandler SelectionChanged;

        public ActivityList()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw | ControlStyles.Selectable, true);
            TabStop = true;
            AutoScroll = true;
        }

        internal int RowHeight { get { return Draw.SI(34); } }
        int HeaderHeight { get { return Draw.SI(30); } }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyText { get { return _emptyText; } set { _emptyText = value ?? string.Empty; Invalidate(); } }

        internal ActivityEntry Selected { get { return _selected; } }
        internal int VisibleCount { get { return _view.Count; } }
        internal IList<ActivityEntry> View { get { return _view; } }

        internal void SetColumns(string path, string kind, string count, string lastSeen)
        {
            _cols[0] = path; _cols[1] = kind; _cols[2] = count; _cols[3] = lastSeen;
            Invalidate();
        }

        internal void SetKindNames(string created, string modified, string deleted, string renamed)
        {
            _kinds[0] = created; _kinds[1] = modified; _kinds[2] = deleted; _kinds[3] = renamed;
            Invalidate();
        }

        internal string KindName(ActivityKind kind) { return _kinds[(int)kind]; }

        internal string Filter
        {
            get { return _filter; }
            set
            {
                value = (value ?? string.Empty).Trim();
                if (value == _filter) return;
                _filter = value;
                Rebuild();
            }
        }

        internal void SetSource(IList<ActivityEntry> source)
        {
            _source = source;
            Rebuild();
        }

        /// <summary>Re-applies the filter and sort after the source changed.</summary>
        internal void Rebuild()
        {
            _view.Clear();
            if (_source != null)
            {
                if (_filter.Length == 0) _view.AddRange(_source);
                else
                    foreach (ActivityEntry e in _source)
                        if (Matches(e)) _view.Add(e);
            }
            _view.Sort(Compare);
            if (_selected != null && !_view.Contains(_selected))
            {
                _selected = null;
                SelectionChanged?.Invoke(this, EventArgs.Empty);
            }
            AutoScrollMinSize = new Size(0, HeaderHeight + _view.Count * RowHeight);
            if (_hover >= _view.Count) _hover = -1;
            Invalidate();
        }

        bool Matches(ActivityEntry e)
        {
            return e.Path.IndexOf(_filter, StringComparison.OrdinalIgnoreCase) >= 0
                || (e.OldPath != null && e.OldPath.IndexOf(_filter, StringComparison.OrdinalIgnoreCase) >= 0)
                || KindName(e.Kind).IndexOf(_filter, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        int Compare(ActivityEntry a, ActivityEntry b)
        {
            int c;
            switch (_sort)
            {
                case ActivitySort.Kind: c = a.Kind.CompareTo(b.Kind); break;
                case ActivitySort.Count: c = a.Count.CompareTo(b.Count); break;
                case ActivitySort.LastSeen: c = a.LastSeen.CompareTo(b.LastSeen); break;
                default: c = 0; break;
            }
            if (c == 0) c = string.Compare(a.Path, b.Path, StringComparison.OrdinalIgnoreCase);
            if (c == 0) c = a.Kind.CompareTo(b.Kind);
            return _descending ? -c : c;
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = Parent != null ? Parent.BackColor : palette.Layer1;
            ThemeManager.ThemeScrollbars(this);
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) _tip.Dispose();
            base.Dispose(disposing);
        }

        // the header stays pinned, so a blitted scroll would leave it stale
        protected override void OnScroll(ScrollEventArgs se) { base.OnScroll(se); Invalidate(); }
        protected override void OnMouseWheel(MouseEventArgs e) { base.OnMouseWheel(e); Invalidate(); UpdateHover(PointToClient(MousePosition)); }

        int RowAt(Point pt)
        {
            if (pt.Y < HeaderHeight) return -1;
            int i = (pt.Y - HeaderHeight - AutoScrollPosition.Y) / RowHeight;
            return i >= 0 && i < _view.Count ? i : -1;
        }

        void Columns(out int kindX, out int countX, out int timeX, out int right)
        {
            right = ClientSize.Width - Draw.SI(10);
            timeX = right - Draw.SI(110);
            countX = timeX - Draw.SI(72);
            kindX = countX - Draw.SI(108);
        }

        int HeaderAt(Point pt)
        {
            if (pt.Y < 0 || pt.Y >= HeaderHeight) return -1;
            int kindX, countX, timeX, right;
            Columns(out kindX, out countX, out timeX, out right);
            if (pt.X >= timeX) return (int)ActivitySort.LastSeen;
            if (pt.X >= countX) return (int)ActivitySort.Count;
            if (pt.X >= kindX) return (int)ActivitySort.Kind;
            return (int)ActivitySort.Path;
        }

        void UpdateHover(Point pt)
        {
            int i = RowAt(pt), h = HeaderAt(pt);
            if (i != _hover || h != _hoverHead) { _hover = i; _hoverHead = h; Invalidate(); }

            string tip = null;
            if (i >= 0)
            {
                ActivityEntry e = _view[i];
                tip = e.OldPath != null ? e.OldPath + "  →  " + e.Path : e.Path;
            }
            if (tip != _tipShown)
            {
                _tipShown = tip;
                _tip.SetToolTip(this, tip);
            }
            Cursor = i >= 0 || h >= 0 ? Cursors.Hand : Cursors.Default;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            UpdateHover(e.Location);
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (_hover != -1 || _hoverHead != -1) { _hover = -1; _hoverHead = -1; Invalidate(); }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Focus();
            base.OnMouseDown(e);
            int i = RowAt(e.Location);
            if (i >= 0 && (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)) Select(_view[i]);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Left)
            {
                int h = HeaderAt(e.Location);
                if (h >= 0) SortBy((ActivitySort)h);
            }
            else if (e.Button == MouseButtons.Right && RowAt(e.Location) >= 0 && _selected != null)
            {
                RowMenuRequested?.Invoke(this, _selected);
            }
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            if (e.Button != MouseButtons.Left) return;
            int i = RowAt(e.Location);
            if (i >= 0) RowActivated?.Invoke(this, _view[i]);
        }

        void SortBy(ActivitySort col)
        {
            if (_sort == col) _descending = !_descending;
            else
            {
                _sort = col;
                _descending = col == ActivitySort.Count || col == ActivitySort.LastSeen;
            }
            Rebuild();
            if (_selected != null) EnsureVisible(_view.IndexOf(_selected));
        }

        void Select(ActivityEntry e)
        {
            if (_selected == e) return;
            _selected = e;
            Invalidate();
            SelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            Keys k = keyData & Keys.KeyCode;
            return k == Keys.Up || k == Keys.Down || k == Keys.Home || k == Keys.End || k == Keys.PageUp || k == Keys.PageDown
                || k == Keys.Enter || k == Keys.Apps || base.IsInputKey(keyData);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (_view.Count == 0) return;
            int cur = _selected == null ? -1 : _view.IndexOf(_selected);
            int page = Math.Max(1, (ClientSize.Height - HeaderHeight) / RowHeight - 1);
            int next = cur;
            switch (e.KeyCode)
            {
                case Keys.Down: next = Math.Min(_view.Count - 1, cur + 1); break;
                case Keys.Up: next = Math.Max(0, cur - 1); break;
                case Keys.Home: next = 0; break;
                case Keys.End: next = _view.Count - 1; break;
                case Keys.PageDown: next = Math.Min(_view.Count - 1, cur + page); break;
                case Keys.PageUp: next = Math.Max(0, cur - page); break;
                case Keys.Enter:
                    if (_selected != null) RowActivated?.Invoke(this, _selected);
                    e.Handled = true;
                    return;
                case Keys.Apps:
                    if (_selected != null) RowMenuRequested?.Invoke(this, _selected);
                    e.Handled = true;
                    return;
                default: return;
            }
            e.Handled = true;
            if (next < 0) return;
            Select(_view[next]);
            EnsureVisible(next);
        }

        /// <summary>Client-area rectangle of the selected row, for anchoring a keyboard context menu.</summary>
        internal Rectangle SelectedBounds()
        {
            int i = _selected == null ? -1 : _view.IndexOf(_selected);
            if (i < 0) return Rectangle.Empty;
            return new Rectangle(0, HeaderHeight + i * RowHeight + AutoScrollPosition.Y, ClientSize.Width, RowHeight);
        }

        void EnsureVisible(int i)
        {
            if (i < 0) return;
            int top = HeaderHeight + i * RowHeight + AutoScrollPosition.Y;
            int y = -AutoScrollPosition.Y;
            if (top < HeaderHeight) y -= HeaderHeight - top;
            else if (top + RowHeight > ClientSize.Height) y += top + RowHeight - ClientSize.Height;
            AutoScrollPosition = new Point(0, Math.Max(0, y));
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e) { base.OnGotFocus(e); Invalidate(); }
        protected override void OnLostFocus(EventArgs e) { base.OnLostFocus(e); Invalidate(); }

        Color KindColor(ActivityKind kind, Palette p)
        {
            switch (kind)
            {
                case ActivityKind.Created: return Tones.Success(p);
                case ActivityKind.Deleted: return p.Danger;
                case ActivityKind.Renamed: return Tones.Warning(p);
                default: return p.AccentText;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            Color back = BackColor;
            g.Clear(back);

            const TextFormatFlags cell = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix;
            const TextFormatFlags path = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.PathEllipsis | TextFormatFlags.NoPrefix;
            Font font = Typography.Get(10f, Typography.Weight.Regular);
            Font small = Typography.Get(8.5f, Typography.Weight.Semibold);
            Font head = Typography.Get(9f, Typography.Weight.Semibold);
            int w = ClientSize.Width, rowH = RowHeight, headH = HeaderHeight;
            int kindX, countX, timeX, right;
            Columns(out kindX, out countX, out timeX, out right);
            int pathX = Draw.SI(12);

            if (_view.Count == 0)
            {
                TextRenderer.DrawText(g, _emptyText, Typography.Get(10.5f, Typography.Weight.Regular),
                    new Rectangle(Draw.SI(16), headH, Math.Max(0, w - Draw.SI(32)), Math.Max(0, ClientSize.Height - headH)), p.TextSecondary,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.WordBreak | TextFormatFlags.NoPrefix);
            }

            int scroll = AutoScrollPosition.Y;
            int first = Math.Max(0, -scroll / rowH);
            g.SetClip(new Rectangle(0, headH, w, Math.Max(0, ClientSize.Height - headH)));
            for (int i = first; i < _view.Count; i++)
            {
                Rectangle rr = new Rectangle(0, headH + i * rowH + scroll, w, rowH);
                if (rr.Top > ClientSize.Height) break;
                ActivityEntry row = _view[i];
                bool sel = row == _selected;

                g.SmoothingMode = SmoothingMode.AntiAlias;
                Color fill = sel ? ColorMath.Blend(back, p.Accent, Focused ? 0.16 : 0.10) : (i == _hover ? ColorMath.Blend(back, p.TextPrimary, 0.06) : Color.Empty);
                if (!fill.IsEmpty)
                {
                    using (GraphicsPath hp = Draw.RoundedRect(new RectangleF(rr.X, rr.Y + 1, rr.Width - 1, rr.Height - 2), Draw.S(5)))
                    using (SolidBrush hb = new SolidBrush(fill))
                    {
                        g.FillPath(hb, hp);
                    }
                }
                if (sel && Focused)
                {
                    float bar = Draw.S(3);
                    using (GraphicsPath bp = Draw.RoundedRect(new RectangleF(rr.X + Draw.S(2), rr.Y + rowH * 0.3f, bar, rowH * 0.4f), bar / 2))
                    using (SolidBrush ab = new SolidBrush(p.Accent))
                    {
                        g.FillPath(ab, bp);
                    }
                }

                Color kc = KindColor(row.Kind, p);
                string kn = KindName(row.Kind);
                Size ks = TextRenderer.MeasureText(g, kn, small, Size.Empty, TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix);
                int pillH = Draw.SI(20), pillW = Math.Min(countX - kindX - Draw.SI(8), ks.Width + Draw.SI(16));
                RectangleF pill = new RectangleF(kindX, rr.Y + (rowH - pillH) / 2f, pillW, pillH);
                using (GraphicsPath pp = Draw.RoundedRect(pill, pillH / 2f))
                using (SolidBrush pb = new SolidBrush(ColorMath.Blend(back, kc, p.IsDark ? 0.20 : 0.14)))
                {
                    g.FillPath(pb, pp);
                }
                g.SmoothingMode = SmoothingMode.None;
                TextRenderer.DrawText(g, kn, small, Rectangle.Round(pill), kc,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine | TextFormatFlags.EndEllipsis | TextFormatFlags.NoPrefix);

                Rectangle pr = new Rectangle(pathX, rr.Y, Math.Max(0, kindX - pathX - Draw.SI(12)), rowH);
                if (row.OldPath != null)
                {
                    string oldName = SafeName(row.OldPath), arrow = oldName + "  →  ";
                    int aw = Math.Min(pr.Width / 2, TextRenderer.MeasureText(g, arrow, font, Size.Empty, TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix).Width);
                    TextRenderer.DrawText(g, arrow, font, new Rectangle(pr.X, pr.Y, aw, rowH), p.TextSecondary, cell | TextFormatFlags.NoPadding);
                    pr = new Rectangle(pr.X + aw, pr.Y, Math.Max(0, pr.Width - aw), rowH);
                }
                TextRenderer.DrawText(g, row.Path, font, pr, p.TextPrimary, path);
                TextRenderer.DrawText(g, row.Count.ToString("N0"), font, new Rectangle(countX, rr.Y, Math.Max(0, timeX - countX - Draw.SI(8)), rowH), p.TextSecondary, cell);
                TextRenderer.DrawText(g, row.LastSeen.ToLongTimeString(), font, new Rectangle(timeX, rr.Y, Math.Max(0, right - timeX), rowH), p.TextSecondary, cell);
            }
            g.ResetClip();

            using (SolidBrush hb = new SolidBrush(back)) g.FillRectangle(hb, 0, 0, w, headH);
            int[] xs = { pathX, kindX, countX, timeX, right };
            for (int c = 0; c < 4; c++)
            {
                Rectangle hr = new Rectangle(xs[c], 0, Math.Max(0, xs[c + 1] - xs[c] - Draw.SI(8)), headH);
                bool active = (int)_sort == c;
                Color tc = active || _hoverHead == c ? p.TextPrimary : p.TextSecondary;
                string text = _cols[c];
                Size ts = TextRenderer.MeasureText(g, text, head, Size.Empty, TextFormatFlags.NoPadding | TextFormatFlags.NoPrefix);
                TextRenderer.DrawText(g, text, head, hr, tc, cell | TextFormatFlags.NoPadding);
                if (active && ts.Width + Draw.SI(14) < hr.Width)
                {
                    float cx = hr.X + ts.Width + Draw.S(9), cy = headH / 2f, s = Draw.S(3);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    using (Pen cp = new Pen(tc, Draw.S(1.3f)) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
                    {
                        if (_descending) g.DrawLines(cp, new[] { new PointF(cx - s, cy - s / 2), new PointF(cx, cy + s / 2), new PointF(cx + s, cy - s / 2) });
                        else g.DrawLines(cp, new[] { new PointF(cx - s, cy + s / 2), new PointF(cx, cy - s / 2), new PointF(cx + s, cy + s / 2) });
                    }
                    g.SmoothingMode = SmoothingMode.None;
                }
            }
            using (Pen line = new Pen(p.Stroke)) g.DrawLine(line, 0, headH - 1, w, headH - 1);
        }

        static string SafeName(string path)
        {
            try { return System.IO.Path.GetFileName(path); }
            catch (ArgumentException) { return path; }
        }
    }
}
