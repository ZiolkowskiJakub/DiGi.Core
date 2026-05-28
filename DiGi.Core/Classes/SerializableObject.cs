using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Abstract base class that provides core JSON serialization and deserialization capabilities to an Object.
    /// </summary>
    public abstract class SerializableObject : Object, ISerializableObject
    {
        /// <summary>
        /// Initializes a new instance of the SerializableObject class.
        /// </summary>
        public SerializableObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObject class by copying another serializable object.
        /// </summary>
        /// <param name="serializableObject">The source object to copy from.</param>
        public SerializableObject(SerializableObject? serializableObject)
            : base()
        {
            if (serializableObject != null)
            {
            }
        }

        /// <summary>
        /// Initializes a new instance of the SerializableObject class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serializable data.</param>
        public SerializableObject(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Gets the full type name of the object for serialization purposes.
        /// </summary>
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Type)]
        private string? FullTypeName => Query.FullTypeName(GetType());

        /// <summary>
        /// Explicitly converts a SerializableObject instance to a JsonObject.
        /// </summary>
        public static explicit operator JsonObject?(SerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return null;
            }

            return serializableObject.ToJsonObject();
        }

        /// <summary>
        /// Explicitly converts a JsonObject to a SerializableObject instance.
        /// </summary>
        public static explicit operator SerializableObject?(JsonObject? jsonObject)
        {
            return Create.SerializableObject<SerializableObject>(jsonObject);
        }

        /// <summary>
        /// Creates a deep copy of the serializable object by serializing and deserializing it.
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
        /// Populates the object's properties from a JsonObject.
        /// </summary>
        public virtual bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Converts the object into a JsonObject for serialization.
        /// </summary>
        public virtual JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }
    }
}