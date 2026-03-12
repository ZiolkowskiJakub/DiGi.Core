using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Cancelable Task Status")]
    public enum CancelableTaskStatus
    {
        [Description("Undefined")] Undefined,
        [Description("Running")] Running,
        [Description("Canceled")] Canceled,
        [Description("Completed")] Completed,
        [Description("Idle")] Idle
    }
}