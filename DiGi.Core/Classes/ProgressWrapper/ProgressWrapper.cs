using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.Classes
{
    /// <summary>Provides thread-safe progress reporting for values of type T.</summary>
    public class ProgressWrapper<T> : IObject
    {
        private readonly object lockObject = new();
        private readonly IProgress<T>? progress;
        private T current;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProgressWrapper{T}"/> class with an initial value.
        /// </summary>
        public ProgressWrapper(T initialValue, IProgress<T>? progress = null)
        {
            current = initialValue;
            this.progress = progress;
        }

        /// <summary>
        /// Gets the current progress value.
        /// </summary>
        public T Current
        {
            get
            {
                lock (lockObject)
                {
                    return current;
                }
            }
            private set
            {
                lock (lockObject)
                {
                    current = value;
                }
            }
        }

        /// <summary>
        /// Reports a new progress value.
        /// </summary>
        public void Report(T value)
        {
            Current = value;

            progress?.Report(value);
        }
    }
}