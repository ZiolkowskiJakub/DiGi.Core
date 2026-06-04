using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a base abstract serializable value cluster.
    /// </summary>
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
        public SerializableObjectValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class from another serializable value cluster.
        /// </summary>
        public SerializableObjectValueCluster(SerializableObjectValueCluster<TKey_1, TKey_2, TValue>? serializableObjectValueCluster)
            : base(serializableObjectValueCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectValueCluster class from a JSON object.
        /// </summary>
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
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the current instance into a JSON object.
        /// </summary>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson((ISerializableObject)this);
        }
    }
}