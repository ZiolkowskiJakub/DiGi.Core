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

        public GuidResult(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public GuidResult(GuidResult guidResult)
            : base(guidResult)
        {

        }
    }

    public abstract class GuidResult<T> : GuidResult, IUniqueResult<T> where T: IUniqueObject
    {
        public GuidResult()
            : base()
        {

        }

        public GuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public GuidResult(GuidResult<T> guidResult)
            : base(guidResult)
        {

        }
    }
}
