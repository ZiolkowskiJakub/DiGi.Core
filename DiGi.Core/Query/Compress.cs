﻿using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Source: https://stackoverflow.com/questions/7343465/compression-decompression-string-with-c-sharp
        /// </summary>
        /// <param name="string">String to be compressed</param>
        /// <returns>Compressed string</returns>
        public static string Compress(this string @string)
        {
            if (@string == null)
            {
                return null;
            }

            byte[] buffer = Encoding.UTF8.GetBytes(@string);
            var memoryStream = new MemoryStream();
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
            {
                gZipStream.Write(buffer, 0, buffer.Length);
            }

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return System.Convert.ToBase64String(gZipBuffer);
        }

        public static string Compress(this ISerializableObject serializableObject)
        {
            string @string = Convert.ToString(serializableObject);
            if (string.IsNullOrEmpty(@string))
            {
                return @string;
            }

            return Compress(@string);
        }

        public static string Compress<T>(this IEnumerable<T> serializableObject) where T : ISerializableObject
        {
            string json = Convert.ToString(serializableObject);
            if (string.IsNullOrEmpty(json))
            {
                return json;
            }

            return Compress(json);
        }
    }
}