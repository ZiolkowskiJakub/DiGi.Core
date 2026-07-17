using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an external reference related to a type rather than a specific instance.
    /// </summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// source, then the nested type-related reference:
    /// <code>TypeExternal::Revit::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)</code>
    /// </example>
    public sealed class TypeRelatedExternalReference : ExternalReference<ITypeRelatedSerializableReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeRelatedExternalReference"/> class with the specified source and reference.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="reference">The serializable reference to use.</param>
        public TypeRelatedExternalReference(string? source, ITypeRelatedSerializableReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeRelatedExternalReference"/> class from the specified JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the instance from.</param>
        public TypeRelatedExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TypeRelatedExternalReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="externalReference">The external reference to copy.</param>
        public TypeRelatedExternalReference(TypeRelatedExternalReference? externalReference)
        : base(externalReference)
        {
        }
    }
}