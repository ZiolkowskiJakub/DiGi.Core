using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the status of a background task.
    /// </summary>
    [Description("Background Task Status")]
    public enum BackgroundTaskStatus
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>Running</summary>
        [Description("Running")] Running,

        /// <summary>Completed</summary>
        [Description("Completed")] Completed,

        /// <summary>Idle</summary>
        [Description("Idle")] Idle,

        /// <summary>Failed</summary>
        [Description("Failed")] Failed
    }
}