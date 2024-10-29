using System.ComponentModel;

namespace DiGi.Core.IO.Enums
{
    [Description("PropertyType")]
    public enum PropertyType
    {
        [Description("Undefined")] Undefined,
        [Description("Value")] Value,
        [Description("Object")] Object,
        [Description("Enumerable")] Enumerable,
    }
}
