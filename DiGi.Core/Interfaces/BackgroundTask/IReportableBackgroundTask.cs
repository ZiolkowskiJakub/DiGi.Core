using System;
 
namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a background task that can report progress.</summary>
    public interface IReportableBackgroundTask : ICancelableBackgroundTask
    {
    }
 
    /// <summary>Defines a generic contract for a background task that reports progress of type T.</summary>
    /// <typeparam name="T">The type of the progress data reported.</typeparam>
    public interface IReportableBackgroundTask<T> : IReportableBackgroundTask
    {
        /// <summary>Occurs when the progress of the background task changes.</summary>
        event EventHandler<T>? ProgressChanged;
    }
}