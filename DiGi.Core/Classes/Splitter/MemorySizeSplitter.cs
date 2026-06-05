using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>Splits serializable objects by their serialized byte array size.</summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
    public class MemorySizeSplitter<TSerializableObject> : Splitter<TSerializableObject, long> where TSerializableObject : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemorySizeSplitter{TSerializableObject}"/> class.
        /// </summary>
        /// <param name="serializableObjects">The collection of serializable objects to be split.</param>
        public MemorySizeSplitter(IEnumerable<TSerializableObject> serializableObjects)
            : base(serializableObjects)
        {
        }

        /// <summary>
        /// Gets the memory size value for the specified serializable object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to get the memory size value for.</param>
        /// <returns>The memory size value of the specified serializable object.</returns>
        public override long GetValue(TSerializableObject? serializableObject)
        {
            if (serializableObject is null)
            {
                return 0;
            }

            byte[]? bytes = serializableObject.ToSystem_Bytes();
            if (bytes is null)
            {
                return 0;
            }

            return bytes.Length;
        }
    }
}