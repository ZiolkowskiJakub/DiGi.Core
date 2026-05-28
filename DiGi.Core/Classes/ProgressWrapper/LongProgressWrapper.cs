using System;

namespace DiGi.Core.Classes
{
    /// <summary>Wraps progress reporting for long values.</summary>
    public class LongProgressWrapper : ProgressWrapper<long>
    {
        public LongProgressWrapper(IProgress<long>? progress = null)
            : base(0, progress)
        {
        }

        public LongProgressWrapper(long initialValue, IProgress<long>? progress = null)
            : base(initialValue, progress)
        {
        }

        public long Increment(long value)
        {
            long result = Current + value;

            Report(result);

            return result;
        }
    }
}