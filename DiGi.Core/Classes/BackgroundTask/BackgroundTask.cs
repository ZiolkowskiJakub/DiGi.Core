using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Threading.Tasks;

namespace DiGi.Core.Classes
{
    public abstract class BackgroundTask : IBackgroundTask
    {
        protected readonly object lockObject = new ();

        public event EventHandler? Started;

        public event EventHandler? Starting;
        
        public event EventHandler? Stopped;

        public event EventHandler? Stopping;
        
        public BackgroundTaskStatus BackgroundTaskStatus
        {
            get
            {
                if (IsRunning) return BackgroundTaskStatus.Running;
                if (IsCompleted) return BackgroundTaskStatus.Completed;
                return BackgroundTaskStatus.Idle;
            }
        }

        public bool IsCompleted => Task?.IsCompleted ?? false;
        
        public bool IsRunning => Task != null && !Task.IsCompleted;

        protected Task? Task { get; set; }

        public virtual void Start()
        {
            lock (lockObject)
            {
                if (IsRunning) return;

                OnStarting();

                Task = Task.Run(async () =>
                {
                    try
                    {
                        OnStarted();
                        await ExecuteAsync();
                        OnStopping();
                    }
                    catch (Exception ex)
                    {
                        // In engineering plugins (Revit/Rhino), logging is crucial here
                        throw;
                    }
                    finally
                    {
                        OnStopped();
                    }
                });
            }
        }

        protected abstract Task ExecuteAsync();

        protected virtual void OnStarted() => Started?.Invoke(this, EventArgs.Empty);

        protected virtual void OnStarting() => Starting?.Invoke(this, EventArgs.Empty);
        
        protected virtual void OnStopped() => Stopped?.Invoke(this, EventArgs.Empty);

        protected virtual void OnStopping() => Stopping?.Invoke(this, EventArgs.Empty);
    }
}