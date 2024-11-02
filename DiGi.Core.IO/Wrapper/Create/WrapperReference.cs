using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        internal static IWrapperReference WrapperReference(this JsonObject jsonObject)
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
                    if(Query.IsWrapperReference(jsonObject))
                    {
                        return Core.Create.SerializableObject<IWrapperReference>(jsonObject);
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

            UniqueIdReference uniqueIdReference = Core.Create.UniqueIdReference(jsonObject);
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new WrapperUniqueIdReference(uniqueIdReference);
        }

        internal static IWrapperReference WrapperReference(this JsonNode jsonNode)
        {
            if(jsonNode == null)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return WrapperReference((JsonObject)jsonNode);
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

    }
}

