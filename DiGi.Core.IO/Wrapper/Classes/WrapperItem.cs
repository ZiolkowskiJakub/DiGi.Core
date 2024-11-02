using DiGi.Core.IO.Wrapper.Enums;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperItem : IWrapperObject
    {
        public string Refrence { get; }
        public JsonNode JsonNode { get; }
        public string Checksum { get; }

        public WrapperItem(string refrence, JsonNode jsonNode, string checksum)
        {
            Refrence = refrence;
            JsonNode = jsonNode;
            Checksum = checksum;
        }
    }
}
