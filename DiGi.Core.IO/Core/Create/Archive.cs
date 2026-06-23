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
        /// <typeparam name="TSerializableObject">The type of the serializable object contained within the archive.</typeparam>
        /// <param name="bytes">The byte array to create the archive from.</param>
        /// <returns>An <see cref="Classes.Archive{TSerializableObject}"/> instance if successful; otherwise, <c>null</c>.</returns>
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
        /// <typeparam name="TSerializableObject">The type of the serializable object to extract.</typeparam>
        /// <param name="bytes">The byte array to create the archive from.</param>
        /// <param name="serializableObject">When this method returns, contains the extracted serializable object, or null if extraction failed.</param>
        /// <returns>An <see cref="IArchive"/> instance if successful; otherwise, <c>null</c>.</returns>
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