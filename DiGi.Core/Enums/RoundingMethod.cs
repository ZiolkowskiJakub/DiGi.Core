using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Rounding Method")]
    public enum RoundingMethod
    {
        [Description("Undefined")] Undefined,
        [Description("Ceiling")] Ceiling,
        [Description("Nearest")] Nearest,
        [Description("Truncate")] Truncate,
    }
}
