using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the result status of an operation.
    /// </summary>
    [Description("Result Type")]
    public enum ResultType
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>Succeeded</summary>
        [Description("Succeeded")] Succeeded,

        /// <summary>Failed</summary>
        [Description("Failed")] Failed,

        /// <summary>Canceled</summary>
        [Description("Canceled")] Canceled
    }
}