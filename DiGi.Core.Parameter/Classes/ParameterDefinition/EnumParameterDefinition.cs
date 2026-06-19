using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Defines a parameter based on an enumeration type.
    /// </summary>
    public class EnumParameterDefinition : ComplexParameterDefinition
    {
        [JsonInclude, JsonPropertyName("Enum")]
        private Enum? @enum;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the parameter definition.</param>
        public EnumParameterDefinition(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class by copying an existing definition.
        /// </summary>
        /// <param name="enumParameterDefinition">The existing enum parameter definition to copy.</param>
        public EnumParameterDefinition(EnumParameterDefinition? enumParameterDefinition)
            : base(enumParameterDefinition)
        {
            if (enumParameterDefinition != null)
            {
                @enum = enumParameterDefinition.@enum;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class based on a specific enumeration value.
        /// </summary>
        /// <param name="enum">The enumeration value to use for initialization.</param>
        public EnumParameterDefinition(Enum? @enum)
        {
            this.@enum = @enum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumParameterDefinition"/> class.
        /// </summary>
        public EnumParameterDefinition()
            : base()
        {
        }

        /// <summary>
        /// Gets the access type for the enum parameter.
        /// </summary>
        public override AccessType AccessType
        {
            get
            {
                ParameterProperties? parameterProperties = Query.ParameterProperties(@enum);
                if (parameterProperties == null)
                {
                    return AccessType.ReadWrite;
                }

                return parameterProperties.AccessType;
            }
        }

        /// <summary>
        /// Gets the associated types for the enum parameter.
        /// </summary>
        public override AssociatedTypes? AssociatedTypes
        {
            get
            {
                return Query.AssociatedTypes(@enum?.GetType());
            }
        }

        /// <summary>
        /// Gets or sets the description of the enum parameter.
        /// </summary>
        public override string? Description
        {
            get
            {
                return Query.ParameterProperties(@enum)?.Description;
            }
        }

        /// <summary>
        /// Gets the group name to which the enum parameter belongs.
        /// </summary>
        public override string GroupName
        {
            get
            {
                string? result = Query.ParameterProperties(@enum)?.GroupName;

                result ??= @enum?.GetType()?.Namespace;

                return result ?? Constants.Names.DefaultGroupName;
            }
        }

        /// <summary>
        /// Gets or sets the name of the enum parameter.
        /// </summary>
        public override string? Name
        {
            get
            {
                return Query.ParameterProperties(@enum)?.Name;
            }
        }

        /// <summary>
        /// Gets or sets the current value of the enum parameter.
        /// </summary>
        public override ParameterValue? ParameterValue
        {
            get
            {
                return Query.ParameterValue<ParameterValue>(@enum);
            }
        }

        /// <summary>
        /// Gets or sets the unique identifier for the enum parameter.
        /// </summary>
        public override string? UniqueId
        {
            get
            {
                return Query.ParameterProperties(@enum)?.UniqueId;
            }
        }

        /// <summary>
        /// Explicitly converts an <see cref="EnumParameterDefinition"/> to its underlying <see cref="Enum"/> value.
        /// </summary>
        /// <param name="enumParameterDefinition">The enum parameter definition to convert.</param>
        /// <returns>The <see cref="Enum"/> value associated with the definition, or <c>null</c> if the input is <c>null</c>.</returns>
        public static explicit operator Enum?(EnumParameterDefinition? enumParameterDefinition)
        {
            if (enumParameterDefinition == null)
            {
                return null;
            }

            return enumParameterDefinition.@enum;
        }

        /// <summary>
        /// Explicitly converts an <see cref="Enum"/> to an <see cref="EnumParameterDefinition"/>.
        /// </summary>
        /// <param name="enum">The enum value to convert.</param>
        /// <returns>An <see cref="EnumParameterDefinition"/> instance created from the provided enum, or <c>null</c> if the input is <c>null</c>.</returns>
        public static explicit operator EnumParameterDefinition?(Enum? @enum)
        {
            if (@enum == null)
            {
                return null;
            }

            return new EnumParameterDefinition(@enum);
        }

        /// <summary>
        /// Creates a copy of the current enum parameter definition.
        /// </summary>
        /// <returns>A clone of the current enum parameter definition as an <see cref="ISerializableObject"/>.</returns>
        public override ISerializableObject? Clone()
        {
            return new EnumParameterDefinition(this);
        }

        /// <summary>
        /// Populates the enum parameter definition from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to populate the definition from.</param>
        /// <returns><c>true</c> if the population was successful; otherwise, <c>false</c>.</returns>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject == null)
            {
                return false;
            }

            if (jsonObject.ContainsKey("Enum"))
            {
                Core.Query.TryGetEnum(jsonObject["Enum"]?.GetValue<string>(), out @enum);
            }

            return true;
        }

        /// <summary>
        /// Converts the enum parameter definition to a JSON object.
        /// </summary>
        /// <returns>A <see cref="JsonObject"/> representation of the enum parameter definition.</returns>
        public override JsonObject ToJsonObject()
        {
            JsonObject result = new()
            {
                { Core.Constants.Serialization.PropertyName.Type, Core.Query.FullTypeName(GetType()) },
                { "Enum", Core.Query.FullName(@enum) }
            };

            return result;
        }
    }
}