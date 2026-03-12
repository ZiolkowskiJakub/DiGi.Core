using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    public abstract class CancelableTask : ITask
    {
        private readonly object lockObject = new();

        private CancellationTokenSource? cancellationTokenSource;

        public event EventHandler? Started;

        public event EventHandler? Starting;

        public event EventHandler? Stopped;

        public event EventHandler? Stopping;

        public CancelableTaskStatus CancelableTaskStatus
        {
            get
            {
                if (IsRunning)
                {
                    return CancelableTaskStatus.Running;
                }

                if (IsCompleted)
                {
                    if (IsCanceled)
                    {
                        return CancelableTaskStatus.Canceled;
                    }

                    return CancelableTaskStatus.Completed;
                }

                return CancelableTaskStatus.Idle;
            }
        }

        public bool IsCanceled => Task?.IsCanceled ?? false;

        public bool IsCompleted => Task?.IsCompleted ?? false;
        
        public bool IsRunning => Task != null && !Task.IsCompleted;
        protected Task? Task { get; private set; }
        
        public void Start()
        {
            lock (lockObject)
            {
                if (IsRunning)
                {
                    return;
                }

                OnStarting();

                cancellationTokenSource = new CancellationTokenSource();
                CancellationToken token = cancellationTokenSource.Token;

                Task = Task.Run(async () =>
                {
                    try
                    {
                        OnStarted();
                        bool succeeded = await RunAsync(token);
                    }
                    catch (OperationCanceledException)
                    {
                        // Catch both TaskCanceledException and OperationCanceledException
                    }
                    catch(Exception exception)
                    {
                        throw exception;
                    }
                    finally
                    {
                        // Trigger OnStopped only if the task completed itself 
                        // without an external Stop/StopAsync call.
                        if (!token.IsCancellationRequested)
                        {
                            OnStopped();
                        }
                    }
                }, token);
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
                // GetAwaiter().GetResult() is preferred over .Wait() for exception propagation
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

        protected virtual void OnStarted() => Started?.Invoke(this, EventArgs.Empty);
        
        protected virtual void OnStarting() => Starting?.Invoke(this, EventArgs.Empty);
        
        protected virtual void OnStopped() => Stopped?.Invoke(this, EventArgs.Empty);
        
        protected virtual void OnStopping() => Stopping?.Invoke(this, EventArgs.Empty);

        protected abstract Task<bool> RunAsync(CancellationToken cancellationToken);

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
