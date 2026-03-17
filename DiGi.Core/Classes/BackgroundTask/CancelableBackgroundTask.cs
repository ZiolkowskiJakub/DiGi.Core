using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    public abstract class CancelableBackgroundTask : BackgroundTask, ICancelableBackgroundTask
    {
        private CancellationTokenSource? cancellationTokenSource;

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

        public bool IsCanceled => Task?.IsCanceled ?? false;

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
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                Cleanup();
                OnStopped();
            }
        }

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

            OnStopping();

            cancellationTokenSource_Temp.Cancel();

            try
            {
                await task_Temp;
            }
            catch (OperationCanceledException)
            {
            }
            finally
            {
                Cleanup();
                OnStopped();
            }
        }

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

        protected abstract Task<bool> ExecuteAsync(CancellationToken token);

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