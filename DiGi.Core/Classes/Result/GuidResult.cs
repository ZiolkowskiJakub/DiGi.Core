using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class GuidResult : GuidObject, IGuidResult
    {
        public GuidResult()
            : base()
        {
        }

        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public GuidResult(GuidResult? guidResult)
            : base(guidResult)
        {
        }
    }

    public abstract class GuidResult<TUniqueObject> : GuidResult, IUniqueResult<TUniqueObject> where TUniqueObject : IUniqueObject
    {
        public GuidResult()
            : base()
        {
        }

        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public GuidResult(GuidResult<TUniqueObject>? guidResult)
            : base(guidResult)
        {
        }
    }
}