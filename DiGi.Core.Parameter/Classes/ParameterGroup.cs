using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class ParameterGroup : SerializableObject, IEnumerable<Parameter>
    {
        [JsonIgnore]
        private Dictionary<string, Parameter> dictionary = new Dictionary<string, Parameter>();

        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        public ParameterGroup(string name)
        {
            this.name = name;
        }

        public ParameterGroup(string name, IEnumerable<Parameter> parameters)
        {
            this.name = name;
            SetParameters(parameters);
        }

        public ParameterGroup(ParameterGroup parameterGroup)
            :base()
        {
            if(parameterGroup != null)
            {
                name = parameterGroup.name;
                SetParameters(parameterGroup.dictionary?.Values);
            }
        }

        public ParameterGroup(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonInclude, JsonPropertyName("Parameters")]
        private List<Parameter> parameters
        {
            get
            {
                return GetParameters();
            }

            set
            {
                SetParameters(value);
            }
        }
        
        public override ISerializableObject Clone()
        {
            return new ParameterGroup(this);
        }

        public bool Contains(string uniqueId)
        {
            return dictionary.ContainsKey(uniqueId);
        }

        public bool Contains(IParameterDefinition parameterDefinition)
        {
            return Contains(parameterDefinition.UniqueId);
        }

        public IEnumerator<Parameter> GetEnumerator()
        {
            return GetParameters().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<TParameterDefinition> GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            List<TParameterDefinition> result = new List<TParameterDefinition>();

            foreach (Parameter parameter in dictionary.Values)
            {
                IParameterDefinition parameterDefinition = parameter?.ParameterDefinition;
                if (parameterDefinition == null || !(parameterDefinition is TParameterDefinition))
                {
                    continue;
                }

                result.Add((TParameterDefinition)parameterDefinition);
            }

            return result;
        }

        public List<IParameterDefinition> GetParameterDefinitions(string name, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            List<IParameterDefinition> result = new List<IParameterDefinition>();

            foreach(Parameter parameter in dictionary.Values)
            {
                if(parameter == null)
                {
                    continue;
                }

                if(Core.Query.Compare(parameter.Name, name, textComparisonType, caseSensitive))
                {
                    result.Add(parameter.ParameterDefinition);
                }
            }

            return result;
        }

        public List<T> GetParameterDefinitions<T>(string name, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where T: IParameterDefinition
        {
            List<T> result = new List<T>();

            foreach (Parameter parameter in dictionary.Values)
            {
                IParameterDefinition parameterDefinition = parameter?.ParameterDefinition;
                if(parameterDefinition is T)
                {
                    if (Core.Query.Compare(parameterDefinition.Name, name, textComparisonType, caseSensitive))
                    {
                        result.Add((T)parameterDefinition);
                    }
                }
            }

            return result;
        }

        public object GetValue(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
        {
            return GetValue(parameterDefinition?.UniqueId, getValueSettings);
        }

        public object GetValue(string uniqueId, GetValueSettings getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return null;
            }

            Parameter parameter = dictionary[uniqueId];
            if (parameter == null)
            {
                return null;
            }

            return parameter.GetValue<object>(getValueSettings);
        }

        public T GetValue<T>(string uniqueId, GetValueSettings getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return default;
            }

            Parameter parameter = dictionary[uniqueId];
            if (parameter == null)
            {
                return default;
            }

            return parameter.GetValue<T>(getValueSettings);
        }

        public T GetValue<T>(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
        {
            return GetValue<T>(parameterDefinition?.UniqueId, getValueSettings);
        }

        public bool Remove(IParameterDefinition parameterDefinition)
        {
            if (parameterDefinition == null)
            {
                return false;
            }

            return Remove(parameterDefinition.UniqueId);
        }

        public bool Remove(string uniqueId)
        {
            if (uniqueId == null)
            {
                return false;
            }

            if (!dictionary.ContainsKey(uniqueId))
            {
                return false;
            }

            return dictionary.Remove(uniqueId);
        }

        public bool SetValue(string name, object value, SetValueSettings setValueSettings = null)
        {
            if(name == null)
            {
                return false;
            }

            foreach(Parameter parameter in dictionary.Values)
            {
                IParameterDefinition parameterDefinition = parameter?.ParameterDefinition;
                if(parameterDefinition == null)
                {
                    continue;
                }

                if(parameterDefinition.Name == name)
                {
                    if(parameter.SetValue(value, setValueSettings))
                    {
                        return true;
                    }
                }
            }

            Parameter parameter_New = Create.Parameter(name, value);
            if(parameter_New == null)
            {
                return false;
            }

            dictionary[parameter_New.UniqueId] = parameter_New;
            return true;
        }
        
        public bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(parameterDefinition.UniqueId, out Parameter parameter) && parameter == null)
            {
                parameter = Create.Parameter(parameterDefinition, value, setValueSettings);
                if(parameter == null)
                {
                    return false;
                }

                dictionary[parameterDefinition.UniqueId] = parameter;
                return true;
            }

            return parameter.SetValue(value, setValueSettings);
        }

        public bool SetValue(Parameter parameter)
        {
            if(parameter?.UniqueId == null)
            {
                return false;
            }

            dictionary[parameter.UniqueId] = new Parameter(parameter);
            return true;
        }

        public bool TryGetValue(string uniqueId, out object value, GetValueSettings getValueSettings = null)
        {
            value = null;
            if (uniqueId == null)
            {
                return false;
            }

            Parameter parameter = dictionary[uniqueId];
            if (parameter == null)
            {
                return false;
            }

            return parameter.TryGetValue(out value, getValueSettings);
        }

        public bool TryGetValue(IParameterDefinition parameterDefinition, out object value, GetValueSettings getValueSettings = null)
        {
            value = default;
            if(parameterDefinition == null)
            {
                return false;
            }

            return TryGetValue(parameterDefinition.UniqueId, out value, getValueSettings);
        }

        public bool TryGetValue<T>(string uniqueId, out T value, GetValueSettings getValueSettings = null)
        {
            value = default;
            if (uniqueId == null)
            {
                return false;
            }

            if(!dictionary.TryGetValue(uniqueId, out Parameter parameter) || parameter == null)
            {
                return false;
            }

            return parameter.TryGetValue(out value, getValueSettings);
        }

        public bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value, GetValueSettings getValueSettings = null)
        {
            value = default;
            if(parameterDefinition == null)
            {
                return false;
            }

            return TryGetValue(parameterDefinition.UniqueId, out value, getValueSettings);
        }
        
        private List<Parameter> GetParameters()
        {
            List<Parameter> result = new List<Parameter>();
            foreach(Parameter parameter in dictionary.Values)
            {
                result.Add(parameter == null ? null : new Parameter(parameter));
            }

            return result;
        }

        private void SetParameters(IEnumerable<Parameter> parameters)
        {
            dictionary.Clear();
            foreach(Parameter parameter in parameters)
            {
                string uniqueId = parameter?.UniqueId;
                if(uniqueId == null)
                {
                    continue;
                }

                dictionary[uniqueId] = new Parameter(parameter);
            }
        }
    }
}
