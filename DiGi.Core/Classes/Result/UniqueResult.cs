using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class UniqueResult : UniqueObject, IUniqueResult
    {
        public UniqueResult()
            : base()
        {

        }

        public UniqueResult(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueResult(UniqueResult uniqueResult)
            : base(uniqueResult)
        {

        }
    }

    public abstract class UniqueResult<T> : UniqueResult, IResult<T> where T: IUniqueObject
    {
        public UniqueResult()
            : base()
        {

        }

        public UniqueResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniqueResult(UniqueResult<T> uniqueResult)
            : base(uniqueResult)
        {

        }
    }
}
