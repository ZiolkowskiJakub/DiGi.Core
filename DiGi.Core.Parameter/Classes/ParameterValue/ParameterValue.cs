using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Enums;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public abstract class ParameterValue : Attribute, ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Nullable")]
        private readonly bool nullable = true;

        public ParameterValue()
        {

        }

        public ParameterValue(bool nullable)
        {
            this.nullable = nullable;
        }

        public ParameterValue(ParameterValue? parameterValue)
        {
            if (parameterValue != null)
            {
                nullable = parameterValue.nullable;
            }
        }

        public ParameterValue(JsonObject? jsonObject)
        {
            FromJsonObject(jsonObject);
        }

        [JsonIgnore]
        public abstract ParameterType ParameterType { get; }

        public abstract ISerializableObject? Clone();

        public bool FromJsonObject(JsonObject? jsonObject)
        {
            return FromJsonObject(jsonObject);
        }

        public virtual bool IsValid(object? value)
        {
            if (value == null)
            {
                return nullable;
            }

            return Query.IsValid(ParameterType, value);
        }

        public JsonObject? ToJsonObject()
        {
            return Convert.ToJson(this);
        }

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
