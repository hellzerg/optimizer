using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Many bundled icons are white glyphs on transparency, designed for the dark theme.
    /// On light themes they are recolored to the primary text color so they stay visible.
    /// </summary>
    internal static class GlyphTint {
        sealed class State {
            public Image Original;
            public Image Tinted;
            public Color TintColor;
        }

        sealed class GlyphInfo { public bool IsWhiteGlyph; }

        static readonly ConditionalWeakTable<PictureBox, State> _states = new ConditionalWeakTable<PictureBox, State>();
        static readonly ConditionalWeakTable<Image, GlyphInfo> _glyphs = new ConditionalWeakTable<Image, GlyphInfo>();

        internal static void Apply(PictureBox box, Palette palette)
        {
            Image current = box.Image;
            if (current == null) return;

            State state = _states.GetValue(box, k => new State());
            if (current != state.Tinted)
            {
                // the image was replaced by code, so it becomes the new original
                state.Original = current;
                state.Tinted = null;
            }

            if (!IsWhiteGlyph(state.Original)) return;

            if (palette.IsDark)
            {
                if (box.Image != state.Original) box.Image = state.Original;
                return;
            }

            if (state.Tinted == null || state.TintColor != palette.TextPrimary)
            {
                state.Tinted = Tint(state.Original, palette.TextPrimary);
                state.TintColor = palette.TextPrimary;
            }
            box.Image = state.Tinted;
        }

        static bool IsWhiteGlyph(Image image)
        {
            GlyphInfo info;
            if (_glyphs.TryGetValue(image, out info)) return info.IsWhiteGlyph;

            info = Analyze(image);
            // a failed read (image busy or backed by a closed stream) is not cached, so the next theme pass retries
            if (info == null) return false;

            try { _glyphs.Add(image, info); }
            catch (System.ArgumentException) { }
            return info.IsWhiteGlyph;
        }

        static GlyphInfo Analyze(Image image)
        {
            GlyphInfo info = new GlyphInfo();
            int[] px;
            try
            {
                if (image.Width * image.Height > 1024 * 1024) return info;
                px = ReadPixels(image);
            }
            catch (System.Exception)
            {
                return null;
            }

            int visible = 0, transparent = 0;
            foreach (int v in px)
            {
                int a = (v >> 24) & 0xFF, r = (v >> 16) & 0xFF, g = (v >> 8) & 0xFF, b = v & 0xFF;
                if (a < 40) { transparent++; continue; }
                if (a > 160 && (r < 200 || g < 200 || b < 200)) return info;
                visible++;
            }
            info.IsWhiteGlyph = visible > 0 && transparent > 0;
            return info;
        }

        static Image Tint(Image source, Color color)
        {
            int[] px = ReadPixels(source);
            int rgb = color.ToArgb() & 0xFFFFFF;
            for (int i = 0; i < px.Length; i++) px[i] = (px[i] & unchecked((int)0xFF000000)) | rgb;

            Bitmap result = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppArgb);
            BitmapData data = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(px, 0, data.Scan0, px.Length);
            result.UnlockBits(data);
            return result;
        }

        static int[] ReadPixels(Image image)
        {
            using (Bitmap bmp = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb))
            {
                using (Graphics g = Graphics.FromImage(bmp)) g.DrawImage(image, 0, 0, image.Width, image.Height);
                BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                int[] px = new int[bmp.Width * bmp.Height];
                Marshal.Copy(data.Scan0, px, 0, px.Length);
                bmp.UnlockBits(data);
                return px;
            }
        }
    }
}
