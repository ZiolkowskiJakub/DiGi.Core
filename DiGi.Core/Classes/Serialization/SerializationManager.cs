using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class SerializationManager
    {
        private Dictionary<string, SerializationConstructor> dictionary_SerializationConstructor = new Dictionary<string, SerializationConstructor>();
        private Dictionary<string, SerializationMethodCollection> dictionary_SerializationMethodCollection = new Dictionary<string, SerializationMethodCollection>();
        public SerializationManager()
        {

        }

        public JsonSerializerOptions JsonSerializerOptions { get; set; } = new JsonSerializerOptions() { NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals };
        
        public SerializationConstructor GetSerializationConstructor(Type type, bool update = true)
        {
            if(type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string fullTypeName = Query.FullTypeName(type);
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return GetSerializationConstructor(fullTypeName, update);
        }

        public SerializationConstructor GetSerializationConstructor<T>(bool update = true) where T: ISerializableObject
        {
            return GetSerializationConstructor(typeof(T), update);
        }

        public SerializationConstructor GetSerializationConstructor(string fullTypeName, bool update = true)
        {
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            if (dictionary_SerializationConstructor.TryGetValue(fullTypeName, out SerializationConstructor result))
            {
                return result;
            }

            if (!update)
            {
                return null;
            }


            Type type = Query.Type(fullTypeName);
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            result = Create.SerializationConstructor(type);
            if (result == null)
            {
                return null;
            }

            lock (dictionary_SerializationConstructor)
            {
                dictionary_SerializationConstructor[fullTypeName] = result;
            }

            return result;
        }

        public SerializationMethodCollection GetSerializationMethodCollection(Type type, bool update = true)
        {
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            if (dictionary_SerializationMethodCollection.TryGetValue(fullTypeName, out SerializationMethodCollection result))
            {
                return result;
            }

            if (!update)
            {
                return null;
            }

            result = Create.SerializationMethodCollection(type);
            if (result == null)
            {
                return null;
            }

            lock(dictionary_SerializationMethodCollection)
            {
                dictionary_SerializationMethodCollection[fullTypeName] = result;
            }

            return result;
        }

        public SerializationMethodCollection GetSerializationMethodCollection<T>(bool update = true) where T :ISerializableObject
        {
            return GetSerializationMethodCollection(typeof(T), update);
        }

        public SerializationMethodCollection GetSerializationMethodCollection(ISerializableObject serializableObject, bool update = true)
        {
            Type type = serializableObject?.GetType();
            if(type == null)
            {
                return null;
            }

            return GetSerializationMethodCollection(type, update);
        }
    }
}
