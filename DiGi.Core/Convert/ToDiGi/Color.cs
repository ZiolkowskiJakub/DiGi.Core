using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a <see cref="System.Drawing.Color"/> to a DiGi-compatible <see cref="Color"/>.
        /// </summary>
        public static Color ToDiGi(this System.Drawing.Color color)
        {
            return new Color(color);
        }
    }
}