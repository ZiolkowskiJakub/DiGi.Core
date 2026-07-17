using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an abstract base class for external references related to a specific instance.
    /// </summary>
    /// <typeparam name="TInstanceRelatedSerializableReference">The type of the serializable reference related to the instance.</typeparam>
    public abstract class InstanceRelatedExternalReference<TInstanceRelatedSerializableReference> : ExternalReference<TInstanceRelatedSerializableReference> where TInstanceRelatedSerializableReference : IInstanceRelatedSerializableReference
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class with the specified source and reference.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="reference">The related serializable reference.</param>
        public InstanceRelatedExternalReference(string? source, TInstanceRelatedSerializableReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public InstanceRelatedExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class by copying an existing generic reference.
        /// </summary>
        /// <param name="externalReference">The existing generic reference to copy.</param>
        public InstanceRelatedExternalReference(InstanceRelatedExternalReference<TInstanceRelatedSerializableReference>? externalReference)
        : base(externalReference)
        {
        }
    }

    /// <summary>
    /// Represents a sealed implementation of an external reference related to a specific instance.
    /// </summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// source, then the nested instance-related reference:
    /// <code>InstanceExternal::Revit::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e)</code>
    /// </example>
    public sealed class InstanceRelatedExternalReference : InstanceRelatedExternalReference<IInstanceRelatedSerializableReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class with the specified source and interface-based reference.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="reference">The interface-based reference.</param>
        public InstanceRelatedExternalReference(string? source, IInstanceRelatedSerializableReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public InstanceRelatedExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceRelatedExternalReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="externalReference">The existing reference to copy.</param>
        public InstanceRelatedExternalReference(InstanceRelatedExternalReference? externalReference)
        : base(externalReference)
        {
        }
    }
}