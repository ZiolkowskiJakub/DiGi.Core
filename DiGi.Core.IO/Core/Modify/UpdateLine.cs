using System.Collections.Generic;

namespace DiGi.Core.IO
{
    public static partial class Modify
    {
        public static bool UpdateLine(string path, int index, string line)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || index < 0)
            {
                return false;
            }

            HashSet<int> indexes = UpdateLines(path, new Dictionary<int, string> { { index, line } });
            
            return indexes != null && indexes.Contains(index);
        }
    }

}


