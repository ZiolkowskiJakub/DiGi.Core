using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        internal static WrapperUniqueIdReference? WrapperUniqueIdReference(this JsonArray? jsonArray)
        {
            if (jsonArray == null)
            {
                return null;
            }

            if (Core.Create.UniqueReference(jsonArray) is not UniqueIdReference uniqueIdReference)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }

        internal static WrapperUniqueIdReference? WrapperUniqueIdReference(this JsonValue? jsonValue)
        {
            if (jsonValue == null)
            {
                return null;
            }

            if (Core.Create.UniqueReference(jsonValue) is not UniqueIdReference uniqueIdReference)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }
    }
}