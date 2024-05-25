using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<int> Seeds(this int count, int seed = -1)
        {
            if(seed == -1)
            {
                return Enumerable.Repeat(-1, count).ToList();
            }

            List<int> result = new List<int>();
            result.Add(seed);
            for (int i = 1; i < count; i++)
            {
                result.Add(seed + i);
            }

            return result;
        }
    }

}
