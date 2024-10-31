using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        public static bool IsObjectReference(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return false;
            }

            if (!jsonObject.ContainsKey(Constans.Serialization.PropertyName.Type))
            {
                return false;
            }

            string fullTypeName = jsonObject[Constans.Serialization.PropertyName.Type].AsValue()?.GetValue<string>();
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return false;
            }

            if (Core.Query.FullTypeName(typeof(ObjectUniqueIdReference)) == fullTypeName || Core.Query.FullTypeName(typeof(ObjectGuidReference)) == fullTypeName)
            {
                return true;
            }

            return false;
        }

        public static bool IsObjectReference(this JsonObject jsonObject, out IObjectReference objectReference)
        {
            objectReference = null;

            if(!IsObjectReference(jsonObject))
            {
                return false;
            }

            objectReference = Create.ObjectReference(jsonObject);
            return objectReference != null;
        }
    }
}

