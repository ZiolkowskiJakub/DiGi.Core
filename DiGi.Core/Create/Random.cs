using System;


namespace DiGi.Core
{
    public static partial class Create
    {
        public static Random Random(int seed = -1)
        {
            return seed == -1 ? new Random() : new Random(seed);
        }
    }
}
