using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a parameter value that can hold an object of one or more specified types.
    /// </summary>
    public class ObjectParameterValue : ParameterValue
    {
        [JsonInclude, JsonPropertyName("Inheritance")]
        private readonly bool inheritance = true;

        [JsonInclude, JsonPropertyName("Types")]
        private readonly Type[]? types;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParameterValue"/> class.
        /// </summary>
        public ObjectParameterValue()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParameterValue"/> class with specified nullability, inheritance rules, and allowed types.
        /// </summary>
        public ObjectParameterValue(bool nullable, bool inheritance, params Type[] types)
            : base(nullable)
        {
            this.types = types?.ToArray();
            this.inheritance = inheritance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParameterValue"/> class from a JSON object.
        /// </summary>
        public ObjectParameterValue(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectParameterValue"/> class by copying an existing instance.
        /// </summary>
        public ObjectParameterValue(ObjectParameterValue? objectParameterValue)
            : base(objectParameterValue)
        {
            if (objectParameterValue != null)
            {
                inheritance = objectParameterValue.inheritance;
                types = objectParameterValue.types?.ToArray();
            }
        }

        /// <summary>
        /// Gets the parameter type associated with this string parameter value.
        /// </summary>
        [JsonIgnore]
        public override ParameterType ParameterType => ParameterType.Object;

        /// <summary>
        /// Creates a clone of the current string parameter value.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new ObjectParameterValue(this);
        }

        /// <summary>
        /// Determines whether the specified value is valid for this parameter.
        /// </summary>
        public override bool IsValid(object? value)
        {
            bool result = base.IsValid(value);
            if (!result)
            {
                return result;
            }

            Type? type = value?.GetType();
            if (type == null)
            {
                return true;
            }

            if (types == null || types.Length == 0)
            {
                return true;
            }

            foreach (Type type_Temp in types)
            {
                if (type_Temp == null)
                {
                    continue;
                }

                if (type.Equals(type_Temp))
                {
                    return true;
                }

                if (inheritance && type_Temp.IsAssignableFrom(type))
                {
                    return true;
                }
            }

            return result;
        }

        /// <summary>
        /// Attempts to convert the specified input value to a compatible output value.
        /// </summary>
        public override bool TryConvert(object? value_In, out object? value_Out)
        {
            if (!base.TryConvert(value_In, out value_Out))
            {
                return false;
            }

            return IsValid(value_Out);
        }
    }
}