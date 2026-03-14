using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Background Task Status")]
    public enum BackgroundTaskStatus
    {
        [Description("Undefined")] Undefined,
        [Description("Running")] Running,
        [Description("Completed")] Completed,
        [Description("Idle")] Idle
    }
}