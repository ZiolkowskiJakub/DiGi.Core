using DiGi.Core.Classes;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a wrapper for a long-based progress reporter.</summary>
        /// <param name="progress">The progress reporter to wrap.</param>
        /// <param name="initialValue">The initial value for the progress reporter.</param>
        /// <returns>A <see cref="LongProgressWrapper"/> instance, or null if the provided progress is null.</returns>
        public static LongProgressWrapper? LongProgressWrapper(this IProgress<long>? progress, long initialValue = 0)
        {
            if (progress is null)
            {
                return null;
            }

            return new LongProgressWrapper(initialValue, progress);
        }
    }
}