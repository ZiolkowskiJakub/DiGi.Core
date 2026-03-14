using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Create
    {
        internal static IWrapperUniqueReference? WrapperUniqueReference(this JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return null;
            }

            if (jsonObject.ContainsKey(DiGi.Core.Constans.Serialization.PropertyName.Type))
            {
                string? fullTypeName = jsonObject[DiGi.Core.Constans.Serialization.PropertyName.Type]?.AsValue()?.GetValue<string>();
                if (!string.IsNullOrWhiteSpace(fullTypeName))
                {
                    if (Query.IsWrapperUniqueReference(jsonObject))
                    {
                        return DiGi.Core.Create.SerializableObject<IWrapperUniqueReference>(jsonObject);
                    }

                    if (jsonObject.ContainsKey(DiGi.Core.Constans.Serialization.PropertyName.Guid))
                    {
                        object? @object = jsonObject[DiGi.Core.Constans.Serialization.PropertyName.Guid]?.AsValue()?.GetValue<object>();
                        if (DiGi.Core.Query.TryConvert(@object, out Guid guid))
                        {
                            return new WrapperGuidReference(fullTypeName, guid);
                        }
                    }
                }
            }

            return WrapperUniqueReference(DiGi.Core.Create.UniqueReference(jsonObject));
        }

        internal static IWrapperUniqueReference? WrapperUniqueReference(this JsonNode? jsonNode)
        {
            if (jsonNode == null)
            {
                return null;
            }

            if (jsonNode is JsonObject jsonObject)
            {
                return WrapperUniqueReference(jsonObject);
            }

            if (jsonNode is JsonArray jsonArray)
            {
                return WrapperUniqueIdReference(jsonArray);
            }

            if (jsonNode is JsonValue jsonValue)
            {
                return WrapperUniqueIdReference(jsonValue);
            }

            return null;
        }

        internal static IWrapperUniqueReference? WrapperUniqueReference(this UniqueReference? uniqueReference)
        {
            if (uniqueReference is null)
            {
                return null;
            }

            if (uniqueReference is GuidReference guidReference)
            {
                return new WrapperGuidReference(guidReference);
            }

            if (uniqueReference is UniqueIdReference uniqueIdReference)
            {
                return new WrapperUniqueIdReference(uniqueIdReference);
            }

            throw new NotImplementedException();
        }
    }
}