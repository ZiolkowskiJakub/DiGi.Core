using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>Represents a parameter with a definition and a value.</summary>
    public class Parameter : SerializableObject
    {
        [JsonInclude, JsonPropertyName("ParameterDefinition")]
        private readonly IParameterDefinition? parameterDefinition;

        [JsonInclude, JsonPropertyName("Value")]
        private object? value;

        /// <summary>Creates a new instance of the Parameter class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object containing the parameter data.</param>
        public Parameter(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a new instance of the Parameter class by copying another Parameter.</summary>
        /// <param name="parameter">The Parameter to copy.</param>
        public Parameter(Parameter? parameter)
            : this(parameter?.ParameterDefinition, parameter?.value)
        {
        }

        /// <summary>Creates a new instance of the Parameter class with the specified parameter definition and value.</summary>
        /// <param name="parameterDefinition">The parameter definition.</param>
        /// <param name="value">The parameter value.</param>
        internal Parameter(IParameterDefinition? parameterDefinition, object? value)
        {
            this.parameterDefinition = parameterDefinition?.Clone<IParameterDefinition>();
            this.value = value is ISerializableObject serializableObject ? serializableObject.Clone() : value;
        }

        /// <summary>Creates a new instance of the Parameter class with the specified parameter definition.</summary>
        /// <param name="parameterDefinition">The parameter definition.</param>
        internal Parameter(IParameterDefinition? parameterDefinition)
        {
            this.parameterDefinition = parameterDefinition?.Clone<IParameterDefinition>();
        }

        /// <summary>Gets the name of the parameter.</summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return parameterDefinition?.Name;
            }
        }

        /// <summary>Gets the parameter definition.</summary>
        [JsonIgnore]
        public IParameterDefinition? ParameterDefinition
        {
            get
            {
                return parameterDefinition?.Clone<IParameterDefinition>();
            }
        }

        /// <summary>Gets the type of the parameter.</summary>
        [JsonIgnore]
        public Enums.ParameterType ParameterType
        {
            get
            {
                return parameterDefinition == null ? Enums.ParameterType.Undefined : parameterDefinition.ParameterType;
            }
        }

        /// <summary>Gets the unique identifier of the parameter.</summary>
        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return parameterDefinition?.UniqueId;
            }
        }

        /// <summary>Gets the value of the parameter.</summary>
        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
        }

        /// <summary>Gets the value of the parameter, converted to the specified type.</summary>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The converted value, or default if conversion fails.</returns>
        public T? GetValue<T>(GetValueSettings? getValueSettings = null)
        {
            if (!TryGetValue(out T? result, getValueSettings))
            {
                return default;
            }

            return result;
        }

        /// <summary>Sets the value of the parameter.</summary>
        /// <param name="value">The value to set.</param>
        /// <param name="setValueSettings">Optional settings for setting the value.</param>
        /// <returns>True if the value was successfully set, false otherwise.</returns>
        public bool SetValue(object? value, SetValueSettings? setValueSettings = null)
        {
            if (parameterDefinition == null || parameterDefinition is SimpleParameterDefinition)
            {
                this.value = value is ISerializableObject @object ? @object.Clone() : value;
                return true;
            }

            if (parameterDefinition is not ComplexParameterDefinition complexParameterDefinition)
            {
                return false;
            }

            setValueSettings ??= new SetValueSettings();

            if (setValueSettings.CheckAccessType && !complexParameterDefinition.AccessType.Write())
            {
                return false;
            }

            ParameterValue? parameterValue = complexParameterDefinition.ParameterValue;
            if (parameterValue == null)
            {
                return false;
            }

            if (setValueSettings.TryConvert && !parameterValue.TryConvert(value, out value))
            {
                return false;
            }

            if (!parameterValue.IsValid(value))
            {
                return false;
            }

            this.value = value;
            return true;
        }

        /// <summary>Tries to get the value of the parameter, converted to the specified type.</summary>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <param name="value">The converted value, or default if conversion fails.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved, false otherwise.</returns>
        public bool TryGetValue<T>(out T? value, GetValueSettings? getValueSettings = null)
        {
            value = default;

            getValueSettings ??= new GetValueSettings();

            if (parameterDefinition == null || parameterDefinition is SimpleParameterDefinition)
            {
                if (getValueSettings.TryConvert)
                {
                    return Core.Query.TryConvert(this.value, out value);
                }

                if (this.value is T t_Temp)
                {
                    value = t_Temp;
                    return true;
                }

                return false;
            }

            if (parameterDefinition is not ComplexParameterDefinition complexParameterDefinition)
            {
                return false;
            }

            if (getValueSettings.CheckAccessType && !complexParameterDefinition.AccessType.Read())
            {
                return false;
            }

            if (getValueSettings.TryConvert)
            {
                return Core.Query.TryConvert(this.value, out value);
            }

            if (this.value is T t)
            {
                value = t;
                return true;
            }

            //TODO: Implement conversion of ParameterValue (2025.06.27)
            //START
            ParameterValue? parameterValue = complexParameterDefinition.ParameterValue;
            if (parameterValue != null && parameterValue.TryConvert(this.value, out object? value_Temp))
            {
                if (value_Temp is T t_Temp)
                {
                    value = t_Temp;
                    return true;
                }
            }
            //END

            return false;
        }
    }
}