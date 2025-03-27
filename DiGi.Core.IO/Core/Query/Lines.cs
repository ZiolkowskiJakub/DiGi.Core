using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static List<string> Lines(string path, int count)
        {
            if(string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || count < 0)
            {
                return null;
            }

            List<string> result = new List<string>();
            if(count == 0)
            {
                return result;
            }

            int count_Temp = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                while(count_Temp < count && !reader.EndOfStream)
                {
                    result.Add(reader.ReadLine());
                    count_Temp++;
                }
            }

            return result;
        }

    }
}


