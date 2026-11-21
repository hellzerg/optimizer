using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Optimizer {
    public sealed partial class AppCard : UserControl, IThemeable {
        bool _hover;
        Control _host;
        UwpApp _app;

        internal bool OwnsImage { get; set; }

        internal static Bitmap CreateThemeAwareImage(Image source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            Bitmap result = new Bitmap(source.Width, source.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            try
            {
                using (Graphics graphics = Graphics.FromImage(result))
                {
                    graphics.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    graphics.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height));
                }

                int width = result.Width;
                int height = result.Height;
                if ((long)width * height > 4L * 1024L * 1024L || !HasOpaqueBlackCorners(result)) return result;

                int length = checked(width * height);
                System.Drawing.Imaging.BitmapData data = null;
                try
                {
                    data = result.LockBits(new Rectangle(0, 0, width, height), System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                    int[] pixels = new int[length];
                    int[] row = new int[width];
                    for (int y = 0; y < height; y++)
                    {
                        System.Runtime.InteropServices.Marshal.Copy(IntPtr.Add(data.Scan0, y * data.Stride), row, 0, width);
                        Array.Copy(row, 0, pixels, y * width, width);
                    }

                    bool[] visited = new bool[length];
                    int[] queue = new int[length];
                    int head = 0;
                    int tail = 0;

                    for (int x = 0; x < width; x++)
                    {
                        EnqueueMattePixel(x, pixels, visited, queue, ref tail);
                        EnqueueMattePixel((height - 1) * width + x, pixels, visited, queue, ref tail);
                    }
                    for (int y = 1; y < height - 1; y++)
                    {
                        EnqueueMattePixel(y * width, pixels, visited, queue, ref tail);
                        EnqueueMattePixel(y * width + width - 1, pixels, visited, queue, ref tail);
                    }

                    while (head < tail)
                    {
                        int index = queue[head++];
                        int pixel = pixels[index];
                        int red = (pixel >> 16) & 0xFF;
                        int green = (pixel >> 8) & 0xFF;
                        int blue = pixel & 0xFF;
                        int alpha = Math.Max(red, Math.Max(green, blue));

                        if (alpha == 0)
                        {
                            pixels[index] = 0;
                        }
                        else
                        {
                            red = Math.Min(255, (red * 255 + alpha / 2) / alpha);
                            green = Math.Min(255, (green * 255 + alpha / 2) / alpha);
                            blue = Math.Min(255, (blue * 255 + alpha / 2) / alpha);
                            pixels[index] = (alpha << 24) | (red << 16) | (green << 8) | blue;
                        }

                        int x = index % width;
                        int y = index / width;
                        if (x > 0) EnqueueMattePixel(index - 1, pixels, visited, queue, ref tail);
                        if (x + 1 < width) EnqueueMattePixel(index + 1, pixels, visited, queue, ref tail);
                        if (y > 0) EnqueueMattePixel(index - width, pixels, visited, queue, ref tail);
                        if (y + 1 < height) EnqueueMattePixel(index + width, pixels, visited, queue, ref tail);
                    }

                    for (int y = 0; y < height; y++)
                    {
                        Array.Copy(pixels, y * width, row, 0, width);
                        System.Runtime.InteropServices.Marshal.Copy(row, 0, IntPtr.Add(data.Scan0, y * data.Stride), width);
                    }
                }
                finally
                {
                    if (data != null) result.UnlockBits(data);
                }

                return result;
            }
            catch
            {
                result.Dispose();
                throw;
            }
        }

        static bool HasOpaqueBlackCorners(Bitmap image)
        {
            return IsBlackCorner(image.GetPixel(0, 0))
                && IsBlackCorner(image.GetPixel(image.Width - 1, 0))
                && IsBlackCorner(image.GetPixel(0, image.Height - 1))
                && IsBlackCorner(image.GetPixel(image.Width - 1, image.Height - 1));
        }

        static bool IsBlackCorner(Color color)
        {
            return color.A >= 240 && Math.Max(color.R, Math.Max(color.G, color.B)) <= 16;
        }

        static void EnqueueMattePixel(int index, int[] pixels, bool[] visited, int[] queue, ref int tail)
        {
            if (visited[index] || !IsBlackMattePixel(pixels[index])) return;
            visited[index] = true;
            queue[tail++] = index;
        }

        static bool IsBlackMattePixel(int pixel)
        {
            int alpha = (pixel >> 24) & 0xFF;
            int red = (pixel >> 16) & 0xFF;
            int green = (pixel >> 8) & 0xFF;
            int blue = pixel & 0xFF;
            return alpha >= 240 && Math.Max(red, Math.Max(green, blue)) <= 128;
        }

        public AppCard()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            foreach (Control c in new Control[] { appTitle, appImage, appSubtitle })
            {
                c.MouseEnter += (s, e) => SetHover(true);
                c.MouseLeave += (s, e) => SetHover(ClientRectangle.Contains(PointToClient(Cursor.Position)));
            }
            appImage.Click += (s, e) => appTitle.Checked = !appTitle.Checked;
            appSubtitle.Click += (s, e) => appTitle.Checked = !appTitle.Checked;
            appTitle.CheckedChanged += (s, e) => Invalidate();

            ApplyTheme(ThemeManager.Current);
        }

        /// <summary>
        /// Packaged app shown by this card. Setting it switches to the two-line layout (friendly name + package name).
        /// </summary>
        public UwpApp App
        {
            get { return _app; }
            set
            {
                _app = value;
                if (value == null) return;

                appTitle.Text = value.Title;
                appSubtitle.Text = value.Name;
                appSubtitle.Visible = true;
                appImage.Image = value.Logo;
                GlyphTint.Apply(appImage, ThemeManager.Current);
                PerformLayout();
            }
        }

        /// <summary>
        /// When false the card keeps the size its owner gives it (grid tile) instead of stretching to the host width.
        /// </summary>
        public bool StretchToHost { get; set; } = true;

        protected override void OnClick(EventArgs e)
        {
            appTitle.Checked = !appTitle.Checked;
            base.OnClick(e);
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (_app == null)
            {
                if (StretchToHost || AutoSize) return;

                int pad = Draw.SI(10), icon = Draw.SI(24);
                appImage.Bounds = new Rectangle(pad, (Height - icon) / 2, icon, icon);
                int tx = pad + icon + Draw.SI(6);
                int th = Math.Min(Height, Math.Max(Draw.SI(24), appTitle.GetPreferredSize(Size.Empty).Height));
                appTitle.Bounds = new Rectangle(tx, (Height - th) / 2, Math.Max(0, Width - tx - Draw.SI(6)), th);
                return;
            }

            int left = Draw.SI(10);
            int top = Draw.SI(6);
            int logo = Draw.SI(32);

            appTitle.Location = new Point(left + logo + Draw.SI(8), top);
            // align the package name with the title text, past the check glyph
            appSubtitle.Location = new Point(appTitle.Left + appTitle.Padding.Left + Draw.SI(27), appTitle.Bottom - Draw.SI(1));

            int content = appSubtitle.Bottom - top;
            appImage.Bounds = new Rectangle(left, top + (content - logo) / 2, logo, logo);
        }

        Color CardFill
        {
            get { return _hover ? ThemeManager.Current.Layer1Hover : ThemeManager.Current.Layer1; }
        }

        public void ApplyTheme(Palette palette)
        {
            BackColor = CardFill;
            appImage.BackColor = Color.Transparent;
            appSubtitle.BackColor = BackColor;
            appSubtitle.ForeColor = palette.TextSecondary;
            appTitle.ApplyTheme(palette);
            Invalidate(true);
        }

        void SetHover(bool hover)
        {
            if (_hover == hover) return;
            _hover = hover;
            ApplyTheme(ThemeManager.Current);
        }

        protected override void OnMouseEnter(EventArgs e) { SetHover(true); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { SetHover(ClientRectangle.Contains(PointToClient(Cursor.Position))); base.OnMouseLeave(e); }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);

            if (_host != null) _host.SizeChanged -= Host_SizeChanged;
            _host = Parent;
            if (_host == null) return;

            _host.SizeChanged += Host_SizeChanged;
            ApplyTheme(ThemeManager.Current);
            Host_SizeChanged(_host, EventArgs.Empty);
        }

        void Host_SizeChanged(object sender, EventArgs e)
        {
            if (_host == null || !StretchToHost) return;

            // stretch to the column width so cards line up as a uniform list
            int reserve = SystemInformation.VerticalScrollBarWidth + Draw.SI(4);
            int target = _host.ClientSize.Width - reserve - Left;
            if (target > MinimumSize.Width) Width = Math.Max(PreferredSize.Width, target);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Palette p = ThemeManager.Current;
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : p.WindowBg);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF r = new RectangleF(0.5f, 0.5f, Width - 1.5f, Height - 1.5f);
            using (GraphicsPath path = Draw.RoundedRect(r, Draw.S(5)))
            using (SolidBrush b = new SolidBrush(CardFill))
            {
                g.FillPath(b, path);
            }
        }
    }
}