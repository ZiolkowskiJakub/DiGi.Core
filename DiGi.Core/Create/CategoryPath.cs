using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static CategoryPath CategoryPath(string text)
        {
            List<string> names = Query.QuotedStrings(text, Classes.CategoryPath.Separator);
            if(names == null)
            {
                return null;
            }

            return new CategoryPath(names);
        }
    }
}