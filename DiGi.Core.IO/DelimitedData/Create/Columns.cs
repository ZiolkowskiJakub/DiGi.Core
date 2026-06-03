using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a list of columns from string names.
        /// </summary>
        public static List<Column>? Columns(this IEnumerable<string>? names)
        {
            if (names == null)
            {
                return null;
            }

            List<Column> result = [];

            int count = names.Count();

            if (count == 0)
            {
                return result;
            }

            for (int i = 0; i < count; i++)
            {
                result.Add(new Column(i, names.ElementAt(i), typeof(string)));
            }

            return result;
        }
    }
}