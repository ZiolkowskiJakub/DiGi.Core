using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static byte[] ToSystem_Bytes(this ISerializableObject serializableObject)
        {
            string json = ToSystem_String(serializableObject);
            if(json == null)
            {
                return null;
            }

            return System.Text.Encoding.UTF8.GetBytes(json);
        }

        public static byte[] ToSystem_Bytes<T>(this IEnumerable<T> serializableObjects) where T : ISerializableObject
        {
            string json = ToSystem_String(serializableObjects);
            if (json == null)
            {
                return null;
            }

            return System.Text.Encoding.UTF8.GetBytes(json);
        }
    }
}
