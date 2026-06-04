using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Base class for objects that possess a unique GUID and a set of parameters.
    /// </summary>
    public abstract class ParametrizedGuidObject : ParametrizedObject, IParametrizedGuidObject
    {
        [JsonInclude, JsonPropertyName(Core.Constants.Serialization.PropertyName.Guid)]
        private Guid guid = Guid.NewGuid();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class.
        /// </summary>
        public ParametrizedGuidObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class with a specified GUID.
        /// </summary>
        public ParametrizedGuidObject(Guid guid)
            : base()
        {
            this.guid = guid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class from a JSON object.
        /// </summary>
        public ParametrizedGuidObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class with a collection of parameters.
        /// </summary>
        public ParametrizedGuidObject(IEnumerable<Parameter>? parameters)
            : base(parameters)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class with a specified group collection.
        /// </summary>
        public ParametrizedGuidObject(ParameterGroupCollection? parameterGroupCollection)
            : base(parameterGroupCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class by copying another object.
        /// </summary>
        public ParametrizedGuidObject(ParametrizedGuidObject? parametrizedGuidObject)
            : base(parametrizedGuidObject)
        {
            guid = parametrizedGuidObject != null ? parametrizedGuidObject.guid : Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedGuidObject"/> class with a specific GUID and data from another object.
        /// </summary>
        public ParametrizedGuidObject(Guid guid, ParametrizedGuidObject? parametrizedGuidObject)
            : base(parametrizedGuidObject)
        {
            this.guid = guid;
        }

        /// <summary>
        /// Gets the unique global identifier of the object.
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
        /// Gets or sets a unique string identifier for the object.
        /// </summary>
        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return Core.Query.UniqueId(guid);
            }
        }

        /// <summary>
        /// Creates a duplicate of the current object, optionally with a new GUID.
        /// </summary>
        public IGuidObject? Duplicate(Guid? guid = null)
        {
            ParametrizedGuidObject? parametrizedGuidObject = this.Clone<ParametrizedGuidObject>();
            if (parametrizedGuidObject != null)
            {
                parametrizedGuidObject.guid = guid == null ? Guid.NewGuid() : guid.Value;
            }

            return parametrizedGuidObject;
        }
    }
}