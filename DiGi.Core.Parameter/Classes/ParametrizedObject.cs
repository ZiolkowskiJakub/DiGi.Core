using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Parameter.Interfaces;
using System;
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

        public object GetValue(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
        {
            return parameterGroups.GetValue(parameterDefinition, getValueSettings);
        }

        public object GetValue(string uniqueId, GetValueSettings getValueSettings = null)
        {
            return parameterGroups.GetValue(uniqueId, getValueSettings);
        }

        public object GetValue(Enum @enum, GetValueSettings getValueSettings = null)
        {
            if(@enum == null)
            {
                return null;
            }

            return parameterGroups.GetValue((EnumParameterDefinition)@enum, getValueSettings);
        }

        public T GetValue<T>(Enum @enum, GetValueSettings getValueSettings = null)
        {
            if (@enum == null)
            {
                return default;
            }

            return parameterGroups.GetValue<T>((EnumParameterDefinition)@enum, getValueSettings);
        }

        public T GetValue<T>(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return default;
            }

            return parameterGroups.GetValue<T>(parameterDefinition, getValueSettings);
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

        public bool SetValue(System.Enum @enum, object value, SetValueSettings setValueSettings = null)
        {
            if(@enum == null)
            {
                return false;
            }

            return parameterGroups.SetValue((EnumParameterDefinition)@enum, value, setValueSettings);
        }

        public bool SetValue(string name, object value, SetValueSettings setValueSettings = null)
        {
            return parameterGroups.SetValue(name, value, setValueSettings);
        }

        public bool SetValue(Parameter parameter)
        {
            return parameterGroups.SetValue(parameter);
        }

        public bool TryGetValue(string uniqueId, out object value, GetValueSettings getValueSettings = null)
        {
            return TryGetValue(uniqueId, out value, getValueSettings);
        }

        public bool TryGetValue(IParameterDefinition parameterDefinition, out object value, GetValueSettings getValueSettings = null)
        {
            return TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        public bool TryGetValue(System.Enum @enum, out object value, GetValueSettings getValueSettings = null)
        {
            return TryGetValue((EnumParameterDefinition)@enum, out value, getValueSettings);
        }

        public bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value, GetValueSettings getValueSettings = null)
        {
            return parameterGroups.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        public bool TryGetValue<T>(System.Enum @enum, out T value, GetValueSettings getValueSettings = null)
        {
            return parameterGroups.TryGetValue((EnumParameterDefinition)@enum, out value, getValueSettings);
        }

        public bool TryGetValue<T>(string uniqueId, out T value, GetValueSettings getValueSettings = null)
        {
            return parameterGroups.TryGetValue(uniqueId, out value, getValueSettings);
        }
    }
}
