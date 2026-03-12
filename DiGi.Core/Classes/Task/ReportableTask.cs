using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    public abstract class ReportableTask<T> : CancelableTask
    {
        public event EventHandler<T>? ProgressChanged;

        protected override async Task<bool> RunAsync(CancellationToken token)
        {
            // We wrap the progress reporting into an IProgress object
            return await RunAsync(new Progress<T>(OnProgressChanged), token);
        }

        protected abstract Task<bool> RunAsync(IProgress<T> progress, CancellationToken token);

        protected virtual void OnProgressChanged(T value)
        {
            ProgressChanged?.Invoke(this, value);
        }
    }
}