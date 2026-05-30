using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Represents a parameter definition defined externally with explicit metadata.</summary>
    public class ExternalParameterDefinition : ComplexParameterDefinition, INamedObject
    {
        [JsonInclude, JsonPropertyName("Guid")]
        private Guid guid;

        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        [JsonInclude, JsonPropertyName("Description")]
        private readonly string? description;

        [JsonInclude, JsonPropertyName("AccessType")]
        private readonly AccessType accessType;

        [JsonInclude, JsonPropertyName("ParameterValue")]
        private readonly ParameterValue? parameterValue;

        [JsonInclude, JsonPropertyName("AssociatedTypes")]
        private readonly AssociatedTypes? associatedTypes;

        [JsonInclude, JsonPropertyName("GroupName")]
        private readonly string? groupName;

        /// <summary>Creates a new instance of the ExternalParameterDefinition class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object containing the external parameter definition data.</param>
        public ExternalParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a new instance of the ExternalParameterDefinition class by copying another ExternalParameterDefinition.</summary>
        /// <param name="externalParameterDefinition">The ExternalParameterDefinition to copy.</param>
        public ExternalParameterDefinition(ExternalParameterDefinition? externalParameterDefinition)
            : base(externalParameterDefinition)
        {
            if (externalParameterDefinition != null)
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

        /// <summary>Creates a new instance of the ExternalParameterDefinition class with the specified parameters.</summary>
        /// <param name="guid">The unique identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="description">The description.</param>
        /// <param name="accessType">The access type.</param>
        /// <param name="parameterValue">The parameter value.</param>
        /// <param name="associatedTypes">The associated types.</param>
        /// <param name="groupName">The group name.</param>
        public ExternalParameterDefinition(Guid guid, string? name, string? description, AccessType accessType, ParameterValue? parameterValue, AssociatedTypes associatedTypes, string? groupName)
        {
            this.guid = guid;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
            this.parameterValue = parameterValue?.Clone<ParameterValue>();
            this.associatedTypes = associatedTypes?.Clone<AssociatedTypes>();
            this.groupName = groupName;
        }

        /// <summary>Creates a new instance of the ExternalParameterDefinition class.</summary>
        public ExternalParameterDefinition()
            : base()
        {
        }

        /// <summary>Gets the unique identifier of the external parameter definition.</summary>
        [JsonIgnore]
        public override string UniqueId
        {
            get
            {
                return guid.ToString();
            }
        }

        /// <summary>Gets the name of the external parameter definition.</summary>
        [JsonIgnore]
        public override string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>Gets the description of the external parameter definition.</summary>
        [JsonIgnore]
        public override string? Description
        {
            get
            {
                return description;
            }
        }

        /// <summary>Gets the parameter value of the external parameter definition.</summary>
        [JsonIgnore]
        public override ParameterValue? ParameterValue
        {
            get
            {
                return parameterValue?.Clone<ParameterValue>();
            }
        }

        /// <summary>Gets the associated types of the external parameter definition.</summary>
        [JsonIgnore]
        public override AssociatedTypes? AssociatedTypes
        {
            get
            {
                return associatedTypes?.Clone<AssociatedTypes>();
            }
        }

        /// <summary>Gets the access type of the external parameter definition.</summary>
        [JsonIgnore]
        public override AccessType AccessType
        {
            get
            {
                return accessType;
            }
        }

        /// <summary>Gets the group name of the external parameter definition.</summary>
        [JsonIgnore]
        public override string? GroupName
        {
            get
            {
                return groupName;
            }
        }

        /// <summary>Determines whether the specified value is valid for this external parameter definition.</summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid, false otherwise.</returns>
        public override bool IsValid(object? value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            ParameterValue? parameterValue = ParameterValue;
            if (parameterValue != null)
            {
                result = parameterValue.IsValid(value);
            }

            return result;
        }
    }
}