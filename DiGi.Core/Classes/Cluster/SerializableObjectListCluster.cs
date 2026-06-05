using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for clusters of serializable objects keyed by two keys.</summary>
    /// <typeparam name="TKey_1">The type of the first key.</typeparam>
    /// <typeparam name="TKey_2">The type of the second key.</typeparam>
    /// <typeparam name="TValue">The type of the values in the cluster.</typeparam>
    public abstract class SerializableObjectListCluster<TKey_1, TKey_2, TValue> : List<TKey_1, TKey_2, TValue>, ISerializableObject where TValue : ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class.
        /// </summary>
        public SerializableObjectListCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class using the specified collection of values.
        /// </summary>
        /// <param name="values">The collection of values to initialize the cluster with.</param>
        public SerializableObjectListCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class from another serializable list cluster.
        /// </summary>
        /// <param name="serializableObjectListCluster">The source serializable list cluster to copy from.</param>
        public SerializableObjectListCluster(SerializableObjectListCluster<TKey_1, TKey_2, TValue>? serializableObjectListCluster)
            : base(serializableObjectListCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the cluster from.</param>
        public SerializableObjectListCluster(JsonObject? jsonObject)
            : base()
        {
            FromJsonObject(jsonObject);
        }

        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Type)]
        private string? FullTypeName => Query.FullTypeName(GetType());

        /// <summary>
        /// Creates a deep copy of the current serializable value cluster.
        /// </summary>
        /// <returns>A new <see cref="ISerializableObject"/> that is a clone of the current instance, or null.</returns>
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