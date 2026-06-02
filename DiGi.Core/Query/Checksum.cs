using System;
using System.IO;
using System.Security.Cryptography;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes the MD5 checksum of a string.
        /// </summary>
        /// <param name="value">The string to compute the checksum for.</param>
        /// <returns>A string representing the MD5 checksum, or null if the input is null.</returns>
        public static string? Checksum(this string? value)
        {
            if (value == null)
            {
                return null;
            }

            byte[]? bytes = null;

            using (MD5 mD5 = MD5.Create())
            {
                using MemoryStream memoryStream = new();

                StreamWriter streamWriter = new(memoryStream);

                streamWriter.Write(value);
                streamWriter.Flush();
                memoryStream.Position = 0;

                bytes = mD5.ComputeHash(memoryStream);
            }

            return BitConverter.ToString(bytes);
        }
    }
}