using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base class for background tasks that can be canceled during execution.
    /// </summary>
    public abstract class CancelableBackgroundTask : BackgroundTask, ICancelableBackgroundTask
    {
        /// <summary>
        /// Source for controlling cancellation of the background task.
        /// </summary>
        private CancellationTokenSource? cancellationTokenSource;

        /// <summary>
        /// Occurs when the task has been canceled.
        /// </summary>
        public event EventHandler? Canceled;

        /// <summary>
        /// Occurs when the task is being canceled.
        /// </summary>
        public event EventHandler? Cancelling;

        /// <summary>
        /// Gets the current status of the cancelable background task.
        /// </summary>
        public CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus
        {
            get
            {
                if (IsRunning)
                {
                    return CancelableBackgroundTaskStatus.Running;
                }

                if (IsCompleted)
                {
                    if (IsCanceled)
                    {
                        return CancelableBackgroundTaskStatus.Canceled;
                    }

                    if (Exception is not null || !IsSucceeded)
                    {
                        return CancelableBackgroundTaskStatus.Failed;
                    }

                    return CancelableBackgroundTaskStatus.Completed;
                }

                return CancelableBackgroundTaskStatus.Idle;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the task has been canceled.
        /// </summary>
        public bool IsCanceled => Task?.IsCanceled ?? false;

        /// <summary>
        /// Starts the background task execution synchronously.
        /// </summary>
        public override void Start()
        {
            lock (lockObject)
            {
                if (IsRunning)
                {
                    return;
                }

                cancellationTokenSource = new CancellationTokenSource();

                base.Start();
            }
        }

        /// <summary>
        /// Stops the background task synchronously by canceling and waiting for completion.
        /// </summary>
        public void Stop()
        {
            CancellationTokenSource? cancellationTokenSource_Temp;
            Task? task_Temp;

            lock (lockObject)
            {
                cancellationTokenSource_Temp = cancellationTokenSource;
                task_Temp = Task;
            }

            if (cancellationTokenSource_Temp == null || task_Temp == null)
            {
                return;
            }

            OnStopping();
            cancellationTokenSource_Temp.Cancel();

            try
            {
                task_Temp.GetAwaiter().GetResult();
                if (cancellationTokenSource_Temp.IsCancellationRequested)
                {
                    OnCanceled();
                }
            }
            catch (OperationCanceledException)
            {
                OnCanceled();
            }
            finally
            {
                Cleanup();
                OnStopped();
            }
        }

        /// <summary>
        /// Stops the background task asynchronously by canceling and waiting for completion.
        /// </summary>
        /// <returns>A task that represents the asynchronous stop operation.</returns>
        public async Task StopAsync()
        {
            CancellationTokenSource? cancellationTokenSource_Temp;
            Task? task_Temp;

            lock (lockObject)
            {
                cancellationTokenSource_Temp = cancellationTokenSource;
                task_Temp = Task;
            }

            if (cancellationTokenSource_Temp == null || task_Temp == null)
            {
                return;
            }

            OnCancelling();

            cancellationTokenSource_Temp.Cancel();

            try
            {
                await task_Temp;
                if (cancellationTokenSource_Temp.IsCancellationRequested)
                {
                    OnCanceled();
                }
            }
            catch (OperationCanceledException)
            {
                OnCanceled();
            }
            finally
            {
                Cleanup();
            }
        }

        /// <summary>
        /// Executes the background task with cancellation support.
        /// </summary>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected override async Task<bool> ExecuteAsync()
        {
            if (cancellationTokenSource == null)
            {
                return false;
            }

            try
            {
                return await ExecuteAsync(cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected when the task is canceled
            }
            catch (Exception exception_Temp)
            {
                exception = exception_Temp;
            }

            return false;
        }

        /// <summary>
        /// When overridden in a derived class, defines the work to be executed with a cancellation token.
        /// </summary>
        /// <param name="token">The cancellation token to observe.</param>
        /// <returns>True if the task succeeded; otherwise, false.</returns>
        protected abstract Task<bool> ExecuteAsync(CancellationToken token);

        /// <summary>
        /// Raises the Canceled event.
        /// </summary>
        protected virtual void OnCanceled() => Canceled?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the Cancelling event.
        /// </summary>
        protected virtual void OnCancelling() => Cancelling?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Cleans up the cancellation token source and resets task state.
        /// </summary>
        private void Cleanup()
        {
            lock (lockObject)
            {
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = null;
                Task = null;
            }
        }
    }
}