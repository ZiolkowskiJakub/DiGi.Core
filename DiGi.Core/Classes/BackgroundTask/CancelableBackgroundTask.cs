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

        protected override async Task ExecuteAsync()
        {
            if (cancellationTokenSource == null) return;

            try
            {
                await RunAsync(cancellationTokenSource.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected when the task is canceled
            }
        }

        protected abstract Task<bool> RunAsync(CancellationToken token);
        
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