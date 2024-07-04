using DiGi.Core.Parameter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class UniqueParametrizedObject : ParametrizedObject, IUniqueParametrizedObject
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

        public UniqueParametrizedObject(Guid guid, UniqueParametrizedObject uniqueParametrizedObject)
            : base(uniqueParametrizedObject)
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
    }
}
