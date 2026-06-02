using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a CategoryPath object by parsing a string containing quoted names.
        /// </summary>
        /// <param name="text">The string containing the category path.</param>
        /// <returns>A CategoryPath object, or null if the string is invalid or empty.</returns>
        public static CategoryPath? CategoryPath(string text)
        {
            List<string>? names = Query.QuotedStrings(text, Classes.CategoryPath.Separator);
            if (names == null)
            {
                return null;
            }

            return new CategoryPath(names);
        }
    }
}