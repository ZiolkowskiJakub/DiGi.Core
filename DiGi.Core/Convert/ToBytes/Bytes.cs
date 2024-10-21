using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Convert
    {
        public static byte[] ToBytes(this ISerializableObject serializableObject)
        {
            string json = ToString(serializableObject);
            if(json == null)
            {
                return null;
            }

            return System.Text.Encoding.UTF8.GetBytes(json);
        }

        public static byte[] ToBytes<T>(this IEnumerable<T> serializableObjects) where T : ISerializableObject
        {
            string json = ToString(serializableObjects);
            if (json == null)
            {
                return null;
            }

            return System.Text.Encoding.UTF8.GetBytes(json);
        }
    }
}
