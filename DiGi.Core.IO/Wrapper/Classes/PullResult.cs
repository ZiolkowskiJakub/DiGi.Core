using DiGi.Core.Enums;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class PullResult
    {
        public ResultType ResultType { get; } = ResultType.Undefined;
        public IEnumerable<JsonNode> jsonNodes { get; } = null;

        public PullResult(ResultType resultType)
        {
            ResultType = resultType;
        }
    }
}
