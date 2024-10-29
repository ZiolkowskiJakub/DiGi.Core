using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Classes
{
    /// <summary>
    /// Class to store one delimited file row
    /// </summary>
    public class DelimitedDataRow : List<string>
    {
        public DelimitedDataRow()
        {
        }

        public DelimitedDataRow(IEnumerable<string> values)
        {
            AddRange(values);
        }

        public string LineText { get; set; }

        public bool TryGetValue<T>(int index, out T value)
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