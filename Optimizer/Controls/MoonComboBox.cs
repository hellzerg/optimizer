using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed class MoonComboBox : ComboBox
    {
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr ptr);
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        private Color _color = Color.FromArgb(40, 40, 40);
        private Color _selectedItemColor = Color.FromArgb(40, 40, 40);
        private Color _borderColor = Color.FromArgb(61, 61, 61);
        private Color _separatorLineColor = Color.FromArgb(61, 61, 61);

        public Color SelectColor
        {
            get => _selectedItemColor;
            set
            {
                _selectedItemColor = value;
                Invalidate();
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            LinearGradientBrush LGB = new LinearGradientBrush(e.Bounds, _selectedItemColor, ColorHelper.ChangeColorBrightness(_selectedItemColor, 0.7), 90.0F);

            if (Convert.ToInt32(e.State & DrawItemState.Selected) == (int)DrawItemState.Selected)
            {
                if (!(e.Index == -1))
                {
                    e.Graphics.FillRectangle(LGB, e.Bounds);
                    e.Graphics.DrawString(GetItemText(Items[e.Index]), e.Font, new SolidBrush(GetContrastColor(SelectColor)), e.Bounds);
                }
            }
            else
            {
                if (!(e.Index == -1))
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(40, 40, 40)), e.Bounds);
                    e.Graphics.DrawString(GetItemText(Items[e.Index]), e.Font, Brushes.DimGray, e.Bounds);
                }
            }
            LGB.Dispose();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            SuspendLayout();
            Update();
            ResumeLayout();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (!Focused)
            {
                SelectionLength = 0;
            }
        }

        private static int DPIScale
        {
            get
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                int DC = GetDeviceCaps(hdc, 0x58);
                ReleaseDC(IntPtr.Zero, hdc);
                return DC;
            }
        }

        private int GetDPIScaleFactor(int currentDPI)
        {
            switch (currentDPI)
            {
                case 96:
                    return 25;
                case 120:
                    return 30;
                case 144:
                    return 35;
                case 192:
                    return 40;
                default:
                    return 25;
            }
        }

        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);

            DropDownHeight = Items.Count * GetDPIScaleFactor(DPIScale);
        }

        public MoonComboBox()
        {
            SetStyle((ControlStyles)0x22016, true);
            SetStyle(ControlStyles.Selectable, false);

            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;

            BackColor = Color.FromArgb(246, 246, 246);
            ForeColor = Color.FromArgb(76, 76, 97);
            Size = new Size(135, 27);
            Cursor = Cursors.Hand;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        private Color GetContrastColor(Color c)
        {
            double brightness = c.R * 0.299 + c.G * 0.587 + c.B * 0.114;
            return brightness > 149 ? Color.Black : Color.White;
        }

        public enum Direction
        {
            Up, Down
        }

        private void DrawTriangle(Graphics g, Rectangle rect, Direction direction)
        {
            int halfWidth = rect.Width / 2;
            Point p0 = Point.Empty;
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;

            switch (direction)
            {
                case Direction.Up:
                    p0 = new Point(rect.Left + halfWidth, rect.Top);
                    p1 = new Point(rect.Left, rect.Bottom);
                    p2 = new Point(rect.Right, rect.Bottom);
                    break;
                case Direction.Down:
                    p0 = new Point(rect.Left + halfWidth, rect.Bottom);
                    p1 = new Point(rect.Left, rect.Top);
                    p2 = new Point(rect.Right, rect.Top);
                    break;
            }

            g.FillPolygon(Brushes.DarkGray, new Point[] { p0, p1, p2 });
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.High;

            e.Graphics.Clear(Parent.BackColor);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);

            GraphicsPath GP = GetFigurePath(rect, 5);

            LinearGradientBrush LGB = new LinearGradientBrush(ClientRectangle, _color, ColorHelper.ChangeColorBrightness(_color, 0.8), 90.0F);

            e.Graphics.SetClip(GP);
            e.Graphics.FillRectangle(LGB, ClientRectangle);
            e.Graphics.ResetClip();

            e.Graphics.DrawPath(new Pen(_borderColor), GP);

            e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(3, 0, Width - 20, Height), new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Near
            });

            DrawTriangle(e.Graphics, new Rectangle(Width - 17, (Height / 2) - 4, 8, 8), DroppedDown ? Direction.Up : Direction.Down);

            e.Graphics.DrawLine(new Pen(ColorHelper.ChangeColorBrightness(_separatorLineColor, 0.8)), Width - 24, 5, Width - 24, Height - 6);
            e.Graphics.DrawLine(new Pen(_separatorLineColor), Width - 25, 5, Width - 25, Height - 6);
        }
    }
}