using DiGi.Core.Classes;
using System.Web;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        public static string Encode(string text)
        {
            if(text == null)
            {
                return null;
            }

            return HttpUtility.UrlEncode(text);
        }

        public static string Encode(this UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return Encode(uniqueReference.ToString());
        }

    }
}


