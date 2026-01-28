using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperItem : IWrapperObject
    {
        public WrapperItem(UniqueReference? uniqueReference)
        {
            UniqueReference = uniqueReference;
            JsonNode = null;
            Checksum = null;
        }

        public WrapperItem(UniqueReference? uniqueReference, JsonNode? jsonNode, string? checksum)
        {
            UniqueReference = uniqueReference;
            JsonNode = jsonNode;
            Checksum = checksum;
        }

        public string? Checksum { get; set; }

        public JsonNode? JsonNode { get; set; }

        public UniqueReference? UniqueReference { get; }
    }
}