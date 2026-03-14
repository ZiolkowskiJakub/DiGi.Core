using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Cancelable Background Task Status")]
    public enum CancelableBackgroundTaskStatus
    {
        [Description("Undefined")] Undefined,
        [Description("Running")] Running,
        [Description("Canceled")] Canceled,
        [Description("Completed")] Completed,
        [Description("Idle")] Idle
    }
}