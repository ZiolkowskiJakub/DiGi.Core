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
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from another GUID result.
        /// </summary>
        /// <param name="guidResult">The GUID result to initialize from.</param>
        public GuidResult(GuidResult? guidResult)
            : base(guidResult)
        {
        }
    }

    /// <summary>
    /// Represents a result containing a GUID.
    /// </summary>
    /// <typeparam name="TUniqueObject">The type of the unique object associated with the GUID result.</typeparam>
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
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public GuidResult(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidResult"/> class from a generic GUID result.
        /// </summary>
        /// <param name="guidResult">The generic GUID result to initialize from.</param>
        public GuidResult(GuidResult<TUniqueObject>? guidResult)
            : base(guidResult)
        {
        }
    }
}