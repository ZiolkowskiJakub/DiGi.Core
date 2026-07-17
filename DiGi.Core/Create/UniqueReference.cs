using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a unique reference for the specified object.</summary>
        /// <param name="object">The object for which to create a unique reference.</param>
        /// <returns>A unique reference for the specified object.</returns>
        public static UniqueReference? UniqueReference(this object? @object)
        {
            if (@object == null)
            {
                return null;
            }

            if (@object is IUniqueObject)
            {
                if (@object is IGuidObject guidObject)
                {
                    return new GuidReference(guidObject);
                }
                else if (@object is IUniqueIdObject uniqueIdObject)
                {
                    return new UniqueIdReference(uniqueIdObject);
                }
            }

            TypeReference? typeReference = null;
            if (@object is JsonObject jsonObject)
            {
                if (jsonObject.ContainsKey(Constants.Serialization.PropertyName.Type))
                {
                    JsonValue? jsonValue = jsonObject[Constants.Serialization.PropertyName.Type]?.AsValue();
                    if (jsonValue != null && jsonValue.TryGetValue(out string? fullTypeName) && !string.IsNullOrWhiteSpace(fullTypeName))
                    {
                        typeReference = new TypeReference(fullTypeName);
                    }
                }

                if (jsonObject.ContainsKey(Constants.Serialization.PropertyName.Guid))
                {
                    JsonValue? jsonValue = jsonObject[Constants.Serialization.PropertyName.Guid]?.AsValue();
                    if (jsonValue != null)
                    {
                        if (jsonValue.TryGetValue(out Guid guid))
                        {
                            return new GuidReference(typeReference, guid);
                        }

                        if (jsonValue.TryGetValue(out string? @string) && Query.TryConvert(@string, out guid))
                        {
                            return new GuidReference(typeReference, guid);
                        }
                    }
                }

                if (jsonObject.ContainsKey(Constants.Serialization.PropertyName.UniqueId))
                {
                    JsonValue? jsonValue = jsonObject[Constants.Serialization.PropertyName.UniqueId]?.AsValue();
                    if (jsonValue != null && jsonValue.TryGetValue(out string? uniqueId_JsonObject) && uniqueId_JsonObject != null)
                    {
                        return new UniqueIdReference(typeReference, uniqueId_JsonObject);
                    }
                }
            }

            if (typeReference == null)
            {
                typeReference = TypeReference(@object.GetType());
            }

            if (typeReference == null)
            {
                return null;
            }

            if (@object is IUniqueObject uniqueObject)
            {
                return new UniqueIdReference(typeReference, uniqueObject.UniqueId);
            }

            if (!Query.TryGetUniqueId(@object, out string? uniqueId) || uniqueId is null)
            {
                return null;
            }

            return new UniqueIdReference(typeReference, uniqueId);
        }
    }
}