using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class SerializationMethodCollection
    {
        private readonly Dictionary<string, SerializationMethod> dictionary = [];
        private readonly string? fullTypeName;

        internal SerializationMethodCollection(string? fullTypeName, IEnumerable<SerializationMethod> serializationMethods)
        {
            this.fullTypeName = fullTypeName;
            if (serializationMethods != null)
            {
                foreach (SerializationMethod serializationMethod in serializationMethods)
                {
                    dictionary[serializationMethod.Name] = serializationMethod;
                }
            }
        }

        internal SerializationMethodCollection(string? fullTypeName)
        {
            this.fullTypeName = fullTypeName;
        }

        public SerializationMethod? this[string? name]
        {
            get
            {
                if (string.IsNullOrEmpty(name) || !dictionary.TryGetValue(name!, out SerializationMethod result))
                {
                    return null;
                }

                return result;
            }
        }

        public JsonObject? Create(ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            JsonObject result = [];
            if (dictionary == null || dictionary.Count == 0)
            {
                return result;
            }

            foreach (SerializationMethod serializationMethod in dictionary.Values)
            {
                MemberInfo? memberInfo = serializationMethod?.MemberInfo;
                if (memberInfo == null)
                {
                    continue;
                }

                object? value = null;

                if (memberInfo is PropertyInfo propertyInfo)
                {
                    MethodInfo methodInfo = propertyInfo.GetMethod;
                    if (methodInfo == null)
                    {
                        continue;
                    }

                    ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                    if (parameterInfos != null && parameterInfos.Length > 0)
                    {
                        continue;
                    }

                    value = propertyInfo.GetValue(serializableObject);
                }
                else if (memberInfo is FieldInfo fieldInfo)
                {
                    value = fieldInfo.GetValue(serializableObject);
                }

                result[serializationMethod!.Name] = Core.Create.JsonNode(value);
            }

            if (result != null && !result.ContainsKey(Constans.Serialization.PropertyName.Type))
            {
                result[Constans.Serialization.PropertyName.Type] = Query.FullTypeName(serializableObject);
            }

            return result;
        }

        public bool Update(ISerializableObject? serializableObject, JsonObject? jsonObject)
        {
            return Update(serializableObject, jsonObject, out _);
        }

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
                SerializationMethod? serializationMethod = this[keyValuePair.Key];
                if (serializationMethod == null)
                {
                    continue;
                }

                MemberInfo memberInfo = serializationMethod.MemberInfo;
                if (memberInfo == null)
                {
                    continue;
                }

                JsonNode? jsonNode = keyValuePair.Value;

                if (memberInfo is PropertyInfo propertyInfo)
                {
                    if (propertyInfo.SetMethod == null)
                    {
                        continue;
                    }

                    propertyInfo.SetValue(serializableObject, jsonNode?.Value(propertyInfo.PropertyType));
                    propertyNames.Add(keyValuePair.Key);
                }
                else if (memberInfo is FieldInfo fieldInfo)
                {
                    fieldInfo.SetValue(serializableObject, jsonNode?.Value(fieldInfo.FieldType));
                    propertyNames.Add(keyValuePair.Key);
                }
            }

            if (serializableObject is IValue && jsonObject.TryGetPropertyValue(Constans.Serialization.PropertyName.ValueType, out JsonNode? jsonNode_ValueType) && jsonNode_ValueType is not null && jsonObject.ContainsKey(Constans.Serialization.PropertyName.Value))
            {
                if (this[Constans.Serialization.PropertyName.Value]?.MemberInfo is MemberInfo memberInfo)
                {
                    object? value = null;
                    if (memberInfo is PropertyInfo propertyInfo)
                    {
                        if (propertyInfo.SetMethod != null)
                        {
                            value = propertyInfo.GetValue(serializableObject);
                        }
                    }
                    else if (memberInfo is FieldInfo fieldInfo)
                    {
                        value = fieldInfo.GetValue(serializableObject);
                    }

                    if (value != null && Query.Type(jsonNode_ValueType.GetValue<string>()) is System.Type type)
                    {
                        if (!type.IsAssignableFrom(value.GetType()) && Query.TryConvert(value, out object? value_Converted, type))
                        {
                            (memberInfo as dynamic).SetValue(serializableObject, value_Converted);
                        }
                    }
                }
            }

            return true;
        }
    }
}