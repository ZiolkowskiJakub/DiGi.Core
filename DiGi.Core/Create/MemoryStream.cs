using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a memory stream from the given string.</summary>
        /// <param name="text">The string to convert into a memory stream.</param>
        /// <returns>A <see cref="System.IO.MemoryStream"/> containing the text, or null if the input is null.</returns>
        public static MemoryStream? MemoryStream(this string? text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(text);
            return new MemoryStream(bytes);
        }

        /// <summary>Creates a memory stream from the given collection of strings.</summary>
        /// <param name="text">The collection of strings to convert into a memory stream.</param>
        /// <returns>A <see cref="System.IO.MemoryStream"/> containing the text, or null if the input is null.</returns>
        public static MemoryStream? MemoryStream(this IEnumerable<string>? text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(string.Join("\n", text));
            return new MemoryStream(bytes);
        }
    }
}