using DiGi.Core.IO.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static string Filter(params FileFilter[] fileFilters)
        {
            if(fileFilters == null)
            {
                return null;
            }

            List<string> values = new List<string>();
            foreach(FileFilter fileFilter in fileFilters)
            {
                string value = fileFilter?.ToString();
                if (string.IsNullOrWhiteSpace(value))
                {
                    continue;
                }

                values.Add(value);
            }

            return string.Join("|", values);
        }

    }
}


