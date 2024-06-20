using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class UniqueParametrizedObject : ParametrizedObject, IUniqueObject
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid = Guid.NewGuid();

        public UniqueParametrizedObject()
            : base()
        {

        }

        public UniqueParametrizedObject(Guid guid)
            : base()
        {
            this.guid = guid;
        }

        public UniqueParametrizedObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniqueParametrizedObject(IEnumerable<Parameter> parameters)
            : base(parameters)
        {

        }

        public UniqueParametrizedObject(ParameterGroups parameterGroups)
            : base(parameterGroups)
        {

        }

        public UniqueParametrizedObject(UniqueParametrizedObject uniqueParametrizedObject)
            : base(uniqueParametrizedObject)
        {
            guid = uniqueParametrizedObject != null ? uniqueParametrizedObject.guid : Guid.NewGuid();
        }

        [JsonIgnore]
        public Guid Guid
        {
            get
            {
                return guid;
            }
        }
    }
}
