using DiGi.Core.Parameter.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents an abstract base class for objects that possess both a set of parameters and a unique identifier.
    /// </summary>
    public abstract class ParametrizedUniqueIdObject : ParametrizedObject, IParametrizedUniqueIdObject
    {
        [JsonInclude, JsonPropertyName(Core.Constants.Serialization.PropertyName.UniqueId)]
        private readonly string? uniqueId;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class.
        /// </summary>
        public ParametrizedUniqueIdObject()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class with a specified unique identifier.
        /// </summary>
        public ParametrizedUniqueIdObject(string? uniqueId)
            : base()
        {
            this.uniqueId = uniqueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class from a JSON object.
        /// </summary>
        public ParametrizedUniqueIdObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class using a collection of parameters.
        /// </summary>
        public ParametrizedUniqueIdObject(IEnumerable<Parameter>? parameters)
            : base(parameters)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class using a parameter group collection.
        /// </summary>
        public ParametrizedUniqueIdObject(ParameterGroupCollection? parameterGroupCollection)
            : base(parameterGroupCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class by copying another unique ID parametrized object.
        /// </summary>
        public ParametrizedUniqueIdObject(ParametrizedUniqueIdObject? parametrizedUniqueIdObject)
            : base(parametrizedUniqueIdObject)
        {
            uniqueId = parametrizedUniqueIdObject?.uniqueId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedUniqueIdObject"/> class with a specific ID and values from another object.
        /// </summary>
        public ParametrizedUniqueIdObject(string? uniqueId, ParametrizedUniqueIdObject? parametrizedUniqueIdObject)
            : base(parametrizedUniqueIdObject)
        {
            this.uniqueId = uniqueId;
        }

        /// <summary>
        /// Gets or sets the unique identifier for this object.
        /// </summary>
        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return uniqueId;
            }
        }
    }
}