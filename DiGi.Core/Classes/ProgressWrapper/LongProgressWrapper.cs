using System;

namespace DiGi.Core.Classes
{
    /// <summary>Wraps progress reporting for long values.</summary>
    public class LongProgressWrapper : ProgressWrapper<long>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LongProgressWrapper"/> class.
        /// </summary>
        public LongProgressWrapper(IProgress<long>? progress = null)
            : base(0, progress)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LongProgressWrapper"/> class with an initial value.
        /// </summary>
        public LongProgressWrapper(long initialValue, IProgress<long>? progress = null)
            : base(initialValue, progress)
        {
        }

        /// <summary>
        /// Increments the current progress value and reports the update.
        /// </summary>
        public long Increment(long value)
        {
            long result = Current + value;

            Report(result);

            return result;
        }
    }
}