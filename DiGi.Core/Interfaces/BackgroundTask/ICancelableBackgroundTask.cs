using System.Threading.Tasks;

namespace DiGi.Core.Interfaces
{
    public interface ICancelableBackgroundTask : IBackgroundTask
    {
        Task StopAsync();
    }
}