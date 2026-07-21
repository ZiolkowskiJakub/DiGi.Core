using DiGi.Core.Classes;
using System.Web;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        /// <summary>
        /// Decodes the specified string into a <see cref="UniqueReference"/>.
        /// </summary>
        /// <param name="text">The string to decode.</param>
        /// <returns>The decoded <see cref="UniqueReference"/>, or <c>null</c> if the decoding process fails.</returns>
        public static UniqueReference? Decode(string? text)
        {
            if (text == null)
            {
                return null;
            }

            if (!Core.Query.TryParse(HttpUtility.UrlDecode(text), out UniqueReference? uniqueReference))
            {
                return null;
            }

            return uniqueReference;
        }
    }
}