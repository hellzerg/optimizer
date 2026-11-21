using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// The bundled logo is an opaque square with a transparent checkmark cut-out.
    /// This turns it into an accent-colored checkmark on a transparent background.
    /// </summary>
    internal static class LogoArt {
        sealed class State {
            public Image OwnedImage;
            public bool Hooked;
        }

        static Bitmap _cached;
        static Color _cachedAccent;
        static readonly object _sync = new object();
        static readonly ConditionalWeakTable<PictureBox, State> _states = new ConditionalWeakTable<PictureBox, State>();

        internal static void Apply(PictureBox box)
        {
            if (box == null || box.IsDisposed) return;

            State state = _states.GetValue(box, key => new State());
            if (!state.Hooked)
            {
                state.Hooked = true;
                box.Disposed += Box_Disposed;
            }

            Color accent = ThemeManager.Current.Accent;
            Bitmap copy;
            lock (_sync)
            {
                if (_cached == null || _cachedAccent != accent)
                {
                    Bitmap old = _cached;
                    _cached = Create(Properties.Resources.logo, accent);
                    _cachedAccent = accent;
                    if (old != null) old.Dispose();
                }
                copy = new Bitmap(_cached);
            }

            Image previous = state.OwnedImage;
            box.Image = copy;
            box.BackColor = Color.Transparent;
            state.OwnedImage = copy;
            if (previous != null) previous.Dispose();
        }

        static void Box_Disposed(object sender, System.EventArgs e)
        {
            State state;
            if (!_states.TryGetValue((PictureBox)sender, out state)) return;
            if (state.OwnedImage != null)
            {
                state.OwnedImage.Dispose();
                state.OwnedImage = null;
            }
        }

        static Bitmap Create(Image source, Color accent)
        {
            using (Bitmap src = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppArgb))
            using (Graphics graphics = Graphics.FromImage(src))
            {
                graphics.DrawImageUnscaled(source, 0, 0);
                Bitmap result = new Bitmap(src.Width, src.Height, PixelFormat.Format32bppArgb);
                BitmapData sourceData = null;
                BitmapData resultData = null;

                try
                {
                    try
                    {
                        Rectangle bounds = new Rectangle(0, 0, src.Width, src.Height);
                        sourceData = src.LockBits(bounds, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                        resultData = result.LockBits(bounds, ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                        int[] row = new int[src.Width];
                        int rgb = (accent.R << 16) | (accent.G << 8) | accent.B;
                        for (int y = 0; y < src.Height; y++)
                        {
                            Marshal.Copy(IntPtr.Add(sourceData.Scan0, y * sourceData.Stride), row, 0, row.Length);
                            for (int x = 0; x < row.Length; x++)
                            {
                                int alpha = 255 - ((row[x] >> 24) & 0xFF);
                                row[x] = (alpha << 24) | rgb;
                            }
                            Marshal.Copy(row, 0, IntPtr.Add(resultData.Scan0, y * resultData.Stride), row.Length);
                        }
                    }
                    finally
                    {
                        try
                        {
                            if (resultData != null) result.UnlockBits(resultData);
                        }
                        finally
                        {
                            if (sourceData != null) src.UnlockBits(sourceData);
                        }
                    }
                }
                catch
                {
                    result.Dispose();
                    throw;
                }

                return result;
            }
        }
    }
}
