namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a worker that can be cancelled.</summary>
    public interface ICancellableWorker : IWorker
    {
        /// <summary>Initiates an asynchronous cancellation of the worker's operation.</summary>
        void CancelAsync();

        /// <summary>Gets a value indicating whether a cancellation is pending.</summary>
        bool CancellationPending { get; }
    }
}