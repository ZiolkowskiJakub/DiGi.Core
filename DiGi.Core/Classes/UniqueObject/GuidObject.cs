using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for objects identified by a unique GUID.
    /// </summary>
    public abstract class GuidObject : UniqueObject, IGuidObject
    {
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Guid)]
        private Guid guid;

        [JsonIgnore]
        private string? uniqueId = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidObject"/> class.
        /// </summary>
        public GuidObject()
            : base()
        {
            guid = Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidObject"/> class with the specified GUID.
        /// </summary>
        /// <param name="guid">The GUID to assign to the new instance.</param>
        public GuidObject(Guid guid)
            : base()
        {
            this.guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidObject"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the instance from.</param>
        public GuidObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
            if (jsonObject is not null)
            {
                if (!jsonObject.ContainsKey(Constants.Serialization.PropertyName.Guid))
                {
                    guid = Guid.NewGuid();
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidObject"/> class by copying another GuidObject.
        /// </summary>
        /// <param name="guidObject">The GuidObject to copy from.</param>
        public GuidObject(GuidObject? guidObject)
            : base(guidObject)
        {
            if (guidObject is not null)
            {
                guid = guidObject.guid;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidObject"/> class with a specified GUID and an existing object.
        /// </summary>
        /// <param name="guid">The GUID to assign to the new instance.</param>
        /// <param name="guidObject">The existing GuidObject used for initialization.</param>
        public GuidObject(Guid guid, GuidObject? guidObject)
            : base(guidObject)
        {
            this.guid = guid;
        }

        /// <summary>
        /// Creates a duplicate of the current object, optionally using a new GUID.
        /// </summary>
        /// <param name="guid">The optional GUID to assign to the duplicated object.</param>
        /// <returns>A duplicate of the current object as an <see cref="IGuidObject"/>.</returns>
        public virtual IGuidObject? Duplicate(Guid? guid = null)
        {
            GuidObject? result = Query.Clone(this);

            result?.guid = guid == null ? Guid.NewGuid() : guid.Value;

            return result;
        }

        /// <summary>
        /// Gets or sets the unique identifier for the object.
        /// </summary>
        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        /// <summary>
        /// Gets or sets the unique identification string for this object.
        /// </summary>
        [JsonIgnore]
        public override string? UniqueId
        {
            get
            {
                if (uniqueId == null)
                {
                    uniqueId = guid.ToString("N");
                }

                return uniqueId;
            }
        }
    }
}