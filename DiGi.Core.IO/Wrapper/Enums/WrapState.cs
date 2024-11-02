using System.ComponentModel;

namespace DiGi.Core.IO.Wrapper.Enums
{
    [Description("Wrap State")]
    internal enum WrapState
    {
        [Description("Undefined")] Undefined,
        [Description("Wrapped")] Wrapped,
        [Description("Unwrapped")] Unwrapped,
    }
}
