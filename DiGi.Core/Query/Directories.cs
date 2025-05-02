using System.Collections.Generic;
using System.IO;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<string> Directories(string directory)
        {
            if(string.IsNullOrWhiteSpace(directory))
            {
                return null;
            }

            List<string> result = new List<string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            result.Add(directoryInfo.ToString());

            while (directoryInfo != null)
            {
                directoryInfo = directoryInfo.Parent;
                if (directoryInfo != null)
                {
                    result.Add(directoryInfo.ToString());
                }
            }

            return result;
        }

        public static List<string> Directories(DirectoryInfo directoryInfo)
        {
            if(directoryInfo == null)
            {
                return null;
            }

            return Directories(directoryInfo.FullName);
        }
    }

}
