using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Manages caching and retrieval of serialization constructors and method collections to optimize the serialization process.
    /// </summary>
    public class SerializationManager
    {
        private readonly Dictionary<string, SerializationConstructor> dictionary_SerializationConstructor = [];
        private readonly Dictionary<string, SerializationMethodCollection> dictionary_SerializationMethodCollection = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializationManager"/> class.
        /// </summary>
        public SerializationManager()
        {
        }

        /// <summary>
        /// Gets or sets the options used for JSON serialization and deserialization.
        /// </summary>
        public JsonSerializerOptions JsonSerializerOptions { get; set; } = new JsonSerializerOptions() { NumberHandling = JsonNumberHandling.AllowNamedFloatingPointLiterals };

        /// <summary>
        /// Retrieves the serialization constructor for a given type, optionally updating the cache.
        /// </summary>
        /// <param name="type">The type for which to retrieve the serialization constructor.</param>
        /// <param name="update">A value indicating whether to update the cache if the constructor is not found.</param>
        /// <returns>The serialization constructor for the specified type, or null if none was found.</returns>
        public SerializationConstructor? GetSerializationConstructor(Type? type, bool update = true)
        {
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return GetSerializationConstructor(fullTypeName, update);
        }

        /// <summary>
        /// Retrieves the serialization constructor, optionally updating it if necessary.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
        /// <param name="update">True to update the constructor if necessary; otherwise, false.</param>
        /// <returns>The serialization constructor, or null if not found.</returns>
        public SerializationConstructor? GetSerializationConstructor<TSerializableObject>(bool update = true) where TSerializableObject : ISerializableObject
        {
            return GetSerializationConstructor(typeof(TSerializableObject), update);
        }

        /// <summary>
        /// Retrieves the serialization constructor for the specified type name, optionally updating it.
        /// </summary>
        /// <param name="fullTypeName">The full name of the type whose serialization constructor is to be retrieved.</param>
        /// <param name="update">True to update the constructor if necessary; otherwise, false.</param>
        /// <returns>The serialization constructor, or null if not found.</returns>
        public SerializationConstructor? GetSerializationConstructor(string? fullTypeName, bool update = true)
        {
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            if (dictionary_SerializationConstructor.TryGetValue(fullTypeName!, out SerializationConstructor? result))
            {
                return result;
            }

            if (!update)
            {
                return null;
            }

            Type? type = Query.Type(fullTypeName);
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
                dictionary_SerializationConstructor[fullTypeName!] = result;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the serialization method collection for a given type, optionally updating the cache.
        /// </summary>
        /// <param name="type">The type to retrieve the serialization methods for.</param>
        /// <param name="update">True to update the cache if necessary; otherwise, false.</param>
        /// <returns>The collection of serialization methods, or null if not found.</returns>
        public SerializationMethodCollection? GetSerializationMethodCollection(Type? type, bool update = true)
        {
            if (type == null || !typeof(ISerializableObject).IsAssignableFrom(type))
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            if (dictionary_SerializationMethodCollection.TryGetValue(fullTypeName!, out SerializationMethodCollection? result))
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

            lock (dictionary_SerializationMethodCollection)
            {
                dictionary_SerializationMethodCollection[fullTypeName!] = result;
            }

            return result;
        }

        /// <summary>
        /// Retrieves the collection of serialization methods, optionally updating it.
        /// </summary>
        /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
        /// <param name="update">True to update the collection if necessary; otherwise, false.</param>
        /// <returns>The collection of serialization methods, or null if not found.</returns>
        public SerializationMethodCollection? GetSerializationMethodCollection<TSerializableObject>(bool update = true) where TSerializableObject : ISerializableObject
        {
            return GetSerializationMethodCollection(typeof(TSerializableObject), update);
        }

        /// <summary>
        /// Retrieves the collection of serialization methods for the specified object, optionally updating it.
        /// </summary>
        /// <param name="serializableObject">The serializable object to retrieve methods for.</param>
        /// <param name="update">True to update the collection if necessary; otherwise, false.</param>
        /// <returns>The collection of serialization methods, or null if not found.</returns>
        public SerializationMethodCollection? GetSerializationMethodCollection(ISerializableObject? serializableObject, bool update = true)
        {
            Type? type = serializableObject?.GetType();
            if (type == null)
            {
                return null;
            }

            return GetSerializationMethodCollection(type, update);
        }
    }
}