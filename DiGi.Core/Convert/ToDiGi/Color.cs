using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> to a DiGi-compatible <see cref="Color"/>.
        /// </summary>
        /// <param name="color">The source color to convert.</param>
        /// <returns>A DiGi-compatible <see cref="Color"/> object.</returns>
        public static Color ToDiGi(this System.Drawing.Color color)
        {
            return new Color(color);
        }

        /// <summary>
        /// Converts an OKLab color to a DiGi <see cref="Color"/> (sRGB), clamping the linear channels to the sRGB gamut before the gamma step.
        /// </summary>
        /// <param name="okLab">The source color in OKLab.</param>
        /// <returns>The color in sRGB with full opacity.</returns>
        public static Color ToDiGi(this OKLab okLab)
        {
            double l = okLab.L + 0.3963377774 * okLab.A + 0.2158037573 * okLab.B;
            double m = okLab.L - 0.1055613458 * okLab.A - 0.0638541728 * okLab.B;
            double s = okLab.L - 0.0894841775 * okLab.A - 1.2914855480 * okLab.B;

            double lmsL = l * l * l;
            double lmsM = m * m * m;
            double lmsS = s * s * s;

            double linearRed = 4.0767416621 * lmsL - 3.3077115913 * lmsM + 0.2309699292 * lmsS;
            double linearGreen = -1.2684380046 * lmsL + 2.6097574011 * lmsM - 0.3413193965 * lmsS;
            double linearBlue = -0.0041960863 * lmsL - 0.7034186147 * lmsM + 1.7076147010 * lmsS;

            return new Color(255, ToSrgb(linearRed), ToSrgb(linearGreen), ToSrgb(linearBlue));

            byte ToSrgb(double linear)
            {
                double value = System.Math.Max(0.0, System.Math.Min(1.0, linear));
                double srgb = value <= 0.0031308 ? value * 12.92 : 1.055 * System.Math.Pow(value, 1.0 / 2.4) - 0.055;

                return (byte)System.Math.Round(System.Math.Max(0.0, System.Math.Min(1.0, srgb)) * 255.0);
            }
        }
    }
}