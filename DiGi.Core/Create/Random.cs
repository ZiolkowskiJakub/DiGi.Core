using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a random number generator with an optional seed.</summary>
        /// <param name="seed">The seed value for the random number generator. Defaults to -1.</param>
        /// <returns>A new <see cref="Random"/> instance.</returns>
        public static Random Random(int seed = -1)
        {
            return seed == -1 ? new Random() : new Random(seed);
        }
    }
}