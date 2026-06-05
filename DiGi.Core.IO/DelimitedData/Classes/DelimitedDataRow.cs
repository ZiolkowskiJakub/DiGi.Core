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
        /// <param name="values">The collection of string values to initialize the row with.</param>
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
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="index">The zero-based index of the element to get.</param>
        /// <param name="value">When this method returns, contains the value at the specified index if the operation was successful; otherwise, the default value for the type of the element.</param>
        /// <returns>True if the element is successfully retrieved; otherwise, false.</returns>
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