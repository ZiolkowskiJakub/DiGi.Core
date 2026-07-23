using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the method used for rounding numbers.
    /// </summary>
    [Description("Rounding Method")]
    public enum RoundingMethod
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>Ceiling</summary>
        [Description("Ceiling")] Ceiling,

        /// <summary>Floor</summary>
        [Description("Floor")] Floor,

        /// <summary>Nearest</summary>
        [Description("Nearest")] Nearest,

        /// <summary>Truncate</summary>
        [Description("Truncate")] Truncate,
    }
}