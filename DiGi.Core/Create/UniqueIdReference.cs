using DiGi.Core.Classes;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static UniqueIdReference UniqueIdReference(this object @object)
        {
            if(@object == null)
            {
                return null;
            }

            TypeReference typeReference = null;
            if (@object is JsonObject)
            {
                JsonObject jsonObject = (JsonObject)@object;
                if (jsonObject.ContainsKey(Constans.Serialization.PropertyName.Type))
                {
                    object @object_FullTypeName = jsonObject[Constans.Serialization.PropertyName.Type]?.AsValue()?.GetValue<object>();
                    if (Query.TryConvert(@object_FullTypeName, out string fullTypeName))
                    {
                        typeReference = new TypeReference(fullTypeName);
                    }
                }
            }

            if (typeReference == null)
            {
                Type type = @object?.GetType();
                if(type == null)
                {
                    return null;
                }

                typeReference = TypeReference(type);
            }

            if(typeReference == null)
            {
                return null;
            }

            if(!Query.TryGetUniqueId(@object, out string uniqueId))
            {
                return null;
            }

            return new UniqueIdReference(typeReference, uniqueId);

        }
    }
}
