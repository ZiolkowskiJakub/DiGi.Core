using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    public abstract class BackgroundTask : IBackgroundTask
    {
        protected readonly object lockObject = new ();

        protected Exception? exception = null;
        
        private bool isRunning = false;

        private bool isSucceeded = true;

        public event EventHandler? Started;

        public event EventHandler? Starting;
        
        public event EventHandler? Stopped;

        public event EventHandler? Stopping;
        
        public BackgroundTaskStatus BackgroundTaskStatus
        {
            get
            {
                if (IsRunning)
                {
                    return BackgroundTaskStatus.Running;
                }

                if(IsCompleted)
                {
                    if(exception is not null || !isSucceeded)
                    {
                        return BackgroundTaskStatus.Failed;
                    }

                    return BackgroundTaskStatus.Completed;
                }

                return BackgroundTaskStatus.Idle;
            }
        }

        public Exception? Exception => exception;
        public bool IsCompleted => Task?.IsCompleted ?? false;

        public bool IsRunning => isRunning;

        public bool IsSucceeded => isSucceeded;
        
        protected Task? Task { get; set; }

        public virtual void Start()
        {
            lock (lockObject)
            {
                if (isRunning)
                {
                    return;
                }

                OnStarting();

                exception = null;
                isRunning = true;
                isSucceeded = true;

                Task = Task.Run(async () =>
                {
                    try
                    {
                        OnStarted();
                        isSucceeded = await ExecuteAsync();
                    }
                    catch(Exception exception_Temp)
                    {
                        exception = exception_Temp;
                    }
                    finally
                    {
                        OnStopping();

                        lock (lockObject)
                        {
                            isRunning = false;
                        }
                        OnStopped();
                    }
                });
            }
        }

        protected abstract Task<bool> ExecuteAsync();

        protected virtual void OnStarted() => Started?.Invoke(this, EventArgs.Empty);

        protected virtual void OnStarting() => Starting?.Invoke(this, EventArgs.Empty);
        
        protected virtual void OnStopped() => Stopped?.Invoke(this, EventArgs.Empty);

        protected virtual void OnStopping() => Stopping?.Invoke(this, EventArgs.Empty);
    }
}