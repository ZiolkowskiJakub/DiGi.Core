﻿using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class SerializationMethodCollection
    {
        private string fullTypeName;
        private Dictionary<string, SerializationMethod> dictionary;

        internal SerializationMethodCollection(string fullTypeName, IEnumerable<SerializationMethod> serializationMethods)
        {
            this.fullTypeName = fullTypeName;
            if(serializationMethods != null)
            {
                dictionary = new Dictionary<string, SerializationMethod>();
                foreach(SerializationMethod serializationMethod in serializationMethods)
                {
                    dictionary[serializationMethod.Name] = serializationMethod;
                }
            }
        }

        internal SerializationMethodCollection(string fullTypeName)
        {
            this.fullTypeName = fullTypeName;
        }

        public bool Update(ISerializableObject serializableObject, JsonObject jsonObject)
        {
            return Update(serializableObject, jsonObject, out HashSet<string> propertyNames);
        }

        public bool Update(ISerializableObject serializableObject, JsonObject jsonObject, out HashSet<string> propertyNames)
        {
            propertyNames = null;

            if(serializableObject == null || jsonObject == null || dictionary == null || dictionary.Count == 0)
            {
                return false;
            }

            propertyNames = new HashSet<string>();
            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                SerializationMethod serializationMethod = this[keyValuePair.Key];
                if(serializationMethod == null)
                {
                    continue;
                }

                MemberInfo memberInfo = serializationMethod.MemberInfo;
                if(memberInfo == null)
                {
                    continue;
                }

                JsonNode jsonNode = keyValuePair.Value;

                if (memberInfo is PropertyInfo)
                {
                    PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
                    if (propertyInfo.SetMethod == null)
                    {
                        continue;
                    }

                    propertyInfo.SetValue(serializableObject, jsonNode.Value(propertyInfo.PropertyType));
                    propertyNames.Add(keyValuePair.Key);
                }
                else if (memberInfo is FieldInfo)
                {
                    FieldInfo fieldInfo = (FieldInfo)memberInfo;

                    fieldInfo.SetValue(serializableObject, jsonNode.Value(fieldInfo.FieldType));
                    propertyNames.Add(keyValuePair.Key);
                }
            }

            return true;
        }

        public JsonObject Create(ISerializableObject serializableObject)
        {
            if(serializableObject == null)
            {
                return null;
            }

            JsonObject result = new JsonObject();
            if(dictionary == null || dictionary.Count == 0)
            {
                return result;
            }

            foreach(SerializationMethod serializationMethod in dictionary.Values)
            {
                MemberInfo memberInfo = serializationMethod?.MemberInfo;
                if(memberInfo == null)
                {
                    continue;
                }

                object value = null;

                if (memberInfo is PropertyInfo)
                {
                    PropertyInfo propertyInfo = (PropertyInfo)memberInfo;
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
                else if (memberInfo is FieldInfo)
                {
                    FieldInfo fieldInfo = (FieldInfo)memberInfo;
                    value = fieldInfo.GetValue(serializableObject);
                }

                result[serializationMethod.Name] = Core.Create.JsonNode(value);
            }

            if(result != null && !result.ContainsKey(Constans.Serialization.PropertyName.Type))
            {
                result[Constans.Serialization.PropertyName.Type] = Query.FullTypeName(serializableObject);
            }

            return result;

        }

        public SerializationMethod this[string name]
        {
            get
            {
                if(string.IsNullOrEmpty(name) || dictionary == null || !dictionary.TryGetValue(name, out SerializationMethod result))
                {
                    return null;
                }

                return result;
            }
        }
    }
}
