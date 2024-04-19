using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Class to store one delimited file row
    /// </summary>
    public class DelimitedFileRow : List<string>
    {
        public DelimitedFileRow()
        {
        }

        public DelimitedFileRow(IEnumerable<string> values)
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