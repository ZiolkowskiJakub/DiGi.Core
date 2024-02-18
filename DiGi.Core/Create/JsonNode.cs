using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
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
            else
            {
                return JsonValue.Create(object_Temp);
            }
        }
    }
}
