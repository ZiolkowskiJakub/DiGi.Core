using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.Core.Interfaces;
using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static IArchive? Serialize(this ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            using MemoryStream memoryStream = new();

            // Initialize ZipArchive with the stream.
            // Mode.Create is used because we are building it from scratch.
            using (ZipArchive zipArchive = new(memoryStream, ZipArchiveMode.Create, true))
            {
                string? json = Convert.ToSystem_String(serializableObject);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    // Create entry and write data
                    ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("Value");

                    using Stream entryStream = zipArchiveEntry.Open();
                    using StreamWriter streamWriter = new(entryStream, Encoding.UTF8);
                    streamWriter.Write(json);
                }
            }

            Type genericType = typeof(Archive<>).MakeGenericType(serializableObject.GetType());

            return (IArchive?)Activator.CreateInstance(genericType, [memoryStream.ToArray()]);
        }
    }
}