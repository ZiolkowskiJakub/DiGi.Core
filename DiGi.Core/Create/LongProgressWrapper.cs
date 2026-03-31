using DiGi.Core.Classes;
using System;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static LongProgressWrapper? LongProgressWrapper(this IProgress<long>? progress, long initialValue = 0)
        {
            if(progress is null)
            {
                return null;
            }

            return new LongProgressWrapper(initialValue, progress);
        }
    }
}