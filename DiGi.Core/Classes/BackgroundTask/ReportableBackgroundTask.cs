using DiGi.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base class for background tasks that report progress during execution.
    /// </summary>
    /// <typeparam name="T">The type of progress data reported.</typeparam>
    public abstract class ReportableBackgroundTask<T> : CancelableBackgroundTask, IReportableBackgroundTask<T>
    {
        /// <summary>
        /// Occurs when the task reports progress.
        /// </summary>
        public event EventHandler<T>? ProgressChanged;

        /// <summary>
        /// Executes the background task with progress reporting support.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected override async Task<bool> ExecuteAsync(CancellationToken cancellationToken)
        {
            // We wrap the progress reporting into an IProgress object
            return await ExecuteAsync(new Progress<T>(OnProgressChanged), cancellationToken);
        }

        /// <summary>
        /// When overridden in a derived class, defines the work to be executed with progress reporting.
        /// </summary>
        /// <param name="progress">The progress reporter for reporting progress updates.</param>
        /// <param name="cancellationToken">The cancellation token to observe.</param>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected abstract Task<bool> ExecuteAsync(IProgress<T> progress, CancellationToken cancellationToken);

        /// <summary>
        /// Raises the ProgressChanged event with the given progress value.
        /// </summary>
        /// <param name="value">The progress value to report.</param>
        protected virtual void OnProgressChanged(T value)
        {
            ProgressChanged?.Invoke(this, value);
        }
    }
}