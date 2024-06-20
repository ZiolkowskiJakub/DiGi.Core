using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Parameter.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    public class ParametrizedObject : SerializableObject, IParametrizedObject
    {
        [JsonInclude, JsonPropertyName("ParameterGroups")]
        private ParameterGroups parameterGroups = new ParameterGroups();

        public ParametrizedObject(IEnumerable<Parameter> parameters)
            : base()
        {
            if(parameters != null)
            {
                foreach(Parameter parameter in parameters)
                {
                    parameterGroups.SetValue(parameter);
                }
            }
        }

        public ParametrizedObject()
        {

        }

        public ParametrizedObject(ParameterGroups parameterGroups)
        {
            this.parameterGroups = parameterGroups == null ? null : new ParameterGroups(parameterGroups);
        }

        public ParametrizedObject(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ParametrizedObject(ParametrizedObject parametrizedObject)
            : base()
        {
            if(parametrizedObject != null) 
            {
                parameterGroups = parametrizedObject.parameterGroups == null ? null : new ParameterGroups(parametrizedObject.parameterGroups);
            }
        }

        public bool Contains(string uniqueId)
        {
            return parameterGroups.Contains(uniqueId);
        }

        public bool Contains(IParameterDefinition parameterDefinition)
        {
            return parameterGroups.Contains(parameterDefinition);
        }

        public List<IParameterDefinition> GetParameterDefinitions(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            return parameterGroups.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
        }

        public List<T> GetParameterDefinitions<T>(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where T : IParameterDefinition
        {
            return parameterGroups.GetParameterDefinitions<T>(parameterName, textComparisonType, caseSensitive);
        }

        public object GetValue(IParameterDefinition parameterDefinition)
        {
            return parameterGroups.GetValue(parameterDefinition);
        }

        public object GetValue(string uniqueId)
        {
            return parameterGroups.GetValue(uniqueId);
        }

        public bool Remove(IParameterDefinition parameterDefinition)
        {
            return parameterGroups.Remove(parameterDefinition);
        }

        public bool Remove(string uniqueId)
        {
            return parameterGroups.Remove(uniqueId);
        }

        public bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null)
        {
            return parameterGroups.SetValue(parameterDefinition, value, setValueSettings);
        }

        public bool SetValue(string name, object value, SetValueSettings setValueSettings = null)
        {
            return parameterGroups.SetValue(name, value, setValueSettings);
        }

        public bool SetValue(Parameter parameter)
        {
            return parameterGroups.SetValue(parameter);
        }

        public bool TryGetValue(string uniqueId, out object value)
        {
            return TryGetValue(uniqueId, out value);
        }

        public bool TryGetValue(IParameterDefinition parameterDefinition, out object value)
        {
            return TryGetValue(parameterDefinition, out value);
        }

        public bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value)
        {
            return parameterGroups.TryGetValue(parameterDefinition, out value);
        }

        public bool TryGetValue<T>(string uniqueId, out T value)
        {
            return parameterGroups.TryGetValue(uniqueId, out value);
        }
    }
}
