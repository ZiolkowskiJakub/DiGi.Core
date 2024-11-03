using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Enums;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public sealed class WrapperItem : IWrapperObject
    {
        public UniqueReference UniqueReference { get; }
        public JsonNode JsonNode { get; }
        public string Checksum { get; }

        public WrapperItem(UniqueReference uniqueReference, JsonNode jsonNode, string checksum)
        {
            UniqueReference = uniqueReference;
            JsonNode = jsonNode;
            Checksum = checksum;
        }
    }
}
