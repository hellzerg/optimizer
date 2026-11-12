using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace Optimizer {
    /// <summary>
    /// Maps the legacy "Segoe UI / Segoe UI Semibold + Bold" designer fonts to a modern type ramp:
    /// Segoe UI Variable on Windows 11, plain Segoe UI elsewhere. Font instances are cached and shared.
    /// </summary>
    internal static class Typography {
        internal enum Weight { Regular, Semibold, Display }

        static readonly Dictionary<string, Font> _cache = new Dictionary<string, Font>(StringComparer.Ordinal);
        static readonly bool _variable = IsInstalled("Segoe UI Variable Text");

        const string VarText = "Segoe UI Variable Text";
        const string VarTextSemibold = "Segoe UI Variable Text Semibold";
        const string VarDisplaySemibold = "Segoe UI Variable Display Semib";

        static bool IsInstalled(string family)
        {
            try
            {
                using (InstalledFontCollection fonts = new InstalledFontCollection())
                {
                    foreach (FontFamily f in fonts.Families)
                    {
                        if (string.Equals(f.Name, family, StringComparison.OrdinalIgnoreCase)) return true;
                    }
                }
            }
            catch { }
            return false;
        }

        static string FamilyFor(Weight weight)
        {
            switch (weight)
            {
                case Weight.Display: return _variable ? VarDisplaySemibold : "Segoe UI Semibold";
                case Weight.Semibold: return _variable ? VarTextSemibold : "Segoe UI Semibold";
                default: return _variable ? VarText : "Segoe UI";
            }
        }

        internal static Font Get(float sizeInPoints, Weight weight, FontStyle extra = FontStyle.Regular)
        {
            string family = FamilyFor(weight);
            extra &= FontStyle.Underline | FontStyle.Strikeout;
            string key = family + "|" + sizeInPoints.ToString(System.Globalization.CultureInfo.InvariantCulture) + "|" + (int)extra;

            Font font;
            if (!_cache.TryGetValue(key, out font))
            {
                font = new Font(family, sizeInPoints, extra, GraphicsUnit.Point);
                _cache[key] = font;
            }
            return font;
        }

        /// <summary>Semibold counterpart of a font (replaces synthesized bold).</summary>
        internal static Font Emphasize(Font font)
        {
            return Get(font.SizeInPoints, Weight.Semibold, font.Style);
        }

        /// <summary>Cached equivalent of <c>new Font(font, style)</c>.</summary>
        internal static Font WithStyle(Font font, FontStyle style)
        {
            if (font.Style == style) return font;
            string key = "S|" + font.FontFamily.Name + "|" + font.SizeInPoints.ToString(System.Globalization.CultureInfo.InvariantCulture) + "|" + (int)style;
            Font result;
            if (!_cache.TryGetValue(key, out result))
            {
                result = new Font(font.FontFamily, font.SizeInPoints, style, GraphicsUnit.Point);
                _cache[key] = result;
            }
            return result;
        }

        static bool IsLegacy(Font f)
        {
            string name = f.FontFamily.Name;
            return name == "Segoe UI" || name == "Segoe UI Semibold";
        }

        static bool IsModern(Font f)
        {
            string name = f.FontFamily.Name;
            return name.StartsWith("Segoe UI Variable", StringComparison.Ordinal);
        }

        /// <summary>
        /// Remaps a single control's font. Idempotent: modern or non-Segoe fonts (e.g. Consolas) are left alone.
        /// </summary>
        internal static void Modernize(Control c)
        {
            Font f = c.Font;
            if (f == null || IsModern(f) || !IsLegacy(f)) return;

            bool heavy = f.FontFamily.Name == "Segoe UI Semibold" || f.Bold;
            float size = f.SizeInPoints;
            Weight weight;

            if (heavy && size >= 14f) weight = Weight.Display;
            else if (heavy && WantsEmphasis(c)) weight = Weight.Semibold;
            else weight = Weight.Regular;

            Font target = Get(size, weight, f.Style);
            if (!ReferenceEquals(target, f) &&
                !(target.FontFamily.Name == f.FontFamily.Name && target.Style == f.Style && target.SizeInPoints == size))
            {
                c.Font = target;
            }
        }

        internal static void Modernize(ToolStripItem item)
        {
            Font f = item.Font;
            if (f == null || IsModern(f) || !IsLegacy(f)) return;
            Font target = Get(f.SizeInPoints, Weight.Regular, f.Style);
            if (target.FontFamily.Name != f.FontFamily.Name || target.Style != f.Style) item.Font = target;
        }

        static bool WantsEmphasis(Control c)
        {
            if (c is CheckBox || c is RadioButton) return false;
            if (c is ButtonBase || c is TabControl || c is LinkLabel) return true;
            if (c is Label)
            {
                TextRole role = ThemeManager.GetRole(c);
                return role == TextRole.Title || role == TextRole.Accent;
            }
            return false;
        }
    }
}
