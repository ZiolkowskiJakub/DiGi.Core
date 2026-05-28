using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the status of a background task that can be canceled.
    /// </summary>
    [Description("Cancelable Background Task Status")]
    public enum CancelableBackgroundTaskStatus
    {
        [Description("Undefined")] Undefined,
        [Description("Running")] Running,
        [Description("Canceled")] Canceled,
        [Description("Completed")] Completed,
        [Description("Idle")] Idle,
        [Description("Failed")] Failed
    }
}