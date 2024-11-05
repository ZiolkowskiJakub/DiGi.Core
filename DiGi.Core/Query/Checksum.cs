using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string Checksum(this string value)
        {
            if (value == null)
            {
                return null;
            }

            byte[] bytes = null;

            using (MD5 mD5 = MD5.Create())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    StreamWriter streamWriter = new StreamWriter(memoryStream);

                    streamWriter.Write(value);
                    streamWriter.Flush();
                    memoryStream.Position = 0;

                    bytes = mD5.ComputeHash(memoryStream);
                }
            }

            return BitConverter.ToString(bytes);
        }
    }

}
