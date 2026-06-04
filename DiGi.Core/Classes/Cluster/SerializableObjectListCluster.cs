using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for clusters of serializable objects keyed by two keys.</summary>
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
        public SerializableObjectListCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class from another serializable list cluster.
        /// </summary>
        public SerializableObjectListCluster(SerializableObjectListCluster<TKey_1, TKey_2, TValue>? serializableObjectListCluster)
            : base(serializableObjectListCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObjectListCluster class from a JSON object.
        /// </summary>
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