using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    /// <summary>
    /// Class to store one delimited file row
    /// </summary>
    public class DelimitedDataRow : List<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataRow"/> class.
        /// </summary>
        public DelimitedDataRow()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelimitedDataRow"/> class.
        /// </summary>
        public DelimitedDataRow(IEnumerable<string>? values)
        {
            if (values != null)
            {
                AddRange(values);
            }
        }

        /// <summary>
        /// Tries to get the value at the specified index as a specific type.
        /// </summary>
        public bool TryGetValue<T>(int index, out T? value)
        {
            value = default;
            if (index < 0 || index >= Count)
            {
                return false;
            }

            return this[index].TryConvert(out value);
        }
    }
}