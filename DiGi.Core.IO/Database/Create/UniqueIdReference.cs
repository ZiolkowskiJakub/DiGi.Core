using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Create
    {
        public static UniqueIdReference UniqueIdReference(this object @object)
        {
            if(@object == null)
            {
                return null;
            }

            object @object_Temp = @object;
            if(@object_Temp is JsonValue)
            {
                if(!((JsonValue)object_Temp).TryGetValue(out object_Temp))
                {
                    object_Temp = null;
                }
            }

            return Core.Create.UniqueIdReference(object_Temp);

        }
    }
}
