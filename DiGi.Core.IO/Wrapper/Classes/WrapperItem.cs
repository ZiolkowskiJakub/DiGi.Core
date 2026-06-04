using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    /// <summary>
    /// Represents a wrapper item containing a unique reference and associated data.
    /// </summary>
    public sealed class WrapperItem : IWrapperObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WrapperItem"/> class with a specified unique reference.
        /// </summary>
        public WrapperItem(UniqueReference? uniqueReference)
        {
            UniqueReference = uniqueReference;
            JsonNode = null;
            Checksum = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WrapperItem"/> class with a unique reference, JSON node, and checksum.
        /// </summary>
        public WrapperItem(UniqueReference? uniqueReference, JsonNode? jsonNode, string? checksum)
        {
            UniqueReference = uniqueReference;
            JsonNode = jsonNode;
            Checksum = checksum;
        }

        /// <summary>
        /// Gets or sets the checksum associated with the wrapper item.
        /// </summary>
        public string? Checksum { get; set; }

        /// <summary>
        /// Gets or sets the JSON node data associated with the wrapper item.
        /// </summary>
        public JsonNode? JsonNode { get; set; }

        /// <summary>
        /// Gets or sets the unique reference for the wrapper item.
        /// </summary>
        public UniqueReference? UniqueReference { get; }
    }
}