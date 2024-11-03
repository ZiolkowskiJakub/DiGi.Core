using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static UniqueReference UniqueReference(this object @object)
        {
            if(@object == null)
            {
                return null;
            }

            if(@object is IUniqueObject)
            {
                return new GuidReference((IUniqueObject)@object);
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

                if(jsonObject.ContainsKey(Constans.Serialization.PropertyName.Guid))
                {
                    object @object_Temp = jsonObject[Constans.Serialization.PropertyName.Guid]?.AsValue()?.GetValue<object>();
                    if (Query.TryConvert(@object_Temp, out Guid guid))
                    {
                        return new GuidReference(typeReference, guid);
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
