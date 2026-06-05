using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a reference to a specific property of an object identified by a GUID.
    /// </summary>
    public class GuidPropertyReference : UniquePropertyReference<GuidReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidPropertyReference"/> class with the specified reference and property name.
        /// </summary>
        /// <param name="reference">The reference to use.</param>
        /// <param name="propertyName">The name of the property.</param>
        public GuidPropertyReference(GuidReference reference, string propertyName)
            : base(reference, propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidPropertyReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GuidPropertyReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidPropertyReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="guidPropertyReference">The existing reference to copy.</param>
        public GuidPropertyReference(GuidPropertyReference guidPropertyReference)
            : base(guidPropertyReference)
        {
        }

        /// <summary>
        /// Creates a shallow copy of the current object.
        /// </summary>
        /// <returns>A shallow copy of the current object.</returns>
        public override ISerializableObject Clone()
        {
            return new GuidPropertyReference(this);
        }
    }
}