using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Base class for all parameter value types.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public abstract class ParameterValue : Attribute, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Nullable")]
        private readonly bool nullable = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class.
        /// </summary>
        public ParameterValue()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class with specified nullability.
        /// </summary>
        public ParameterValue(bool nullable)
        {
            this.nullable = nullable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class by copying an existing instance.
        /// </summary>
        public ParameterValue(ParameterValue? parameterValue)
        {
            if (parameterValue != null)
            {
                nullable = parameterValue.nullable;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterValue"/> class from a JSON object.
        /// </summary>
        public ParameterValue(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        /// <summary>
        /// Gets the parameter type associated with this value.
        /// </summary>
        [JsonIgnore]
        public abstract ParameterType ParameterType { get; }

        /// <summary>
        /// Creates a clone of the current parameter value.
        /// </summary>
        public abstract ISerializableObject? Clone();

        /// <summary>
        /// Populates the parameter value from the provided JSON object.
        /// </summary>
        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return Modify.FromJsonObject(this, jsonObject);
        }

        /// <summary>
        /// Validates whether the given value is compatible with this parameter.
        /// </summary>
        public virtual bool IsValid(object? value)
        {
            if (value == null)
            {
                return nullable;
            }

            return Query.IsValid(ParameterType, value);
        }

        /// <summary>
        /// Converts the current parameter value to a JSON object.
        /// </summary>
        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }

        /// <summary>
        /// Attempts to convert an input value to the expected output type.
        /// </summary>
        public virtual bool TryConvert(object? value_In, out object? value_Out)
        {
            value_Out = default;

            if (value_In == null)
            {
                if (nullable)
                {
                    value_Out = null;
                    return true;
                }

                return false;
            }

            switch (ParameterType)
            {
                case ParameterType.Double:
                    if (value_In == null)
                    {
                        return false;
                    }

                    double @double;
                    if (!Core.Query.TryConvert(value_In, out @double))
                    {
                        return false;
                    }

                    value_Out = @double;
                    return true;

                case ParameterType.String:
                    string? @string;
                    if (!Core.Query.TryConvert(value_In, out @string))
                    {
                        return false;
                    }

                    value_Out = @string;
                    return true;

                case ParameterType.Boolean:
                    if (value_In == null)
                    {
                        return false;
                    }

                    bool @bool;
                    if (!Core.Query.TryConvert(value_In, out @bool))
                    {
                        return false;
                    }

                    value_Out = @bool;
                    return true;

                case ParameterType.Integer:
                    if (value_In == null)
                    {
                        return false;
                    }

                    int @int;
                    if (!Core.Query.TryConvert(value_In, out @int))
                    {
                        return false;
                    }

                    value_Out = @int;
                    return true;

                case ParameterType.Object:
                    if (value_In is not ISerializableObject)
                    {
                        return false;
                    }

                    value_Out = value_In;
                    return true;

                case ParameterType.Guid:
                    if (value_In == null)
                    {
                        return false;
                    }

                    int @guid;
                    if (!Core.Query.TryConvert(value_In, out @guid))
                    {
                        return false;
                    }

                    value_Out = @guid;
                    return true;

                case ParameterType.DateTime:
                    if (value_In == null)
                    {
                        return false;
                    }

                    int @dateTime;
                    if (!Core.Query.TryConvert(value_In, out @dateTime))
                    {
                        return false;
                    }

                    value_Out = @dateTime;
                    return true;

                case ParameterType.Color:
                    Core.Classes.Color? color;
                    if (!Core.Query.TryConvert(value_In, out color))
                    {
                        return false;
                    }

                    value_Out = color;
                    return true;

                case ParameterType.Undefined:
                    value_Out = value_In;
                    return true;
            }

            return false;
        }
    }
}