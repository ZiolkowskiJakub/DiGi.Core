using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static ObjectPath ObjectPath(string text)
        {
            List<string> names = Query.QuotedStrings(text, Classes.ObjectPath.Separator);
            if(names == null)
            {
                return null;
            }

            return new ObjectPath(names);
        }
    }
}