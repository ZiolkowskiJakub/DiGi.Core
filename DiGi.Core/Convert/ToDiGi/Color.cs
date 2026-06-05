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
    }
}