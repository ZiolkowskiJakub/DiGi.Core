using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.Core.Interfaces;
using System;

namespace DiGi.Core.IO
{
    public static partial class Create
    {
        /// <summary>
        /// Creates an archive from the specified byte array.
        /// </summary>
        public static Archive<TSerializableObject>? Archive<TSerializableObject>(this byte[] bytes) where TSerializableObject : ISerializableObject
        {
            if (bytes is null || bytes.Length == 0)
            {
                return null;
            }

            return new Archive<TSerializableObject>(bytes);
        }

        /// <summary>
        /// Creates an archive from the specified byte array and extracts the associated serializable object.
        /// </summary>
        public static IArchive? Archive<TSerializableObject>(this byte[] bytes, out TSerializableObject? serializableObject) where TSerializableObject : ISerializableObject
        {
            serializableObject = default;

            if (bytes is null || bytes.Length == 0)
            {
                return null;
            }

            Archive<TSerializableObject> archive = new(bytes);

            serializableObject = archive.Deserialize<TSerializableObject>();
            if (serializableObject is null)
            {
                return null;
            }

            Type genericType = typeof(Archive<>).MakeGenericType(serializableObject.GetType());

            return (IArchive?)Activator.CreateInstance(genericType, [bytes]);
        }
    }
}