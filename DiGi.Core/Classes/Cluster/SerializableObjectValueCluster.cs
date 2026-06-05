using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a base abstract serializable value cluster.
    /// </summary>
    /// <typeparam name="TKey_1">The type of the first key.</typeparam>
    /// <typeparam name="TKey_2">The type of the second key.</typeparam>
    /// <typeparam name="TValue">The type of the value.</typeparam>
    public abstract class SerializableObjectValueCluster<TKey_1, TKey_2, TValue> : ValueCluster<TKey_1, TKey_2, TValue>, ISerializableObject where TValue : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class.
        /// </summary>
        public SerializableObjectValueCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class using the specified collection of values.
        /// </summary>
        /// <param name="values">The collection of values to initialize the cluster with.</param>
        public SerializableObjectValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class from another serializable value cluster.
        /// </summary>
        /// <param name="serializableObjectValueCluster">The serializable value cluster to copy from.</param>
        public SerializableObjectValueCluster(SerializableObjectValueCluster<TKey_1, TKey_2, TValue>? serializableObjectValueCluster)
            : base(serializableObjectValueCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the current instance.</param>
        public SerializableObjectValueCluster(JsonObject? jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Type)]
        private string? FullTypeName => Query.FullTypeName(GetType());

        /// <summary>
        /// Creates a deep copy of the current serializable value cluster.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a deep copy of the current instance, or null.</returns>
        public virtual ISerializableObject? Clone()
        {
            JsonObject? jsonObject = ToJsonObject();
            if (jsonObject == null)
            {
                return null;
            }

            return Create.SerializableObject<ISerializableObject>(jsonObject);
        }

        /// <summary>
        /// Populates the current instance from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to populate the instance from.</param>
        /// <returns>True if the population was successful; otherwise, false.</returns>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the current instance into a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the current instance, or null.</returns>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson((ISerializableObject)this);
        }
    }
}