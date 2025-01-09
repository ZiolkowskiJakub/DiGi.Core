using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Security.Cryptography;
using System.Text;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static Guid Guid<T>(this UniqueObjectValueCluster<T> uniqueObjectValueCluster,  Type type) where T: IUniqueObject
        {
            if(uniqueObjectValueCluster == null || type == null)
            {
                return System.Guid.Empty;
            }

            GuidReference guidReference = uniqueObjectValueCluster.GuidReference(type);
            if(guidReference == null)
            {
                return System.Guid.Empty;
            }

            return guidReference.Guid;
        }

        /// <summary>
        /// Creates a unique GUID that is consistent for the same string
        /// </summary>
        /// <param name="string"></param>
        /// <returns>Unique Guid</returns>
        public static Guid Guid(this string @string)
        {
            if (@string == null)
            {
                return System.Guid.Empty;
            }

            // Compute the hash of the input string
            using (SHA1 sHA1 = SHA1.Create())
            {
                byte[] bytes_Hash = sHA1.ComputeHash(Encoding.UTF8.GetBytes(@string));
                byte[] bytes_Guid = new byte[16];

                // Combine 20 bytes into 16 bytes
                for (int i = 0; i < 16; i++)
                {
                    bytes_Guid[i] = (byte)((bytes_Hash[i] & 0xF0) | (bytes_Hash[i + 4] >> 4));
                }

                // Set bits according to RFC 4122 for a valid GUID
                bytes_Guid[6] = (byte)((bytes_Guid[6] & 0x0F) | 0x50); // Version 5
                bytes_Guid[8] = (byte)((bytes_Guid[8] & 0x3F) | 0x80); // Variant

                return new Guid(bytes_Guid);
            }
        }
    }
}