using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the method used for rounding numbers.
    /// </summary>
    [Description("Rounding Method")]
    public enum RoundingMethod
    {
        [Description("Undefined")] Undefined,
        [Description("Ceiling")] Ceiling,
        [Description("Nearest")] Nearest,
        [Description("Truncate")] Truncate,
    }
}