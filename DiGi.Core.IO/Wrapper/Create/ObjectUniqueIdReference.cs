using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        public static ObjectUniqueIdReference ObjectUniqueIdReference(this JsonArray jsonArray)
        {
            if(jsonArray == null)
            {
                return null;
            }

            UniqueIdReference uniqueIdReference = Core.Create.UniqueIdReference(jsonArray);
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new ObjectUniqueIdReference(uniqueIdReference);
        }

        public static ObjectUniqueIdReference ObjectUniqueIdReference(this JsonValue jsonValue)
        {
            if (jsonValue == null)
            {
                return null;
            }

            UniqueIdReference uniqueIdReference = Core.Create.UniqueIdReference(jsonValue);
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new ObjectUniqueIdReference(uniqueIdReference);
        }
    }
}

