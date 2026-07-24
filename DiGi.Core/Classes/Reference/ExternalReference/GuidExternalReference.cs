using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an external reference identified by a GUID.
    /// </summary>
    /// <example>
    /// Renders and parses (via <see cref="Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// source, then the nested GUID reference:
    /// <code>GuidExternal::Revit::(Guid::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::0f8fad5bd9cb469fa16570867728950e)</code>
    /// </example>
    public sealed class GuidExternalReference : UniqueExternalReference<GuidReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class with a source and a GUID object.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="guidObject">The GUID object.</param>
        public GuidExternalReference(string? source, IGuidObject? guidObject)
            : base(source, guidObject == null ? null : new GuidReference(guidObject))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class with a source and a GUID reference.
        /// </summary>
        /// <param name="source">The source string.</param>
        /// <param name="reference">The GUID reference.</param>
        public GuidExternalReference(string? source, GuidReference? reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GuidExternalReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class by copying an existing instance.
        /// </summary>
        /// <param name="guidExternalReference">The existing instance to copy.</param>
        public GuidExternalReference(GuidExternalReference? guidExternalReference)
            : base(guidExternalReference)
        {
        }
    }
}