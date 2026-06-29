using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a hierarchical structure of Category objects from an enumerable sequence of names.
        /// </summary>
        /// <param name="names">The sequence of names representing the category hierarchy.</param>
        /// <returns>The root Category object, or null if the input is empty.</returns>
        public static Category? Category(this IEnumerable<string>? names)
        {
            if (names == null || !names.Any())
            {
                return null;
            }

            List<string> names_Temp = [.. names];

            Category result = new(names_Temp[0]);
            names_Temp.RemoveAt(0);

            Category category = result;
            while (names_Temp.Count > 0)
            {
                Category category_Temp = new(names_Temp[0]);
                category.Add(category_Temp);

                category = category_Temp;

                names_Temp.RemoveAt(0);
            }

            return result;
        }
    }
}