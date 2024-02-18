using System.Text.Json;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static JsonValueKind JsonValueKind(this object value)
        {
            if (value == null)
            {
                return System.Text.Json.JsonValueKind.Null;
            }

            if(value is string)
            {
                return System.Text.Json.JsonValueKind.String;
            }

            if(value is bool)
            {
                bool value_Temp = (bool)value;
                return value_Temp ? System.Text.Json.JsonValueKind.True : System.Text.Json.JsonValueKind.False;
            }

            if(value is JsonObject)
            {
                return System.Text.Json.JsonValueKind.Object;
            }

            if(value is JsonArray)
            {
                return System.Text.Json.JsonValueKind.Array;
            }

            if(IsNumeric(value))
            {
                return System.Text.Json.JsonValueKind.Number;
            }


            return System.Text.Json.JsonValueKind.Undefined;
        }

    }

}
