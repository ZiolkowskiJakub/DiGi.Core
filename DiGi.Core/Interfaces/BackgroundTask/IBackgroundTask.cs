using DiGi.Core.Enums;
using System;

namespace DiGi.Core.Interfaces
{
    public interface IBackgroundTask : IObject
    {
        event EventHandler? Started;

        event EventHandler? Starting;

        event EventHandler? Stopped;

        event EventHandler? Stopping;

        BackgroundTaskStatus BackgroundTaskStatus { get; }
        
        Exception? Exception { get; }
        
        bool IsRunning { get; }

        void Start();
    }
}