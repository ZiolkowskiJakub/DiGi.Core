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
        /// <param name="jsonObject">The JSON object to initialize the instance from.</param>
        public IndexedBools(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class by copying another instance.
        /// </summary>
        /// <param name="indexedDoubles">The source <see cref="IndexedBools"/> instance to copy from.</param>
        public IndexedBools(IndexedBools indexedDoubles)
            : base(indexedDoubles)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class from a collection of boolean values.
        /// </summary>
        /// <param name="values">The collection of boolean values to use for initialization.</param>
        public IndexedBools(IEnumerable<bool> values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class from a collection of boolean values starting at a specified index.
        /// </summary>
        /// <param name="values">The collection of boolean values to use for initialization.</param>
        /// <param name="startIndex">The starting index for the provided values.</param>
        public IndexedBools(IEnumerable<bool> values, int startIndex)
            : base(values, startIndex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedBools"/> class with a range of indices set to the same value.
        /// </summary>
        /// <param name="startIndex">The starting index of the range.</param>
        /// <param name="count">The number of elements in the range.</param>
        /// <param name="value">The boolean value to assign to each element in the range.</param>
        public IndexedBools(int startIndex, int count, bool value)
            : base(startIndex, count, value)
        {
        }
    }
}