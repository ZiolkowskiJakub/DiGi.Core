using System.Drawing;
using System.Globalization;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static Color ToColor(uint @uint)
        {
            byte a = (byte)(@uint >> 24);
            byte b = (byte)(@uint >> 16);
            byte g = (byte)(@uint >> 8);
            byte r = (byte)(@uint >> 0);
            return Color.FromArgb(a, r, g, b);
        }

        public static Color ToColor(int @int, byte alpha = 255)
        {
            byte b = (byte)(@int >> 16);
            byte g = (byte)(@int >> 8);
            byte r = (byte)(@int >> 0);
            return Color.FromArgb(alpha, r, g, b);
        }

        public static Color ToColor(string value)
        {
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
    }
}
