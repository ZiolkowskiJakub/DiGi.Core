using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Create
    {
        public static IData Data(this JsonNode jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            switch (jsonNode.GetValueKind())
            {
                case System.Text.Json.JsonValueKind.Object:
                    return new DataObject(jsonNode.AsObject());

                case System.Text.Json.JsonValueKind.Number:
                    if (Core.Query.TryConvert(jsonNode.AsValue().GetValue<object>(), out double @double))
                    {
                        return new DataValue(@double);
                    }
                    break;

                case System.Text.Json.JsonValueKind.Array:
                    return new DataArray(jsonNode.AsArray());

                case System.Text.Json.JsonValueKind.String:
                    if (Core.Query.TryConvert(jsonNode.AsValue().GetValue<object>(), out string @string))
                    {
                        return new DataValue(@string);
                    }
                    break;

                case System.Text.Json.JsonValueKind.True:
                    return new DataValue(true);

                case System.Text.Json.JsonValueKind.False:
                    return new DataValue(false);

                case System.Text.Json.JsonValueKind.Null:
                    return null;

                case System.Text.Json.JsonValueKind.Undefined:
                    return null;

            }

            return null;
        }

        public static IData Data(this object @object)
        {
            if(@object == null)
            {
                return null;
            }

            if(@object is JsonNode)
            {
                return Data((JsonObject)@object);
            }

            if(@object is IData)
            {
                return ((IData)@object).Clone<IData>();
            }

            DataType dataType = Core.Query.DataType(@object);
            if(dataType == DataType.Undefined || dataType == DataType.Other)
            {
                return null;
            }
            
            switch(dataType)
            {
                case DataType.SByte:
                case DataType.Byte:
                case DataType.Short:
                case DataType.UShort:
                case DataType.Int:
                case DataType.UInt:
                case DataType.Long:
                case DataType.ULong:
                case DataType.Float:
                case DataType.Double:
                case DataType.Decimal:
                case DataType.DateTime:
                case DataType.Bool:
                case DataType.String:
                case DataType.Guid:
                case DataType.Enum:
                    return new DataValue(@object as dynamic);
            }

            if(@object is ISerializableObject)
            {
                return new DataObject(((ISerializableObject)@object).ToJson());
            }

            return null;
        }

    }
}