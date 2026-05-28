using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a random number generator with an optional seed.</summary>
        public static Random Random(int seed = -1)
        {
            return seed == -1 ? new Random() : new Random(seed);
        }
    }
}