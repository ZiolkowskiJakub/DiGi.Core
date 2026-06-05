using DiGi.Core.Classes;
using System.Web;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        /// <summary>
        /// Encodes the specified string for use as a reference.
        /// </summary>
        /// <param name="text">The string to encode.</param>
        /// <returns>The encoded string, or null if the input is null.</returns>
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
        /// <param name="uniqueReference">The unique reference to encode.</param>
        /// <returns>The encoded string representation of the unique reference, or null if the input is null.</returns>
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