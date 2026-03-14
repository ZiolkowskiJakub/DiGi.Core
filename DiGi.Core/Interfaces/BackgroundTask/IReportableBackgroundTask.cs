using System;

namespace DiGi.Core.Interfaces
{
    public interface IReportableBackgroundTask : ICancelableBackgroundTask
    {

    }

    public interface IReportableBackgroundTask<T> : IReportableBackgroundTask
    {
        event EventHandler<T>? ProgressChanged;
    }
}