using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        internal static WrapperUniqueIdReference WrapperUniqueIdReference(this JsonArray jsonArray)
        {
            if(jsonArray == null)
            {
                return null;
            }

            UniqueIdReference uniqueIdReference = Core.Create.UniqueReference(jsonArray) as UniqueIdReference;
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }

        internal static WrapperUniqueIdReference WrapperUniqueIdReference(this JsonValue jsonValue)
        {
            if (jsonValue == null)
            {
                return null;
            }

            UniqueIdReference uniqueIdReference = Core.Create.UniqueReference(jsonValue) as UniqueIdReference;
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }
    }
}

