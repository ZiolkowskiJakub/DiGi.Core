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

        public ProgressWrapper(T initialValue, IProgress<T>? progress = null)
        {
            current = initialValue;
            this.progress = progress;
        }

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

        public void Report(T value)
        {
            Current = value;

            progress?.Report(value);
        }
    }
}