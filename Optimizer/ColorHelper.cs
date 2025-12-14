using System;
using System.Drawing;

namespace Optimizer
{
    public static class ColorHelper
    {
        public static Color ChangeColorBrightness(Color color, double darkenAmount)
        {
            HslColor hslColor = new HslColor(color);
            hslColor.L *= darkenAmount;
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
            : this(255, h, s, l) { }

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

        public static implicit operator HslColor(Color color)
        {
            return new HslColor(color);
        }

        public static implicit operator Color(HslColor color)
        {
            return color.ToRgbColor();
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
