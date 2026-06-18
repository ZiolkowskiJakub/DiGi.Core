using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A wrapper that encapsulates a JsonObject, allowing it to be treated as a SerializableObject without full deserialization.
    /// </summary>
    public class SerializableObjectWrapper : SerializableObject
    {
        private readonly JsonObject? jsonObject;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectWrapper"/> class.
        /// </summary>
        public SerializableObjectWrapper()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectWrapper"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to wrap.</param>
        public SerializableObjectWrapper(JsonObject? jsonObject)
        {
            this.jsonObject = jsonObject?.DeepClone() as JsonObject;
        }

        /// <summary>
        /// Explicitly converts a <see cref="SerializableObjectWrapper"/> to a <see cref="JsonObject"/>.
        /// </summary>
        /// <param name="serializableObjectWrapper">The <see cref="SerializableObjectWrapper"/> instance to convert.</param>
        /// <returns>A <see cref="JsonObject"/> representation of the wrapper, or null if the wrapper is null.</returns>
        public static explicit operator JsonObject?(SerializableObjectWrapper? serializableObjectWrapper)
        {
            return serializableObjectWrapper?.ToJsonObject();
        }

        /// <summary>
        /// Explicitly converts a <see cref="JsonObject"/> to a <see cref="SerializableObjectWrapper"/>.
        /// </summary>
        /// <param name="jsonObject">The <see cref="JsonObject"/> to convert.</param>
        /// <returns>A new <see cref="SerializableObjectWrapper"/> instance wrapping the provided <see cref="JsonObject"/>.</returns>
        public static explicit operator SerializableObjectWrapper?(JsonObject? jsonObject)
        {
            return new SerializableObjectWrapper(jsonObject);
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new SerializableObjectWrapper(jsonObject);
        }

        /// <summary>
        /// Populates the object's properties from the specified JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JsonObject to populate from.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            jsonObject = jsonObject?.DeepClone() as JsonObject;
            return jsonObject != null;
        }

        /// <summary>
        /// Converts the current instance into a JsonObject.
        /// </summary>
        /// <returns>A JsonObject representation of the instance.</returns>
        public override JsonObject? ToJsonObject()
        {
            return jsonObject?.DeepClone() as JsonObject;
        }

        /// <summary>
        /// Attempts to retrieve the full type name from the wrapped JsonObject.
        /// </summary>
        /// <param name="fullTypeName">When this method returns, contains the full type name if successful; otherwise, null.</param>
        /// <returns>True if the full type name was successfully retrieved; otherwise, false.</returns>
        public bool TryGetFullTypeName(out string? fullTypeName)
        {
            fullTypeName = Query.FullTypeName(jsonObject);
            return !string.IsNullOrWhiteSpace(fullTypeName);
        }
    }
}
