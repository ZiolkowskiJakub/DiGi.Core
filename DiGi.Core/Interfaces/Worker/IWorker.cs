namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a worker that performs an operation.</summary>
    public interface IWorker
    {
        /// <summary>Gets a value indicating whether the worker is currently busy.</summary>
        bool IsBusy { get; }
    }
}