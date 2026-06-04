using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a result containing a GUID.
    /// </summary>
    public abstract class GuidResult : GuidObject, IGuidResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class.
        /// </summary>
        public GuidResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from the specified JSON object.
        /// </summary>
        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from another GUID result.
        /// </summary>
        public GuidResult(GuidResult? guidResult)
            : base(guidResult)
        {
        }
    }

    /// <summary>
    /// Represents a result containing a GUID.
    /// </summary>
    public abstract class GuidResult<TUniqueObject> : GuidResult, IUniqueResult<TUniqueObject> where TUniqueObject : IUniqueObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class.
        /// </summary>
        public GuidResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from the specified JSON object.
        /// </summary>
        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from a generic GUID result.
        /// </summary>
        public GuidResult(GuidResult<TUniqueObject>? guidResult)
            : base(guidResult)
        {
        }
    }
}