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
                        return new  DataValue(@string);
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

    }
}

