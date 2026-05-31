using System.Text.Json.Nodes;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines the contract for objects that can be serialized to and from JSON.</summary>
    public interface ISerializableObject : ICloneableObject<ISerializableObject>
    {
        /// <summary>Serializes the object into a JsonObject.</summary>
        /// <returns>A JsonObject representation of the object, or null if serialization fails.</returns>
        JsonObject? ToJsonObject();

        /// <summary>Populates the object from a JsonObject.</summary>
        /// <param name="jsonObject">The JsonObject to read values from.</param>
        /// <returns>True if the object was successfully populated, false otherwise.</returns>
        bool FromJsonObject(JsonObject? jsonObject);
    }
}