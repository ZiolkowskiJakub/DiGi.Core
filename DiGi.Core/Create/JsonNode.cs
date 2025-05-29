using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static JsonNode JsonNode(this object @object)
        {
            if (@object == null)
            {
                return null;
            }

            object object_Temp = @object;

            if (object_Temp is System.Drawing.Color)
            {
                object_Temp = (Color)(System.Drawing.Color)object_Temp;
            }

            if (object_Temp is ISerializableObject)
            {
                return ((ISerializableObject)object_Temp).ToJsonObject();
            }
            else if (!(object_Temp is string) && object_Temp is IEnumerable)
            {
                if(object_Temp is IDictionary)
                {
                    IDictionary dictionary = (IDictionary)object_Temp;

                    JsonObject jsonObject = new JsonObject();
                    foreach(object key in dictionary.Keys)
                    {
                        jsonObject[key is string ? (string)key : JsonNode(key).ToString()] = JsonNode(dictionary[key]);
                    }

                    return jsonObject;
                }
                else
                {
                    JsonArray jsonArray = new JsonArray();
                    foreach (object object_Temp_Temp in (IEnumerable)object_Temp)
                    {
                        jsonArray.Add(JsonNode(object_Temp_Temp));
                    }
                    return jsonArray;
                }
            }
            else
            {
                if (object_Temp is double)
                {
                    double @double = (double)object_Temp;
                    if (double.IsNaN(@double) || double.IsInfinity(@double))
                    {
                        object_Temp = object_Temp.ToString();
                    }
                }
                else if (object_Temp is float)
                {
                    float @float= (float)object_Temp;
                    if (float.IsNaN(@float) || float.IsInfinity(@float))
                    {
                        object_Temp = object_Temp.ToString();
                    }
                }

                return JsonValue.Create(object_Temp);
            }
        }
    }
}
