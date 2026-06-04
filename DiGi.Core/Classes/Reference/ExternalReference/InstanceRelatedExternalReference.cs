using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an abstract base class for external references related to a specific instance.
    /// </summary>
    public abstract class InstanceRelatedExternalReference<TInstanceRelatedSerializableReference> : ExternalReference<TInstanceRelatedSerializableReference> where TInstanceRelatedSerializableReference : IInstanceRelatedSerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class with the specified source and reference.
        /// </summary>
        public InstanceRelatedExternalReference(string? source, TInstanceRelatedSerializableReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class from the specified JSON object.
        /// </summary>
        public InstanceRelatedExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class by copying an existing generic reference.
        /// </summary>
        public InstanceRelatedExternalReference(InstanceRelatedExternalReference<TInstanceRelatedSerializableReference>? externalReference)
        : base(externalReference)
        {
        }
    }

    /// <summary>
    /// Represents a sealed implementation of an external reference related to a specific instance.
    /// </summary>
    public sealed class InstanceRelatedExternalReference : InstanceRelatedExternalReference<IInstanceRelatedSerializableReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class with the specified source and interface-based reference.
        /// </summary>
        public InstanceRelatedExternalReference(string? source, IInstanceRelatedSerializableReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class from the specified JSON object.
        /// </summary>
        public InstanceRelatedExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class by copying an existing reference.
        /// </summary>
        public InstanceRelatedExternalReference(InstanceRelatedExternalReference? externalReference)
        : base(externalReference)
        {
        }
    }
}