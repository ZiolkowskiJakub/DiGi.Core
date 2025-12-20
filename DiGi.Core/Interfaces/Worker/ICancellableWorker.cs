namespace DiGi.Core.Interfaces
{
    public interface ICancellableWorker : IWorker
    {
        void CancelAsync();

        bool CancellationPending { get; }
    }
}
