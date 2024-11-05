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
                    JsonValue jsonValue = jsonObject[Constans.Serialization.PropertyName.Type]?.AsValue();
                    if(jsonValue != null && jsonValue.TryGetValue(out string fullTypeName))
                    {
                        typeReference = new TypeReference(fullTypeName);
                    }
                }

                if(jsonObject.ContainsKey(Constans.Serialization.PropertyName.Guid))
                {
                    JsonValue jsonValue = jsonObject[Constans.Serialization.PropertyName.Guid]?.AsValue();
                    if (jsonValue != null)
                    {
                        if(jsonValue.TryGetValue(out Guid guid))
                        {
                            return new GuidReference(typeReference, guid);
                        }

                        if (jsonValue.TryGetValue(out string @string) && Query.TryConvert(@string, out guid))
                        {
                            return new GuidReference(typeReference, guid);
                        }
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
