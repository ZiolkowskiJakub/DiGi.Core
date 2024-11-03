using DiGi.Core.Classes;
using DiGi.Core.Enums;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class PushResult
    {
        public ResultType ResultType { get; } = ResultType.Undefined;
        public HashSet<UniqueReference> UniqueReferences { get; } = null;

        public PushResult(ResultType resultType)
        {
            ResultType = resultType;
        }

        public PushResult(ResultType resultType, HashSet<UniqueReference> uniqueReferences)
        {
            ResultType = resultType;
            UniqueReferences = uniqueReferences;
        }
    }
}
