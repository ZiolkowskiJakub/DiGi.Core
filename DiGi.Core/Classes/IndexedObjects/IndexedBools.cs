using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a collection of boolean values mapped to integer indices.
    /// </summary>
    public class IndexedBools : IndexedObjects<bool>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class.
        /// </summary>
        public IndexedBools()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class from a JSON object.
        /// </summary>
        public IndexedBools(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class by copying another instance.
        /// </summary>
        public IndexedBools(IndexedBools indexedDoubles)
            : base(indexedDoubles)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class from a collection of boolean values.
        /// </summary>
        public IndexedBools(IEnumerable<bool> values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class from a collection of boolean values starting at a specified index.
        /// </summary>
        public IndexedBools(IEnumerable<bool> values, int startIndex)
            : base(values, startIndex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class with a range of indices set to the same value.
        /// </summary>
        public IndexedBools(int startIndex, int count, bool value)
            : base(startIndex, count, value)
        {
        }
    }
}