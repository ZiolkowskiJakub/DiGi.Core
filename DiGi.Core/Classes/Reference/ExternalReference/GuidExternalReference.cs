using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an external reference identified by a GUID.
    /// </summary>
    public sealed class GuidExternalReference : UniqueExternalReference<GuidReference>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class with a source and a GUID object.
        /// </summary>
        public GuidExternalReference(string? source, IGuidObject? guidObject)
            : base(source, guidObject == null ? null : new GuidReference(guidObject))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class with a source and a GUID reference.
        /// </summary>
        public GuidExternalReference(string source, GuidReference reference)
            : base(source, reference)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class from a JSON object.
        /// </summary>
        public GuidExternalReference(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidExternalReference"/> class by copying an existing instance.
        /// </summary>
        public GuidExternalReference(GuidExternalReference guidExternalReference)
            : base(guidExternalReference)
        {
        }
    }
}