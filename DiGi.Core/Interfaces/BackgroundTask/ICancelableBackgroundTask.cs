using DiGi.Core.Enums;
using System.Threading.Tasks;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a background task that can be cancelled.</summary>
    public interface ICancelableBackgroundTask : IBackgroundTask
    {
        /// <summary>Gets the current cancellation status of the background task.</summary>
        CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus { get; }

        /// <summary>Asynchronously stops the background task.</summary>
        /// <returns>A task that represents the asynchronous stop operation.</returns>
        Task StopAsync();
    }
}