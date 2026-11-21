using System;
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
            public bool Hooked;
        }

        sealed class GlyphInfo { public bool IsWhiteGlyph; }

        static readonly ConditionalWeakTable<PictureBox, State> _states = new ConditionalWeakTable<PictureBox, State>();
        static readonly ConditionalWeakTable<Image, GlyphInfo> _glyphs = new ConditionalWeakTable<Image, GlyphInfo>();

        internal static void Apply(PictureBox box, Palette palette)
        {
            if (box == null || box.IsDisposed) return;

            State state = _states.GetValue(box, key => new State());
            if (!state.Hooked)
            {
                state.Hooked = true;
                box.Disposed += Box_Disposed;
            }

            Image current = box.Image;
            if (current == null)
            {
                DisposeTinted(state);
                state.Original = null;
                return;
            }

            if (current != state.Tinted && current != state.Original)
            {
                DisposeTinted(state);
                state.Original = current;
            }

            if (!IsWhiteGlyph(state.Original)) return;

            if (palette.IsDark)
            {
                if (box.Image != state.Original) box.Image = state.Original;
                return;
            }

            if (state.Tinted == null || state.TintColor != palette.TextPrimary)
            {
                Image previous = state.Tinted;
                state.Tinted = Tint(state.Original, palette.TextPrimary);
                state.TintColor = palette.TextPrimary;
                box.Image = state.Tinted;
                if (previous != null) previous.Dispose();
                return;
            }

            if (box.Image != state.Tinted) box.Image = state.Tinted;
        }

        internal static void Release(PictureBox box, bool disposeOriginal)
        {
            if (box == null) return;

            State state;
            if (_states.TryGetValue(box, out state))
            {
                Image original = state.Original;
                Image tinted = state.Tinted;
                state.Original = null;
                state.Tinted = null;
                box.Image = null;

                if (tinted != null) tinted.Dispose();
                if (disposeOriginal && original != null && !ReferenceEquals(original, tinted)) original.Dispose();
                return;
            }

            if (disposeOriginal)
            {
                Image image = box.Image;
                box.Image = null;
                if (image != null) image.Dispose();
            }
        }

        static void Box_Disposed(object sender, System.EventArgs e)
        {
            State state;
            if (!_states.TryGetValue((PictureBox)sender, out state)) return;
            DisposeTinted(state);
            state.Original = null;
        }

        static void DisposeTinted(State state)
        {
            if (state.Tinted == null) return;
            state.Tinted.Dispose();
            state.Tinted = null;
        }

        static bool IsWhiteGlyph(Image image)
        {
            GlyphInfo info;
            if (_glyphs.TryGetValue(image, out info)) return info.IsWhiteGlyph;

            info = Analyze(image);
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
                if ((long)image.Width * image.Height > 1024L * 1024L) return info;
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
            BitmapData data = null;
            try
            {
                try
                {
                    data = result.LockBits(new Rectangle(0, 0, result.Width, result.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
                    int[] row = new int[result.Width];
                    for (int y = 0; y < result.Height; y++)
                    {
                        System.Array.Copy(px, y * result.Width, row, 0, row.Length);
                        Marshal.Copy(row, 0, IntPtr.Add(data.Scan0, y * data.Stride), row.Length);
                    }
                }
                finally
                {
                    if (data != null) result.UnlockBits(data);
                }
            }
            catch
            {
                result.Dispose();
                throw;
            }
            return result;
        }

        static int[] ReadPixels(Image image)
        {
            using (Bitmap bmp = new Bitmap(image.Width, image.Height, PixelFormat.Format32bppArgb))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(image, 0, 0, image.Width, image.Height);
                BitmapData data = null;
                try
                {
                    data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                    int[] px = new int[bmp.Width * bmp.Height];
                    int[] row = new int[bmp.Width];
                    for (int y = 0; y < bmp.Height; y++)
                    {
                        Marshal.Copy(IntPtr.Add(data.Scan0, y * data.Stride), row, 0, row.Length);
                        System.Array.Copy(row, 0, px, y * bmp.Width, row.Length);
                    }
                    return px;
                }
                finally
                {
                    if (data != null) bmp.UnlockBits(data);
                }
            }
        }
    }
}
