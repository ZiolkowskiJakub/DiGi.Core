using DiGi.Core.Parameter.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public abstract class ParametrizedUniqueIdObject : ParametrizedObject, IParametrizedUniqueIdObject
    {
        [JsonInclude, JsonPropertyName(Core.Constants.Serialization.PropertyName.UniqueId)]
        private readonly string? uniqueId;

        public ParametrizedUniqueIdObject()
            : base()
        {
        }

        public ParametrizedUniqueIdObject(string? uniqueId)
            : base()
        {
            this.uniqueId = uniqueId;
        }

        public ParametrizedUniqueIdObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public ParametrizedUniqueIdObject(IEnumerable<Parameter>? parameters)
            : base(parameters)
        {
        }

        public ParametrizedUniqueIdObject(ParameterGroupCollection? parameterGroupCollection)
            : base(parameterGroupCollection)
        {
        }

        public ParametrizedUniqueIdObject(ParametrizedUniqueIdObject? parametrizedUniqueIdObject)
            : base(parametrizedUniqueIdObject)
        {
            uniqueId = parametrizedUniqueIdObject?.uniqueId;
        }

        public ParametrizedUniqueIdObject(string? uniqueId, ParametrizedUniqueIdObject? parametrizedUniqueIdObject)
            : base(parametrizedUniqueIdObject)
        {
            this.uniqueId = uniqueId;
        }

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