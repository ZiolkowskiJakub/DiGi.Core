using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A collection of SerializationMethod objects for a specific type; handles the actual conversion between objects and JSON.
    /// </summary>
    public class SerializationMethodCollection
    {
        private readonly Dictionary<string, SerializationMethod> dictionary = [];
        private readonly string? fullTypeName;
        private readonly SerializationMethod? serializationMethod_FullTypeName;
        private readonly List<SerializationMethod> serializationMethods = [];
        private readonly System.Type? type;

        internal SerializationMethodCollection(System.Type? type, string? fullTypeName, IEnumerable<SerializationMethod> serializationMethods)
        {
            this.type = type;
            this.fullTypeName = fullTypeName;
            if (serializationMethods != null)
            {
                foreach (SerializationMethod serializationMethod in serializationMethods)
                {
                    if (dictionary.TryGetValue(serializationMethod.Name, out SerializationMethod? serializationMethod_Existing))
                    {
                        this.serializationMethods[this.serializationMethods.IndexOf(serializationMethod_Existing!)] = serializationMethod;
                    }
                    else
                    {
                        this.serializationMethods.Add(serializationMethod);
                    }

                    dictionary[serializationMethod.Name] = serializationMethod;
                }
            }

            for (int i = 0; i < this.serializationMethods.Count; i++)
            {
                SerializationMethod serializationMethod = this.serializationMethods[i];
                if (serializationMethod.Name == Constants.Serialization.PropertyName.Type && serializationMethod.MemberInfo.DeclaringType == typeof(SerializableObject))
                {
                    serializationMethod_FullTypeName = serializationMethod;
                    break;
                }
            }
        }

        internal SerializationMethodCollection(System.Type? type, string? fullTypeName)
        {
            this.type = type;
            this.fullTypeName = fullTypeName;
        }

        /// <summary>
        /// Gets the <see cref="SerializationMethod"/> associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the serialization method to retrieve.</param>
        /// <returns>The <see cref="SerializationMethod"/> if a match is found; otherwise, null.</returns>
        public SerializationMethod? this[string? name]
        {
            get
            {
                if (string.IsNullOrEmpty(name) || !dictionary.TryGetValue(name!, out SerializationMethod? result))
                {
                    return null;
                }

                return result;
            }
        }

        /// <summary>
        /// Creates a JsonObject representing the state of the provided serializable object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to be converted into a JSON object.</param>
        /// <returns>A <see cref="JsonObject"/> representing the state of the serializable object, or null if it could not be created.</returns>
        public JsonObject? Create(ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            JsonObject result = [];
            if (serializationMethods.Count == 0)
            {
                return result;
            }

            // The cached full type name can only be substituted for the reflected FullTypeName property
            // when the collection was created for the exact runtime type of the instance.
            bool exactType = fullTypeName != null && serializableObject.GetType() == type;

            for (int i = 0; i < serializationMethods.Count; i++)
            {
                SerializationMethod serializationMethod = serializationMethods[i];
                if (!serializationMethod.IsReadable)
                {
                    continue;
                }

                if (exactType && ReferenceEquals(serializationMethod, serializationMethod_FullTypeName))
                {
                    result[serializationMethod.Name] = fullTypeName;
                    continue;
                }

                object? value = serializationMethod.PropertyInfo != null ? serializationMethod.PropertyInfo.GetValue(serializableObject) : serializationMethod.FieldInfo!.GetValue(serializableObject);

                result[serializationMethod.Name] = Core.Create.JsonNode(value);
            }

            if (!result.ContainsKey(Constants.Serialization.PropertyName.Type))
            {
                result[Constants.Serialization.PropertyName.Type] = exactType ? fullTypeName : Query.FullTypeName(serializableObject);
            }

            return result;
        }

        /// <summary>
        /// Updates the provided serializable object using values from a JsonObject.
        /// </summary>
        /// <param name="serializableObject">The serializable object to be updated.</param>
        /// <param name="jsonObject">The JSON object containing the source data for the update.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool Update(ISerializableObject? serializableObject, JsonObject? jsonObject)
        {
            return Update(serializableObject, jsonObject, out _);
        }

        /// <summary>
        /// Updates the specified serializable object using data from a JSON object.
        /// </summary>
        /// <param name="serializableObject">The serializable object to be updated.</param>
        /// <param name="jsonObject">The JSON object containing the source data for the update.</param>
        /// <param name="propertyNames">When this method returns, contains a set of property names that were updated.</param>
        /// <returns>True if the update was successful; otherwise, false.</returns>
        public bool Update(ISerializableObject? serializableObject, JsonObject? jsonObject, out HashSet<string>? propertyNames)
        {
            propertyNames = null;

            if (serializableObject == null || jsonObject == null || dictionary.Count == 0)
            {
                return false;
            }

            propertyNames = [];
            foreach (KeyValuePair<string, JsonNode?> keyValuePair in jsonObject)
            {
                if (!dictionary.TryGetValue(keyValuePair.Key, out SerializationMethod? serializationMethod) || serializationMethod == null)
                {
                    continue;
                }

                JsonNode? jsonNode = keyValuePair.Value;

                PropertyInfo? propertyInfo = serializationMethod.PropertyInfo;
                if (propertyInfo != null)
                {
                    if (propertyInfo.SetMethod == null)
                    {
                        continue;
                    }

                    propertyInfo.SetValue(serializableObject, jsonNode?.Value(propertyInfo.PropertyType));
                    propertyNames.Add(keyValuePair.Key);
                }
                else if (serializationMethod.FieldInfo is FieldInfo fieldInfo)
                {
                    fieldInfo.SetValue(serializableObject, jsonNode?.Value(fieldInfo.FieldType));
                    propertyNames.Add(keyValuePair.Key);
                }
            }

            if (serializableObject is IValue && jsonObject.TryGetPropertyValue(Constants.Serialization.PropertyName.ValueType, out JsonNode? jsonNode_ValueType) && jsonNode_ValueType is not null && jsonObject.ContainsKey(Constants.Serialization.PropertyName.Value))
            {
                if (this[Constants.Serialization.PropertyName.Value] is SerializationMethod serializationMethod_Value)
                {
                    PropertyInfo? propertyInfo = serializationMethod_Value.PropertyInfo;
                    FieldInfo? fieldInfo = serializationMethod_Value.FieldInfo;

                    object? value = null;
                    if (propertyInfo != null)
                    {
                        if (propertyInfo.SetMethod != null)
                        {
                            value = propertyInfo.GetValue(serializableObject);
                        }
                    }
                    else if (fieldInfo != null)
                    {
                        value = fieldInfo.GetValue(serializableObject);
                    }

                    if (value != null && Query.Type(jsonNode_ValueType.GetValue<string>()) is System.Type type_Value)
                    {
                        if (!type_Value.IsAssignableFrom(value.GetType()) && Query.TryConvert(value, out object? value_Converted, type_Value))
                        {
                            if (propertyInfo != null)
                            {
                                propertyInfo.SetValue(serializableObject, value_Converted);
                            }
                            else
                            {
                                fieldInfo!.SetValue(serializableObject, value_Converted);
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}