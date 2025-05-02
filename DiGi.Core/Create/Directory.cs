using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static bool Directory(string directory)
        {
            if (string.IsNullOrWhiteSpace(directory))
            {
                return false;
            }

            List<string> directories = Query.Directories(directory);
            if(directories == null || directories.Count == 0)
            {
                return false;
            }

            directories.Reverse();

            foreach(string directory_Temp in directories)
            {
                if(System.IO.Directory.Exists(directory_Temp))
                {
                    continue;
                }

                System.IO.Directory.CreateDirectory(directory_Temp);
            }

            return true;

        }
    }
}
