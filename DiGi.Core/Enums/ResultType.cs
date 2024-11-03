using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Result Type")]
    public enum ResultType
    {
        [Description("Undefined")] Undefined,
        [Description("Succeeded")] Succeeded,
        [Description("Failed")] Failed,
        [Description("Cancelled")] Cancelled
    }
}
