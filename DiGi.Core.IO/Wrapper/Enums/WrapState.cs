using System.ComponentModel;

namespace DiGi.Core.IO.Wrapper.Enums
{
    /// <summary>
    /// Defines the state of a wrapped object.
    /// </summary>
    [Description("Wrap State")]
    public enum WrapState
    {
        /// <summary>
        /// The state is undefined.
        /// </summary>
        [Description("Undefined")] Undefined,

        /// <summary>
        /// The object is wrapped.
        /// </summary>
        [Description("Wrapped")] Wrapped,

        /// <summary>
        /// The object is unwrapped.
        /// </summary>
        [Description("Unwrapped")] Unwrapped,
    }
}