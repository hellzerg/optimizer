using System;
using System.Drawing;

namespace Optimizer {
    /// <summary>
    /// Semantic color tokens modelled after the Windows 11 (Fluent) design language.
    /// </summary>
    public sealed class Palette {
        internal static readonly Color DefaultAccent = Color.FromArgb(153, 102, 204);

        public ThemeMode Mode { get; private set; }
        public bool IsDark { get { return Mode == ThemeMode.Dark; } }

        public Color WindowBg { get; private set; }
        public Color Sidebar { get; private set; }
        public Color Layer1 { get; private set; }
        public Color Layer1Hover { get; private set; }
        public Color Layer2 { get; private set; }
        public Color ControlFill { get; private set; }
        public Color ControlHover { get; private set; }
        public Color ControlPressed { get; private set; }
        public Color InputFill { get; private set; }
        public Color Stroke { get; private set; }
        public Color StrokeStrong { get; private set; }
        public Color TextPrimary { get; private set; }
        public Color TextSecondary { get; private set; }
        public Color TextDisabled { get; private set; }
        public Color Accent { get; private set; }
        public Color AccentHover { get; private set; }
        public Color AccentPressed { get; private set; }
        public Color AccentText { get; private set; }
        public Color OnAccent { get; private set; }
        public Color Selection { get; private set; }
        public Color ToggleOff { get; private set; }
        public Color Danger { get; private set; }

        internal static Palette Create(ThemeMode mode, Color accent)
        {
            if (accent.IsEmpty || accent.A == 0) accent = DefaultAccent;
            accent = Color.FromArgb(255, accent);

            Palette p = new Palette { Mode = mode, Accent = accent };
            p.OnAccent = ColorMath.Contrast(accent, Color.Black) >= ColorMath.Contrast(accent, Color.White) ? Color.Black : Color.White;
            Color accentStateTarget = p.OnAccent == Color.White ? Color.Black : Color.White;

            if (mode == ThemeMode.Light)
            {
                p.WindowBg = Color.FromArgb(243, 243, 243);
                p.Sidebar = Color.FromArgb(232, 232, 232);
                p.Layer1 = Color.FromArgb(251, 251, 251);
                p.Layer1Hover = Color.FromArgb(238, 238, 238);
                p.Layer2 = Color.FromArgb(255, 255, 255);
                p.ControlFill = Color.FromArgb(253, 253, 253);
                p.ControlHover = Color.FromArgb(238, 238, 238);
                p.ControlPressed = Color.FromArgb(228, 228, 228);
                p.InputFill = Color.FromArgb(255, 255, 255);
                p.Stroke = Color.FromArgb(140, 140, 140);
                p.StrokeStrong = Color.FromArgb(110, 110, 110);
                p.TextPrimary = Color.FromArgb(27, 27, 27);
                p.TextSecondary = Color.FromArgb(88, 88, 88);
                p.TextDisabled = Color.FromArgb(136, 136, 136);
                p.Selection = Color.FromArgb(212, 212, 212);
                p.ToggleOff = Color.FromArgb(126, 126, 126);
                p.Danger = Color.FromArgb(196, 43, 28);
                p.AccentHover = ColorMath.Blend(accent, accentStateTarget, 0.10);
                p.AccentPressed = ColorMath.Blend(accent, accentStateTarget, 0.20);
                p.AccentText = ColorMath.EnsureContrast(accent, p.Layer1, 4.5, Color.Black);
            }
            else
            {
                p.WindowBg = Color.FromArgb(32, 32, 32);
                p.Sidebar = Color.FromArgb(24, 24, 24);
                p.Layer1 = Color.FromArgb(46, 46, 46);
                p.Layer1Hover = Color.FromArgb(58, 58, 58);
                p.Layer2 = Color.FromArgb(42, 42, 42);
                p.ControlFill = Color.FromArgb(58, 58, 58);
                p.ControlHover = Color.FromArgb(74, 74, 74);
                p.ControlPressed = Color.FromArgb(48, 48, 48);
                p.InputFill = Color.FromArgb(34, 34, 34);
                p.Stroke = Color.FromArgb(120, 120, 120);
                p.StrokeStrong = Color.FromArgb(150, 150, 150);
                p.TextPrimary = Color.FromArgb(255, 255, 255);
                p.TextSecondary = Color.FromArgb(190, 190, 190);
                p.TextDisabled = Color.FromArgb(148, 148, 148);
                p.Selection = Color.FromArgb(72, 72, 72);
                p.ToggleOff = Color.FromArgb(160, 160, 160);
                p.Danger = Color.FromArgb(255, 153, 164);
                p.AccentHover = ColorMath.Blend(accent, accentStateTarget, 0.10);
                p.AccentPressed = ColorMath.Blend(accent, accentStateTarget, 0.20);
                p.AccentText = ColorMath.EnsureContrast(accent, p.Layer1, 4.5, Color.White);
            }

            return p;
        }
    }

    public static class ColorMath {
        internal static Color Blend(Color from, Color to, double amount)
        {
            amount = Math.Max(0, Math.Min(1, amount));
            return Color.FromArgb(
                (int)Math.Round(from.R + (to.R - from.R) * amount),
                (int)Math.Round(from.G + (to.G - from.G) * amount),
                (int)Math.Round(from.B + (to.B - from.B) * amount));
        }

        internal static double Luminance(Color c)
        {
            return 0.2126 * Channel(c.R) + 0.7152 * Channel(c.G) + 0.0722 * Channel(c.B);
        }

        private static double Channel(int value)
        {
            double v = value / 255.0;
            return v <= 0.03928 ? v / 12.92 : Math.Pow((v + 0.055) / 1.055, 2.4);
        }

        internal static double Contrast(Color a, Color b)
        {
            double la = Luminance(a), lb = Luminance(b);
            return (Math.Max(la, lb) + 0.05) / (Math.Min(la, lb) + 0.05);
        }

        /// <summary>
        /// Moves a color towards <paramref name="direction"/> until it reaches the requested contrast against the background.
        /// </summary>
        internal static Color EnsureContrast(Color c, Color background, double ratio, Color direction)
        {
            Color result = c;
            for (int i = 1; i <= 20 && Contrast(result, background) < ratio; i++)
            {
                result = Blend(c, direction, i * 0.05);
            }
            return result;
        }
    }
}
