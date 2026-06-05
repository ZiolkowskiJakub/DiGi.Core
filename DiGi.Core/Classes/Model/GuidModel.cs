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
        /// <param name="guid">The GUID value to initialize the model with.</param>
        public GuidModel(System.Guid guid)
            : base(guid)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class by copying another instance.
        /// </summary>
        /// <param name="guidModel">The GuidModel instance to copy from.</param>
        public GuidModel(GuidModel? guidModel)
            : base(guidModel)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidModel"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the model from.</param>
        public GuidModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}