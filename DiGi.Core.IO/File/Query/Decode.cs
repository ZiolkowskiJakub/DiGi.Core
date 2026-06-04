using DiGi.Core.Classes;
using System.Web;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        /// <summary>
        /// Decodes the specified string into a <see cref="UniqueReference"/>.
        /// </summary>
        public static UniqueReference? Decode(string? text)
        {
            if (text == null)
            {
                return null;
            }

            if (!DiGi.Core.Query.TryParse(HttpUtility.UrlDecode(text), out UniqueReference? uniqueReference))
            {
                return null;
            }

            return uniqueReference;
        }
    }
}