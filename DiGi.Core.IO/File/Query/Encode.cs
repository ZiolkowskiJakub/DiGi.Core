using DiGi.Core.Classes;
using System.Web;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        /// <summary>
        /// Encodes the specified string for use as a reference.
        /// </summary>
        public static string? Encode(string? text)
        {
            if (text == null)
            {
                return null;
            }

            return HttpUtility.UrlEncode(text);
        }

        /// <summary>
        /// Encodes the specified <see cref="UniqueReference"/> into its string representation.
        /// </summary>
        public static string? Encode(this UniqueReference? uniqueReference)
        {
            if (uniqueReference is null)
            {
                return null;
            }

            return Encode(uniqueReference.ToString());
        }
    }
}