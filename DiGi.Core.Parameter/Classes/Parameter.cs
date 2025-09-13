using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class Parameter : SerializableObject
    {
        [JsonInclude, JsonPropertyName("ParameterDefinition")]
        private readonly IParameterDefinition? parameterDefinition;

        [JsonInclude, JsonPropertyName("Value")]
        private object? value;

        public Parameter(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public Parameter(Parameter? parameter)
            : this(parameter?.ParameterDefinition, parameter?.value)
        {

        }

        internal Parameter(IParameterDefinition? parameterDefinition, object? value)
        {
            this.parameterDefinition = parameterDefinition?.Clone<IParameterDefinition>();
            this.value = value is ISerializableObject serializableObject ? serializableObject.Clone() : value;
        }

        internal Parameter(IParameterDefinition? parameterDefinition)
        {
            this.parameterDefinition = parameterDefinition?.Clone<IParameterDefinition>();
        }

        [JsonIgnore]
        public IParameterDefinition? ParameterDefinition
        {
            get
            {
                return parameterDefinition?.Clone<IParameterDefinition>();
            }
        }
        
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return parameterDefinition?.Name;
            }
        }

        [JsonIgnore]
        public Enums.ParameterType ParameterType
        {
            get
            {
                return parameterDefinition == null ? Enums.ParameterType.Undefined : parameterDefinition.ParameterType;
            }
        }

        [JsonIgnore]
        public string? UniqueId
        {
            get
            {
                return parameterDefinition?.UniqueId;
            }
        }

        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
        }

        public T? GetValue<T>(GetValueSettings? getValueSettings = null)
        {
            if(!TryGetValue(out T? result, getValueSettings))
            {
                return default;
            }

            return result;
        }

        public bool TryGetValue<T>(out T? value, GetValueSettings? getValueSettings = null)
        {
            value = default;

            getValueSettings ??= new GetValueSettings();

            if (parameterDefinition == null || parameterDefinition is SimpleParameterDefinition)
            {
                if(getValueSettings.TryConvert)
                {
                    return Core.Query.TryConvert(this.value, out value);
                }

                if(this.value is T t_Temp)
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

            if(!parameterValue.IsValid(value))
            {
                return false;
            }

            this.value = value;
            return true;
        }
    }
}
