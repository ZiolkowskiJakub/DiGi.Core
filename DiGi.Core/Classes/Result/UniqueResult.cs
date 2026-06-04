using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result containing a unique identifier.
    /// </summary>
    public abstract class UniqueResult : UniqueObject, IUniqueResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class.
        /// </summary>
        public UniqueResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class from the specified JSON object.
        /// </summary>
        public UniqueResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class from another unique result.
        /// </summary>
        public UniqueResult(UniqueResult? uniqueResult)
            : base(uniqueResult)
        {
        }
    }

    /// <summary>
    /// Represents a result containing a unique identifier.
    /// </summary>
    public abstract class UniqueResult<T> : UniqueResult, IResult<T> where T : IUniqueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class.
        /// </summary>
        public UniqueResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class from the specified JSON object.
        /// </summary>
        public UniqueResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueResult"/> class from a generic unique result.
        /// </summary>
        public UniqueResult(UniqueResult<T>? uniqueResult)
            : base(uniqueResult)
        {
        }
    }
}