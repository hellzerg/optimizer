using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// The bundled logo is an opaque square with a transparent checkmark cut-out.
    /// This turns it into an accent-colored checkmark on a transparent background.
    /// </summary>
    internal static class LogoArt {
        static Bitmap _cached;
        static Color _cachedAccent;
        static readonly object _sync = new object();

        internal static void Apply(PictureBox box)
        {
            Color accent = ThemeManager.Current.Accent;
            Bitmap copy;
            lock (_sync)
            {
                if (_cached == null || _cachedAccent != accent)
                {
                    Bitmap old = _cached;
                    using (Image logo = Properties.Resources.logo) _cached = Create(logo, accent);
                    _cachedAccent = accent;
                    if (old != null) old.Dispose();
                }
                // each box owns its image so no GDI+ bitmap is shared between forms
                copy = new Bitmap(_cached);
            }

            Image previous = box.Image;
            box.Image = copy;
            box.BackColor = Color.Transparent;
            if (previous != null) previous.Dispose();
        }

        static Bitmap Create(Image source, Color accent)
        {
            Bitmap result = new Bitmap(source.Width, source.Height, PixelFormat.Format32bppArgb);
            using (Bitmap src = new Bitmap(source))
            {
                for (int y = 0; y < src.Height; y++)
                {
                    for (int x = 0; x < src.Width; x++)
                    {
                        result.SetPixel(x, y, Color.FromArgb(255 - src.GetPixel(x, y).A, accent));
                    }
                }
            }
            return result;
        }
    }
}
