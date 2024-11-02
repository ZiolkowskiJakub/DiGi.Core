using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static bool IsWrapperUniqueReference(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return false;
            }

            if (!jsonObject.ContainsKey(Core.Constans.Serialization.PropertyName.Type))
            {
                return false;
            }

            string fullTypeName = jsonObject[Core.Constans.Serialization.PropertyName.Type].AsValue()?.GetValue<string>();
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return false;
            }

            if (Core.Query.FullTypeName(typeof(WrapperUniqueIdReference)) == fullTypeName || Core.Query.FullTypeName(typeof(WrapperGuidReference)) == fullTypeName)
            {
                return true;
            }

            return false;
        }

        internal static bool IsWrapperUniqueReference(this JsonObject jsonObject, out IWrapperUniqueReference wrapperUniqueReference)
        {
            wrapperUniqueReference = null;

            if(!IsWrapperUniqueReference(jsonObject))
            {
                return false;
            }

            wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject);
            return wrapperUniqueReference != null;
        }
    }
}

