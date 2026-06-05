using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core
{
    public static partial class Convert
    {
        /// <summary>
        /// Serializes a serializable object to a file and returns the FileInfo.
        /// </summary>
        /// <param name="serializableObject">The serializable object to serialize.</param>
        /// <param name="path">The destination path for the serialized file.</param>
        /// <returns>A <see cref="FileInfo"/> object representing the created file, or null if the operation failed.</returns>
        public static FileInfo? ToSystem_FileInfo(this ISerializableObject? serializableObject, Classes.Path? path)
        {
            if (path == null || !path.HasValue || path.Value == null)
            {
                return null;
            }

            if (!path.Value.IsValid())
            {
                return null;
            }
            Classes.Path? directoryPath = path.Value.DirectoryPath;
            if ((directoryPath == null || !directoryPath.HasValue || directoryPath.Value == null))
            {
                return null;
            }

            if (!directoryPath.Value.DirectoryExists)
            {
                return null;
            }

            string? value = ToSystem_String(serializableObject);
            value ??= string.Empty;

            File.WriteAllText(path.Value, value);
            return new FileInfo(path.Value);
        }

        /// <summary>
        /// Serializes a collection of serializable objects to a file and returns the FileInfo.
        /// </summary>
        /// <typeparam name="T">The type of elements in the collection.</typeparam>
        /// <param name="serializableObjects">The collection of serializable objects to serialize.</param>
        /// <param name="path">The destination path for the serialized file.</param>
        /// <returns>A <see cref="FileInfo"/> object representing the created file, or null if the operation failed.</returns>
        public static FileInfo? ToSystem_FileInfo<T>(this IEnumerable<T>? serializableObjects, Classes.Path? path) where T : ISerializableObject
        {
            if (path == null || !path.HasValue || path.Value == null)
            {
                return null;
            }

            if (!path.Value.IsValid())
            {
                return null;
            }
            Classes.Path? directoryPath = path.Value.DirectoryPath;
            if ((directoryPath == null || !directoryPath.HasValue || directoryPath.Value == null))
            {
                return null;
            }

            if (!directoryPath.Value.DirectoryExists)
            {
                return null;
            }

            string? value = ToSystem_String(serializableObjects);
            value ??= string.Empty;

            File.WriteAllText(path.Value, value);
            return new FileInfo(path.Value);
        }
    }
}