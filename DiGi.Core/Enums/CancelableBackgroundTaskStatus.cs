using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the status of a background task that can be canceled.
    /// </summary>
    [Description("Cancelable Background Task Status")]
    public enum CancelableBackgroundTaskStatus
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>Running</summary>
        [Description("Running")] Running,

        /// <summary>Canceled</summary>
        [Description("Canceled")] Canceled,

        /// <summary>Completed</summary>
        [Description("Completed")] Completed,

        /// <summary>Idle</summary>
        [Description("Idle")] Idle,

        /// <summary>Failed</summary>
        [Description("Failed")] Failed
    }
}