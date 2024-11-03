using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperItem : IWrapperObject
    {
        public string Reference { get; }
        public JsonNode JsonNode { get; }
        public string Checksum { get; }

        public WrapperItem(string reference, JsonNode jsonNode, string checksum)
        {
            Reference = reference;
            JsonNode = jsonNode;
            Checksum = checksum;
        }
    }
}
