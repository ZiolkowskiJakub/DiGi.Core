using DiGi.Core.Parameter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public abstract class ParametrizedGuidObject : ParametrizedObject, IParametrizedGuidObject
    {
        [JsonInclude, JsonPropertyName(Core.Constans.Serialization.PropertyName.Guid)]
        private Guid guid = Guid.NewGuid();

        public ParametrizedGuidObject()
            : base()
        {

        }

        public ParametrizedGuidObject(Guid guid)
            : base()
        {
            this.guid = guid;
        }

        public ParametrizedGuidObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ParametrizedGuidObject(IEnumerable<Parameter> parameters)
            : base(parameters)
        {

        }

        public ParametrizedGuidObject(ParameterGroups parameterGroups)
            : base(parameterGroups)
        {

        }

        public ParametrizedGuidObject(ParametrizedGuidObject parametrizedGuidObject)
            : base(parametrizedGuidObject)
        {
            guid = parametrizedGuidObject != null ? parametrizedGuidObject.guid : Guid.NewGuid();
        }

        public ParametrizedGuidObject(Guid guid, ParametrizedGuidObject parametrizedGuidObject)
            : base(parametrizedGuidObject)
        {
            this.guid = guid;
        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }

        [JsonIgnore]
        public string UniqueId
        {
            get
            {
                return Core.Query.UniqueId(guid);
            }
        }
    }
}
