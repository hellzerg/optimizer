using System;
using System.Drawing;
using System.Text;

namespace Optimizer
{
    public static class ColorHelper
    {
        // r,g,b values are from 0 to 1
        // h = [0,360], s = [0,1], v = [0,1]
        //              if s == 0, then h = -1 (undefined)
        /// <summary>
        /// Generates the Hue, Saturation, and Value for a given color
        /// </summary>
        /// <param name="color">The Color to generate the values for</param>
        /// <param name="hue">Out value for Hue</param>
        /// <param name="saturation">Out value for Saturation</param>
        /// <param name="value">Out value for Value</param>
        public static void HSVFromRGB(Color color, out double hue, out double saturation, out double value)
        {
            double min, max, delta, r, g, b;
            r = (double)color.R / 255d;
            g = (double)color.G / 255d;
            b = (double)color.B / 255d;

            min = Math.Min(r, Math.Min(g, b));
            max = Math.Max(r, Math.Max(g, b));
            value = max;                               // v
            delta = max - min;
            if (max != 0)
                saturation = delta / max;               // s
            else
            {
                // r = g = b = 0                // s = 0, v is undefined
                saturation = 0;
                hue = -1;
                return;
            }
            if (r == max)
                hue = (g - b) / delta;         // between yellow & magenta
            else if (g == max)
                hue = 2 + (b - r) / delta;     // between cyan & yellow
            else
                hue = 4 + (r - g) / delta;     // between magenta & cyan
            hue *= 60;                               // degrees
            if (hue < 0)
                hue += 360;
        }


        /// <summary>
        /// Generates a Color from a Hue, Saturation, and Value combination
        /// </summary>
        /// <param name="hue">Hue to use for the Color. (Max 360)</param>
        /// <param name="saturation">Saturation to use for the Color. (Max 1.0)</param>
        /// <param name="value">Value to use for the Color. (Max 1.0)</param>
        /// <returns>Generated Color</returns>
        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            try
            {
                int i;
                double f, p, q, t, r, g, b;

                if (saturation == 0)
                {
                    // achromatic (grey)
                    r = g = b = value;
                    return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
                }
                hue /= 60;                        // sector 0 to 5
                i = (int)Math.Floor(hue);
                f = hue - i;                      // factorial part of h
                p = value * (1 - saturation);
                q = value * (1 - saturation * f);
                t = value * (1 - saturation * (1 - f));
                switch (i)
                {
                    case 0:
                        r = value;
                        g = t;
                        b = p;
                        break;
                    case 1:
                        r = q;
                        g = value;
                        b = p;
                        break;
                    case 2:
                        r = p;
                        g = value;
                        b = t;
                        break;
                    case 3:
                        r = p;
                        g = q;
                        b = value;
                        break;
                    case 4:
                        r = t;
                        g = p;
                        b = value;
                        break;
                    default:                // case 5:
                        r = value;
                        g = p;
                        b = q;
                        break;
                }
                return Color.FromArgb((int)(255 * r), (int)(255 * g), (int)(255 * b));
            }
            catch
            {

            }
            return Color.Empty;
        }

        /// <summary>
        /// Creates color with corrected brightness.
        /// </summary>
        /// <param name="color">Color to correct.</param>
        /// <param name="correctionFactor">The brightness correction factor. Must be between -1 and 1. 
        /// Negative values produce darker colors.</param>
        /// <returns>
        /// Corrected <see cref="Color"/> structure.
        /// </returns>
        public static Color ChangeColorBrightness(Color color, double darkenAmount)
        {
            HslColor hslColor = new HslColor(color);
            hslColor.L *= darkenAmount; // 0 to 1
            return hslColor;
        }
    }

    [Serializable]
    public struct HslColor
    {
        #region Constants

        public static readonly HslColor Empty;

        #endregion

        #region Fields

        private double hue;
        private double saturation;
        private double luminance;
        private int alpha;
        private bool isEmpty;

        #endregion

        #region Static Constructors

        static HslColor()
        {
            Empty = new HslColor
            {
                IsEmpty = true
            };
        }

        #endregion

        #region Public Constructors

        public HslColor(double h, double s, double l)
            : this(255, h, s, l)
        { }

        public HslColor(int a, double h, double s, double l)
        {
            this.alpha = a;
            this.hue = Math.Min(359, h);
            this.saturation = Math.Min(1, s);
            this.luminance = Math.Min(1, l);
            isEmpty = false;
        }

        public HslColor(Color color)
        {
            this.alpha = color.A;
            this.hue = color.GetHue();
            this.saturation = color.GetSaturation();
            this.luminance = color.GetBrightness();
            isEmpty = false;
        }

        #endregion

        #region Operators

        public static bool operator ==(HslColor left, HslColor right)
        {
            return (((left.A == right.A) && (left.H == right.H)) && ((left.S == right.S) && (left.L == right.L)));
        }

        public static bool operator !=(HslColor left, HslColor right)
        {
            return !(left == right);
        }

        public static implicit operator HslColor(Color color)
        {
            return new HslColor(color);
        }

        public static implicit operator Color(HslColor color)
        {
            return color.ToRgbColor();
        }

        #endregion

        #region Overridden Methods

        public override bool Equals(object obj)
        {
            if (obj is HslColor)
            {
                HslColor color = (HslColor)obj;
                if (((this.A == color.A) && (this.H == color.H)) && ((this.S == color.S) && (this.L == color.L)))
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (((this.alpha.GetHashCode() ^ this.hue.GetHashCode()) ^ this.saturation.GetHashCode()) ^ this.luminance.GetHashCode());
        }

        public override string ToString()
        {
            StringBuilder builder;

            builder = new StringBuilder();
            builder.Append(this.GetType().Name);
            builder.Append(" [");
            builder.Append("H=");
            builder.Append(this.H);
            builder.Append(", S=");
            builder.Append(this.S);
            builder.Append(", L=");
            builder.Append(this.L);
            builder.Append("]");

            return builder.ToString();
        }

        #endregion

        #region Public Members

        public double H
        {
            get { return this.hue; }
            set
            {
                this.hue = value;
                this.hue = (this.hue > 359.0) ? 0 : ((this.hue < 0.0) ? 359 : this.hue);
            }
        }

        public double S
        {
            get { return this.saturation; }
            set { this.saturation = Math.Min(1, Math.Max(0, value)); }
        }

        public double L
        {
            get { return this.luminance; }
            set { this.luminance = Math.Min(1, Math.Max(0, value)); }
        }

        public int A
        {
            get { return this.alpha; }
            set { this.alpha = Math.Min(0, Math.Max(255, value)); }
        }

        public bool IsEmpty
        {
            get { return isEmpty; }
            internal set { isEmpty = value; }
        }

        public Color ToRgbColor()
        {
            return this.ToRgbColor(this.A);
        }

        public Color ToRgbColor(int alpha)
        {
            double q;
            if (this.L < 0.5)
            {
                q = this.L * (1 + this.S);
            }
            else
            {
                q = this.L + this.S - (this.L * this.S);
            }
            double p = 2 * this.L - q;
            double hk = this.H / 360;

            // r,g,b colors
            double[] tc = new[]
                    {
                      hk + (1d / 3d), hk, hk - (1d / 3d)
                    };
            double[] colors = new[]
                        {
                          0.0, 0.0, 0.0
                        };

            for (int color = 0; color < colors.Length; color++)
            {
                if (tc[color] < 0)
                {
                    tc[color] += 1;
                }
                if (tc[color] > 1)
                {
                    tc[color] -= 1;
                }

                if (tc[color] < (1d / 6d))
                {
                    colors[color] = p + ((q - p) * 6 * tc[color]);
                }
                else if (tc[color] >= (1d / 6d) && tc[color] < (1d / 2d))
                {
                    colors[color] = q;
                }
                else if (tc[color] >= (1d / 2d) && tc[color] < (2d / 3d))
                {
                    colors[color] = p + ((q - p) * 6 * (2d / 3d - tc[color]));
                }
                else
                {
                    colors[color] = p;
                }

                colors[color] *= 255;
            }

            return Color.FromArgb(alpha, (int)colors[0], (int)colors[1], (int)colors[2]);
        }

        #endregion
    }
}
