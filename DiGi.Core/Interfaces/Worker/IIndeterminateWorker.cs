namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a worker with indeterminate progress.</summary>
    public interface IIndeterminateWorker : IWorker
    {
        /// <summary>Reports status text during the operation.</summary>
        /// <param name="text">The status text to report.</param>
        void Report(string text);
    }
}