using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class Result : SerializableObject, IResult
    {
        public Result()
            : base()
        {

        }

        public Result(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Result(Result result)
            : base()
        {

        }
    }

    public abstract class Result<T> : Result, IResult<T> where T: ISerializableObject
    {
        public Result()
            : base()
        {

        }

        public Result(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Result(Result<T> result)
            : base(result)
        {

        }
    }
}
