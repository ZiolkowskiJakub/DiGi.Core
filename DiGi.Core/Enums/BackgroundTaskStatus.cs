using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the status of a background task.
    /// </summary>
    [Description("Background Task Status")]
    public enum BackgroundTaskStatus
    {
        [Description("Undefined")] Undefined,
        [Description("Running")] Running,
        [Description("Completed")] Completed,
        [Description("Idle")] Idle,
        [Description("Failed")] Failed
    }
}