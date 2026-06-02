using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Defines the supported data types within the DiGi.Core system.
    /// </summary>
    [Description("DataType")]
    public enum DataType
    {
        /// <summary>Undefined</summary>
        [Description("Undefined")] Undefined,

        /// <summary>Signed 8-bit integer</summary>
        [Description("Signed 8-bit integer")] SByte,

        /// <summary>Unsigned 8-bit integer</summary>
        [Description("Unsigned 8-bit integer")] Byte,

        /// <summary>Signed 16-bit integer</summary>
        [Description("Signed 16-bit integer")] Short,

        /// <summary>Unsigned 16-bit integer</summary>
        [Description("Unsigned 16-bit integer")] UShort,

        /// <summary>Signed 32-bit integer</summary>
        [Description("Signed 32-bit integer")] Int,

        /// <summary>Unsigned 32-bit integer</summary>
        [Description("Unsigned 32-bit integer")] UInt,

        /// <summary>Signed 64-bit integer</summary>
        [Description("Signed 64-bit integer")] Long,

        /// <summary>Unsigned 64-bit integer</summary>
        [Description("Unsigned 64-bit integer")] ULong,

        /// <summary>Signed 4 bytes float</summary>
        [Description("Signed 4 bytes float")] Float,

        /// <summary>Signed 8 bytes double</summary>
        [Description("Signed 8 bytes double")] Double,

        /// <summary>Signed 16 bytes decimal</summary>
        [Description("Signed 16 bytes decimal")] Decimal,

        /// <summary>DateTime</summary>
        [Description("DateTime")] DateTime,

        /// <summary>Bool</summary>
        [Description("Bool")] Bool,

        /// <summary>String</summary>
        [Description("String")] String,

        /// <summary>Guid</summary>
        [Description("Guid")] Guid,

        /// <summary>Enum</summary>
        [Description("Enum")] Enum,

        /// <summary>Struct</summary>
        [Description("Struct")] ValueType,

        /// <summary>JsonNode</summary>
        [Description("JsonNode")] JsonNode,

        /// <summary>Object</summary>
        [Description("Object")] Object,

        /// <summary>Serializable Object</summary>
        [Description("Serializable Object")] SerializableObject,

        /// <summary>Other</summary>
        [Description("Other")] Other,
    }
}