using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>Base class for serializable objects identified by a unique string ID.</summary>
    public abstract class UniqueIdObject : UniqueObject, IUniqueIdObject
    {
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.UniqueId)]
        private readonly string? uniqueId;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdObject"/> class.
        /// </summary>
        public UniqueIdObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdObject"/> class with the specified unique ID.
        /// </summary>
        /// <param name="uniqueId">The unique identifier string.</param>
        public UniqueIdObject(string? uniqueId)
            : base()
        {
            this.uniqueId = uniqueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdObject"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public UniqueIdObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdObject"/> class by copying another UniqueIdObject.
        /// </summary>
        /// <param name="uniqueIdObject">The source UniqueIdObject to copy from.</param>
        public UniqueIdObject(UniqueIdObject? uniqueIdObject)
            : base(uniqueIdObject)
        {
            if (uniqueIdObject != null)
            {
                uniqueId = uniqueIdObject.uniqueId;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueIdObject"/> class with a specified unique ID and GuidObject.
        /// </summary>
        /// <param name="uniqueId">The unique identifier string.</param>
        /// <param name="guidObject">The associated GUID object, or null.</param>
        public UniqueIdObject(string uniqueId, GuidObject? guidObject)
            : base(guidObject)
        {
            this.uniqueId = uniqueId;
        }

        /// <summary>
        /// Gets or sets the unique identification string for this object.
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}