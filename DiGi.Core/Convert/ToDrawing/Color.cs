using System.Drawing;
using System.Globalization;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a uint color value (ARGB) to a System.Drawing.Color.
        /// </summary>
        /// <param name="uint">The unsigned integer ARGB color value.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(uint @uint)
        {
            byte a = (byte)(@uint >> 24);
            byte b = (byte)(@uint >> 16);
            byte g = (byte)(@uint >> 8);
            byte r = (byte)(@uint >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Converts an int color value (RGB) to a System.Drawing.Color with optional alpha.
        /// </summary>
        /// <param name="int">The integer RGB color value.</param>
        /// <param name="alpha">The alpha channel value.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(int @int, byte alpha = 255)
        {
            byte b = (byte)(@int >> 16);
            byte g = (byte)(@int >> 8);
            byte r = (byte)(@int >> 0);
            return Color.FromArgb(alpha, r, g, b);
        }

        /// <summary>
        /// Converts a hex color string to a System.Drawing.Color.
        /// </summary>
        /// <param name="value">The hex color string.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(string? value)
        {
            if (value is null)
            {
                return Color.Empty;
            }

            string hex = value.Replace("#", string.Empty);
            NumberStyles numberStyles = NumberStyles.HexNumber;

            int r = int.Parse(hex.Substring(0, 2), numberStyles);
            int g = int.Parse(hex.Substring(2, 2), numberStyles);
            int b = int.Parse(hex.Substring(4, 2), numberStyles);
            int a = 255;

            if (hex.Length == 8)
            {
                a = int.Parse(hex.Substring(6, 2), numberStyles);
            }

            return Color.FromArgb(a, r, g, b);
        }

        /// <summary>
        /// Converts a DiGi.Core.Classes.Color to a System.Drawing.Color.
        /// </summary>
        /// <param name="color">The color to convert.</param>
        /// <returns>The converted System.Drawing.Color.</returns>
        public static Color ToDrawing(this Classes.Color? color)
        {
            if (color is null)
            {
                return Color.Empty;
            }

            return Color.FromArgb(color.Alpha, color.Red, color.Green, color.Blue);
        }
    }
}