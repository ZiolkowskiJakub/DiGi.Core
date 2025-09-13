using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static JsonNode? JsonNode(this object? @object)
        {
            if (@object == null)
            {
                return null;
            }

            object object_Temp = @object;

            if (object_Temp is System.Drawing.Color color)
            {
                object_Temp = (Color)color;
            }

            if (object_Temp is ISerializableObject serializableObject)
            {
                return serializableObject.ToJsonObject();
            }
            else if (object_Temp is not string and IEnumerable)
            {
                if (object_Temp is IDictionary dictionary)
                {
                    JsonObject jsonObject = [];
                    foreach (object key in dictionary.Keys)
                    {
                        string? key_Temp = key is string @string ? @string : JsonNode(key)?.ToString();
                        if (key_Temp == null)
                        {
                            continue;
                        }

                        jsonObject[key_Temp] = JsonNode(dictionary[key]);
                    }

                    return jsonObject;
                }
                else
                {
                    JsonArray jsonArray = [];
                    foreach (object object_Temp_Temp in (IEnumerable)object_Temp)
                    {
                        jsonArray.Add(JsonNode(object_Temp_Temp));
                    }
                    return jsonArray;
                }
            }
            else
            {
                if (object_Temp is double @double)
                {
                    if (double.IsNaN(@double) || double.IsInfinity(@double))
                    {
                        object_Temp = object_Temp.ToString();
                    }
                }
                else if (object_Temp is float @float)
                {
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
