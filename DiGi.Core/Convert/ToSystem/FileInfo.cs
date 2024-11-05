using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static FileInfo ToFileInfo(this ISerializableObject serializableObject, Classes.Path? path)
        {
            if(path == null || !path.HasValue || path.Value == null)
            {
                return null;
            }

            if(!path.Value.IsValid())
            {
                return null;
            }
            Classes.Path? directoryPath = path.Value.DirectoryPath;
            if ((directoryPath == null || !directoryPath.HasValue || directoryPath.Value == null))
            {
                return null;
            }

            if(!directoryPath.Value.DirectoryExists)
            {
                return null;
            }

            string value = ToString(serializableObject);
            if(value == null)
            {
                value = string.Empty;
            }

            File.WriteAllText(path.Value, value);
            return new FileInfo(path.Value);
        }

        public static FileInfo ToFileInfo<T>(this IEnumerable<T> serializableObjects, Classes.Path? path) where T : ISerializableObject
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

            string value = ToString(serializableObjects);
            if (value == null)
            {
                value = string.Empty;
            }

            File.WriteAllText(path.Value, value);
            return new FileInfo(path.Value);
        }
    }
}
