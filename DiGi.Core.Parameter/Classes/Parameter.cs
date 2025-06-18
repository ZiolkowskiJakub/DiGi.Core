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
        private IParameterDefinition parameterDefinition;

        [JsonInclude, JsonPropertyName("Value")]
        private object value;

        public Parameter(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Parameter(Parameter parameter)
            : this(parameter?.ParameterDefinition, parameter.value)
        {

        }

        internal Parameter(IParameterDefinition parameterDefinition, object value)
        {
            this.parameterDefinition = parameterDefinition == null ? null : parameterDefinition.Clone<IParameterDefinition>();
            this.value = value is ISerializableObject ? ((ISerializableObject)value).Clone() : value;
        }

        internal Parameter(IParameterDefinition parameterDefinition)
        {
            this.parameterDefinition = parameterDefinition == null ? null : parameterDefinition.Clone<IParameterDefinition>();
        }

        [JsonIgnore]
        public IParameterDefinition ParameterDefinition
        {
            get
            {
                return parameterDefinition == null ? null : parameterDefinition.Clone<IParameterDefinition>();
            }
        }
        
        [JsonIgnore]
        public string Name
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
        public string UniqueId
        {
            get
            {
                return parameterDefinition?.UniqueId;
            }
        }

        [JsonIgnore]
        public object Value
        {
            get
            {
                return value;
            }
        }

        public T GetValue<T>(GetValueSettings getValueSettings = null)
        {
            if(!TryGetValue(out T result, getValueSettings))
            {
                return default;
            }

            return result;
        }

        public bool TryGetValue<T>(out T value, GetValueSettings getValueSettings = null)
        {
            value = default;

            if(getValueSettings == null)
            {
                getValueSettings = new GetValueSettings();
            }

            if (parameterDefinition == null || parameterDefinition is SimpleParameterDefinition)
            {
                if(getValueSettings.TryConvert)
                {
                    return Core.Query.TryConvert(this.value, out value);
                }

                if(this.value is T)
                {
                    value = (T)this.value;
                    return true;
                }

                return false;
            }

            ComplexParameterDefinition complexParameterDefinition = parameterDefinition as ComplexParameterDefinition;
            if (complexParameterDefinition == null)
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

            if (this.value is T)
            {
                value = (T)this.value;
                return true;
            }

            return false;
        }

        public bool SetValue(object value, SetValueSettings setValueSettings = null)
        {
            if (parameterDefinition == null || parameterDefinition is SimpleParameterDefinition)
            {
                this.value = value is ISerializableObject ? ((ISerializableObject)value).Clone() : value;
                return true;
            }

            ComplexParameterDefinition complexParameterDefinition = parameterDefinition as ComplexParameterDefinition;
            if (complexParameterDefinition == null)
            {
                return false;
            }

            if (setValueSettings == null)
            {
                setValueSettings = new SetValueSettings();
            }

            if (setValueSettings.CheckAccessType && !complexParameterDefinition.AccessType.Write())
            {
                return false;
            }

            ParameterValue parameterValue = complexParameterDefinition.ParameterValue;
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
