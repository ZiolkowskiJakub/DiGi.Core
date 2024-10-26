using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("DataType")]
    public enum DataType
    {
        [Description("Undefined")] Undefined,
        [Description("Signed 8-bit integer")] SByte,
        [Description("Unsigned 8-bit integer")] Byte,
        [Description("Signed 16-bit integer")] Short,
        [Description("Unsigned 16-bit integer")] UShort,
        [Description("Signed 32-bit integer")] Int,
        [Description("Unsigned 32-bit integer")] UInt,
        [Description("Signed 64-bit integer")] Long,
        [Description("Unsigned 64-bit integer")] ULong,
        [Description("Signed 4 bytes float")] Float,
        [Description("Signed 8 bytes double")] Double,
        [Description("Signed 16 bytes decimal")] Decimal,
        [Description("DateTime")] DateTime,
        [Description("Bool")] Bool,
        [Description("String")] String,
        [Description("Guid")] Guid,
        [Description("Enum")] Enum,
        [Description("Struct")] ValueType,
        [Description("JsonNode")] JsonNode,
        [Description("Serializable Object")] SerializableObject,
        [Description("Other")] Other,

    }
}
