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
            if(@object == null)
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
            else if(!(object_Temp is string) && object_Temp is IEnumerable)
            {
                JsonArray jsonArray = new JsonArray();
                foreach(object object_Temp_Temp in (IEnumerable)object_Temp)
                {
                    jsonArray.Add(JsonNode(object_Temp_Temp));
                }
                return jsonArray;
            }
            else
            {
                return JsonValue.Create(object_Temp);
            }
        }
    }
}
