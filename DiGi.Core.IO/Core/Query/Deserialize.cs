using DiGi.Core.Interfaces;
using DiGi.Core.IO.Core.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        /// <summary>
        /// Deserializes a USerializableObject from the specified archive.
        /// </summary>
        /// <typeparam name="USerializableObject">The type of object to deserialize.</typeparam>
        /// <param name="archive">The archive to deserialize from.</param>
        /// <returns>The deserialized USerializableObject, or null if deserialization fails.</returns>
        public static USerializableObject? Deserialize<USerializableObject>(this IArchive archive) where USerializableObject : ISerializableObject
        {
            if (archive?.Bytes is not byte[] bytes)
            {
                return default;
            }

            using MemoryStream archiveStream = new(bytes);
            using ZipArchive zipArchive = new(archiveStream, ZipArchiveMode.Read);

            ZipArchiveEntry? zipArchiveEntry = zipArchive.GetEntry("Value");
            if (zipArchiveEntry == null)
            {
                return default;
            }

            using Stream stream = zipArchiveEntry.Open();
            using StreamReader streamReader = new(stream, Encoding.UTF8);

            string json = streamReader.ReadToEnd();

            List<USerializableObject>? serializableObjects = Convert.ToDiGi<USerializableObject>(json);
            if (serializableObjects is null || serializableObjects.Count == 0)
            {
                return default;
            }

            return serializableObjects[0];
        }
    }
}