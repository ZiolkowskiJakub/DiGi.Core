using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides a base implementation for models identified by a unique GUID.
    /// </summary>
    public abstract class GuidModel : GuidObject, IGuidModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class.
        /// </summary>
        public GuidModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class with a specified GUID.
        /// </summary>
        public GuidModel(System.Guid guid)
            : base(guid)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class by copying another instance.
        /// </summary>
        public GuidModel(GuidModel? guidModel)
            : base(guidModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class from a JSON object.
        /// </summary>
        public GuidModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}