using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        public static IObjectReference ObjectReference(this JsonObject jsonObject)
        {
            if(jsonObject == null)
            {
                return null;
            }

            if (jsonObject.ContainsKey(Constans.Serialization.PropertyName.Type))
            {
                string fullTypeName = jsonObject[Constans.Serialization.PropertyName.Type].AsValue()?.GetValue<string>();
                if (!string.IsNullOrWhiteSpace(fullTypeName))
                {
                    if(Query.IsObjectReference(jsonObject))
                    {
                        return Core.Create.SerializableObject<IObjectReference>(jsonObject);
                    }

                    if (jsonObject.ContainsKey(Constans.Serialization.PropertyName.Guid))
                    {
                        object @object = jsonObject[Constans.Serialization.PropertyName.Guid]?.AsValue()?.GetValue<object>();
                        if (Core.Query.TryConvert(@object, out Guid guid))
                        {
                            return new ObjectGuidReference(fullTypeName, guid);
                        }
                    }
                }
            }

            UniqueIdReference uniqueIdReference = Core.Create.UniqueIdReference(jsonObject);
            if (uniqueIdReference == null)
            {
                return null;
            }

            return new ObjectUniqueIdReference(uniqueIdReference);
        }

        public static IObjectReference ObjectReference(this JsonNode jsonNode)
        {
            if(jsonNode == null)
            {
                return null;
            }

            if (jsonNode is JsonObject)
            {
                return ObjectReference((JsonObject)jsonNode);
            }

            if(jsonNode is JsonArray)
            {
                return ObjectUniqueIdReference((JsonArray)jsonNode);
            }

            if (jsonNode is JsonValue)
            {
                return ObjectUniqueIdReference((JsonValue)jsonNode);
            }

            return null;

        }

    }
}

