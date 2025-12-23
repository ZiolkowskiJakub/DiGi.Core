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
        [JsonInclude, JsonPropertyName("ParameterGroupCollection")]
        private readonly ParameterGroupCollection parameterGroupCollection = new();

        public ParametrizedObject(IEnumerable<Parameter>? parameters)
            : base()
        {
            if (parameters != null)
            {
                foreach (Parameter parameter in parameters)
                {
                    parameterGroupCollection.SetValue(parameter);
                }
            }
        }

        public ParametrizedObject()
        {

        }

        public ParametrizedObject(ParameterGroupCollection? parameterGroupCollection)
        {
            this.parameterGroupCollection = parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parameterGroupCollection);
        }

        public ParametrizedObject(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ParametrizedObject(ParametrizedObject? parametrizedObject)
            : base()
        {
            if (parametrizedObject != null)
            {
                parameterGroupCollection = parametrizedObject.parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parametrizedObject.parameterGroupCollection);
            }
        }

        public bool Contains(string? uniqueId)
        {
            return parameterGroupCollection.Contains(uniqueId);
        }

        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Contains(parameterDefinition);
        }

        public List<IParameterDefinition>? GetParameterDefinitions(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            return parameterGroupCollection?.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
        }

        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>(parameterName, textComparisonType, caseSensitive);
        }

        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>();
        }

        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(parameterDefinition, getValueSettings);
        }

        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(uniqueId, getValueSettings);
        }

        public object? GetValue(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return null;
            }

            return parameterGroupCollection.GetValue((EnumParameterDefinition)@enum!, getValueSettings);
        }

        public T? GetValue<T>(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>((EnumParameterDefinition)@enum!, getValueSettings);
        }

        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>(parameterDefinition, getValueSettings);
        }

        public bool Remove(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Remove(parameterDefinition);
        }

        public bool Remove(string? uniqueId)
        {
            return parameterGroupCollection.Remove(uniqueId);
        }

        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(parameterDefinition, value, setValueSettings);
        }

        public bool SetValue(Enum? @enum, object? value, SetValueSettings? setValueSettings = null)
        {
            if (@enum == null)
            {
                return false;
            }

            return parameterGroupCollection.SetValue((EnumParameterDefinition)@enum!, value, setValueSettings);
        }

        public bool SetValue(string? name, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(name, value, setValueSettings);
        }

        public bool SetValue(Parameter? parameter)
        {
            return parameterGroupCollection.SetValue(parameter);
        }

        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
        {
            return TryGetValue(uniqueId, out value, getValueSettings);
        }

        public bool TryGetValue(IParameterDefinition? parameterDefinition, out object? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        public bool TryGetValue(Enum? @enum, out object? value, GetValueSettings? getValueSettings = null)
        {
            value = null;
            if (@enum == null)
            {
                return false;
            }

            return TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        public bool TryGetValue<T>(Enum? @enum, out T? value, GetValueSettings? getValueSettings = null)
        {
            if (@enum is null)
            {
                value = default;
                return false;
            }

            return parameterGroupCollection.TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(uniqueId, out value, getValueSettings);
        }
    }
}
