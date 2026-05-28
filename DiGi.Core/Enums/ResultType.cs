using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the result status of an operation.
    /// </summary>
    [Description("Result Type")]
    public enum ResultType
    {
        [Description("Undefined")] Undefined,
        [Description("Succeeded")] Succeeded,
        [Description("Failed")] Failed,
        [Description("Canceled")] Canceled
    }
}