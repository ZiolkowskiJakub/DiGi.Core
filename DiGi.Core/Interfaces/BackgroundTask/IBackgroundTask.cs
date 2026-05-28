using DiGi.Core.Enums;
using System;
 
namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a task that runs in the background.</summary>
    public interface IBackgroundTask : IObject
    {
        /// <summary>Occurs when the background task has started executing.</summary>
        event EventHandler? Started;
 
        /// <summary>Occurs just before the background task starts executing.</summary>
        event EventHandler? Starting;
 
        /// <summary>Occurs when the background task has stopped executing.</summary>
        event EventHandler? Stopped;
 
        /// <summary>Occurs just before the background task stops executing.</summary>
        event EventHandler? Stopping;
 
        /// <summary>Gets the current status of the background task.</summary>
        BackgroundTaskStatus BackgroundTaskStatus { get; }
 
        /// <summary>Gets the total time elapsed during execution.</summary>
        TimeSpan ExecutionTimeSpan { get; }
 
        /// <summary>Gets the exception that occurred during execution, if any.</summary>
        Exception? Exception { get; }
 
        /// <summary>Gets a value indicating whether the task is currently running.</summary>
        bool IsRunning { get; }
 
        /// <summary>Starts the execution of the background task.</summary>
        void Start();
    }
}