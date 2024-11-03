using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        internal static IWrapperUniqueReference WrapperUniqueReference(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            if (jsonObject.ContainsKey(Core.Constans.Serialization.PropertyName.Type))
            {
                string fullTypeName = jsonObject[Core.Constans.Serialization.PropertyName.Type].AsValue()?.GetValue<string>();
                if (!string.IsNullOrWhiteSpace(fullTypeName))
                {
                    if(Query.IsWrapperUniqueReference(jsonObject))
                    {
                        return Core.Create.SerializableObject<IWrapperUniqueReference>(jsonObject);
                    }

                    if (jsonObject.ContainsKey(Core.Constans.Serialization.PropertyName.Guid))
                    {
                        object @object = jsonObject[Core.Constans.Serialization.PropertyName.Guid]?.AsValue()?.GetValue<object>();
                        if (Core.Query.TryConvert(@object, out Guid guid))
                        {
                            return new WrapperGuidReference(fullTypeName, guid);
                        }
                    }
                }
            }

            return WrapperUniqueReference(Core.Create.UniqueReference(jsonObject));
        }

        internal static IWrapperUniqueReference WrapperUniqueReference(this JsonNode jsonNode)
        {
            if(jsonNode == null)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return WrapperUniqueReference((JsonObject)jsonNode);
            }

            if(jsonNode is JsonArray)
            {
                return WrapperUniqueIdReference((JsonArray)jsonNode);
            }

            if (jsonNode is JsonValue)
            {
                return WrapperUniqueIdReference((JsonValue)jsonNode);
            }

            return null;

        }

        internal static IWrapperUniqueReference WrapperUniqueReference(this UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return null;
            }

            if(uniqueReference is GuidReference)
            {
                return new WrapperGuidReference((GuidReference)uniqueReference);
            }

            if(uniqueReference is UniqueIdReference)
            {
                return new WrapperUniqueIdReference((UniqueIdReference)uniqueReference);
            }

            throw new NotImplementedException();
        }

    }
}

