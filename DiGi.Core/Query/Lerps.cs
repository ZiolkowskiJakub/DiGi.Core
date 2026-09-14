using System.Collections.Generic;
using System.Drawing;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates list of colors being linearly interpolated between color_1 and color_2, inclusive of both end points.
        /// <para>Element i of the list is Lerp(color_1, color_2, i / (count - 1)), so the first element is color_1 and the last element is color_2. A single-element list (count = 1) returns color_1.</para>
        /// </summary>
        /// <param name="color_1">Start Color</param>
        /// <param name="color_2">End Color</param>
        /// <param name="count">Number of colors</param>
        /// <returns>Lerped Colors</returns>
        public static List<Color>? Lerps(this Color color_1, Color color_2, int count)
        {
            if (count < 1)
            {
                return null;
            }

            List<Color> result = [];

            for (int i = 0; i < count; i++)
            {
                double value = count == 1 ? 0 : (double)i / (count - 1);
                result.Add(Lerp(color_1, color_2, value));
            }

            return result;
        }
    }
}
