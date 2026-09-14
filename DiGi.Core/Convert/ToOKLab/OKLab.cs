using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a DiGi <see cref="Color"/> (sRGB) to the OKLab perceptual color space.
        /// </summary>
        /// <param name="color">The source color in sRGB.</param>
        /// <returns>The color in OKLab.</returns>
        public static OKLab ToOKLab(this Color color)
        {
            double linearRed = ToLinear(color.Red);
            double linearGreen = ToLinear(color.Green);
            double linearBlue = ToLinear(color.Blue);

            double lmsL = 0.4122214708 * linearRed + 0.5363325363 * linearGreen + 0.0514459929 * linearBlue;
            double lmsM = 0.2119034982 * linearRed + 0.6806995451 * linearGreen + 0.1073969566 * linearBlue;
            double lmsS = 0.0883024619 * linearRed + 0.2817188376 * linearGreen + 0.6299787005 * linearBlue;

            double l = System.Math.Pow(lmsL, 1.0 / 3.0);
            double m = System.Math.Pow(lmsM, 1.0 / 3.0);
            double s = System.Math.Pow(lmsS, 1.0 / 3.0);

            return new OKLab(
                0.2104542553 * l + 0.7936177850 * m - 0.0040720468 * s,
                1.9779984951 * l - 2.4285922050 * m + 0.4505937099 * s,
                0.0259040371 * l + 0.7827717662 * m - 0.8086757660 * s);

            double ToLinear(byte channel)
            {
                double value = channel / 255.0;

                return value <= 0.04045 ? value / 12.92 : System.Math.Pow((value + 0.055) / 1.055, 2.4);
            }
        }
    }
}
