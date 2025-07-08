using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static int ProcessorCount(double fraction = 1.0)
        {
            int result = System.Convert.ToInt32(Environment.ProcessorCount * fraction);
            if (result <= 0)
            {
                result = 1;
            }

            return result;
        }
    }

}

