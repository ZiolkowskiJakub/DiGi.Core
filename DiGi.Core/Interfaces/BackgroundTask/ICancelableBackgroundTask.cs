using DiGi.Core.Enums;
using System.Threading.Tasks;

namespace DiGi.Core.Interfaces
{
    public interface ICancelableBackgroundTask : IBackgroundTask
    {
        CancelableBackgroundTaskStatus CancelableBackgroundTaskStatus { get; }

        Task StopAsync();
    }
}