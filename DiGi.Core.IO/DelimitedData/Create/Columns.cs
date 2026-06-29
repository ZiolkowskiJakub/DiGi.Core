using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of columns from string names.
        /// </summary>
        /// <param name="names">The collection of column names to convert.</param>
        /// <returns>A list of <see cref="Column"/> objects, or null if the input is null.</returns>
        public static List<Column>? Columns(this IEnumerable<string>? names)
        {
            if (names == null)
            {
                return null;
            }

            List<Column> result = [];

            List<string> names_List = [.. names];

            int count = names_List.Count;

            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < count; i++)
            {
                result.Add(new Column(i, names_List[i], typeof(string)));
            }

            return result;
        }
    }
}