using DiGi.Core.Parameters.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameters
{
    public class ExternalParameterDefinition : ComplexParameterDefinition
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid;

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("Description")]
        private string description;

        [JsonInclude, JsonPropertyName("AccessType")]
        private AccessType accessType;

        [JsonInclude, JsonPropertyName("ParameterValue")]
        private ParameterValue parameterValue;

        [JsonInclude, JsonPropertyName("AssociatedTypes")]
        private AssociatedTypes associatedTypes;

        [JsonInclude, JsonPropertyName("GroupName")]
        private string groupName;

        public ExternalParameterDefinition(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalParameterDefinition(ExternalParameterDefinition externalParameterDefinition)
            : base(externalParameterDefinition)
        {
            if(externalParameterDefinition != null)
            {
                guid = externalParameterDefinition.guid;
                name = externalParameterDefinition.name;
                description = externalParameterDefinition.description;
                parameterValue = externalParameterDefinition.parameterValue?.Clone<ParameterValue>();
                associatedTypes = externalParameterDefinition.associatedTypes?.Clone<AssociatedTypes>();
                accessType = externalParameterDefinition.accessType;
                groupName = externalParameterDefinition.groupName;
            }
        }

        public ExternalParameterDefinition(Guid guid, string name, string description, AccessType accessType, ParameterValue parameterValue, AssociatedTypes associatedTypes, string groupName)
        {
            this.guid = guid;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
            this.parameterValue = parameterValue?.Clone<ParameterValue>();
            this.associatedTypes = associatedTypes?.Clone<AssociatedTypes>();
            this.groupName = groupName;
        }

        public ExternalParameterDefinition()
            : base()
        {

        }

        [JsonIgnore]
        public override string UniqueId
        {
            get
            {
                return guid.ToString();
            }
        }

        [JsonIgnore]
        public override string Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public override string Description 
        {
            get
            {
                return description;
            } 
        }

        [JsonIgnore]
        public override ParameterValue ParameterValue
        {
            get
            {
                return parameterValue?.Clone<ParameterValue>();
            }
        }

        [JsonIgnore]
        public override AssociatedTypes AssociatedTypes
        {
            get
            {
                return associatedTypes?.Clone<AssociatedTypes>();
            }
        }

        [JsonIgnore]
        public override AccessType AccessType 
        { 
            get
            {
                return accessType;
            }
        }

        [JsonIgnore]
        public override string GroupName
        {
            get
            {
                return groupName;
            }
        }

        public override bool IsValid(object value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            ParameterValue parameterValue = ParameterValue;
            if(parameterValue != null)
            {
                result = parameterValue.IsValid(value);
            }

            return result;
        }

    }
}
