using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>Splits serializable objects by their serialized byte array size.</summary>
    public class MemorySizeSplitter<TSerializableObject> : Splitter<TSerializableObject, long> where TSerializableObject : ISerializableObject
    {
        public MemorySizeSplitter(IEnumerable<TSerializableObject> serializableObjects)
            : base(serializableObjects)
        {
        }

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