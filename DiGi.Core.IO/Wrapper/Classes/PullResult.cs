using DiGi.Core.Enums;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class PullResult
    {
        public ResultType ResultType { get; } = ResultType.Undefined;
        public IEnumerable<WrapperItem> WrapperItems { get; } = null;

        public PullResult(ResultType resultType)
        {
            ResultType = resultType;
        }

        public PullResult(ResultType resultType, IEnumerable<WrapperItem> wrapperItems)
        {
            ResultType = resultType;
            WrapperItems = wrapperItems; 
        }
    }
}
