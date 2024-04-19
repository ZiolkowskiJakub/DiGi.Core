using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static MemoryStream MemoryStream(this string text)
        {
            if (text == null)
            {
                return null;
            }

            byte[] bytes = Encoding.ASCII.GetBytes(text);
            return new MemoryStream(bytes);
        }

        public static MemoryStream MemoryStream(this IEnumerable<string> text)
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