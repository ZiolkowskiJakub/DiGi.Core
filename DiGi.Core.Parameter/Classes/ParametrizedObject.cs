using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Parameter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Class ParametrizedObject.
    /// </summary>
    public class ParametrizedObject : SerializableObject, IParametrizedObject
    {
        [JsonInclude, JsonPropertyName("ParameterGroupCollection")]
        private readonly ParameterGroupCollection parameterGroupCollection = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class using a collection of parameters.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class.
        /// </summary>
        public ParametrizedObject()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class using a parameter group collection.
        /// </summary>
        public ParametrizedObject(ParameterGroupCollection? parameterGroupCollection)
        {
            this.parameterGroupCollection = parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parameterGroupCollection);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class from a JSON object.
        /// </summary>
        public ParametrizedObject(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParametrizedObject"/> class by copying another parametrized object.
        /// </summary>
        public ParametrizedObject(ParametrizedObject? parametrizedObject)
            : base()
        {
            if (parametrizedObject != null)
            {
                parameterGroupCollection = parametrizedObject.parameterGroupCollection == null ? new ParameterGroupCollection() : new ParameterGroupCollection(parametrizedObject.parameterGroupCollection);
            }
        }

        /// <summary>
        /// Determines whether the object contains a parameter with the specified unique identifier.
        /// </summary>
        public bool Contains(string? uniqueId)
        {
            return parameterGroupCollection.Contains(uniqueId);
        }

        /// <summary>
        /// Determines whether the object contains a parameter associated with the specified definition.
        /// </summary>
        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Contains(parameterDefinition);
        }

        /// <summary>
        /// Retrieves a list of parameter definitions that match the specified name and comparison criteria.
        /// </summary>
        public List<IParameterDefinition>? GetParameterDefinitions(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            return parameterGroupCollection?.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
        }

        /// <summary>
        /// Retrieves a list of parameter definitions of type <typeparamref name="TParameterDefinition"/> that match the specified name and comparison criteria.
        /// </summary>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>(parameterName, textComparisonType, caseSensitive);
        }

        /// <summary>
        /// Retrieves all parameter definitions of type <typeparamref name="TParameterDefinition"/>.
        /// </summary>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            return parameterGroupCollection?.GetParameterDefinitions<TParameterDefinition>();
        }

        /// <summary>
        /// Gets the value associated with the specified parameter definition.
        /// </summary>
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(parameterDefinition, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified unique identifier.
        /// </summary>
        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection?.GetValue(uniqueId, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified enumeration member.
        /// </summary>
        public object? GetValue(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return null;
            }

            return parameterGroupCollection.GetValue((EnumParameterDefinition)@enum!, getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified enumeration member.
        /// </summary>
        public T? GetValue<T>(Enum? @enum, GetValueSettings? getValueSettings = null)
        {
            if (@enum == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>((EnumParameterDefinition)@enum!, getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition.
        /// </summary>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition == null)
            {
                return default;
            }

            return parameterGroupCollection.GetValue<T>(parameterDefinition, getValueSettings);
        }

        /// <summary>
        /// Removes the parameter associated with the specified definition.
        /// </summary>
        public bool Remove(IParameterDefinition? parameterDefinition)
        {
            return parameterGroupCollection.Remove(parameterDefinition);
        }

        /// <summary>
        /// Removes the parameter associated with the specified unique identifier.
        /// </summary>
        public bool Remove(string? uniqueId)
        {
            return parameterGroupCollection.Remove(uniqueId);
        }

        /// <summary>
        /// Sets the value for the specified parameter definition.
        /// </summary>
        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(parameterDefinition, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value for the specified enumeration member.
        /// </summary>
        public bool SetValue(Enum? @enum, object? value, SetValueSettings? setValueSettings = null)
        {
            if (@enum == null)
            {
                return false;
            }

            return parameterGroupCollection.SetValue((EnumParameterDefinition)@enum!, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value for the parameter with the specified name.
        /// </summary>
        public bool SetValue(string? name, object? value, SetValueSettings? setValueSettings = null)
        {
            return parameterGroupCollection.SetValue(name, value, setValueSettings);
        }

        /// <summary>
        /// Sets the value using the provided parameter object.
        /// </summary>
        public bool SetValue(Parameter? parameter)
        {
            return parameterGroupCollection.SetValue(parameter);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified unique identifier.
        /// </summary>
        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
        {
            return TryGetValue(uniqueId, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified parameter definition.
        /// </summary>
        public bool TryGetValue(IParameterDefinition? parameterDefinition, out object? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value associated with the specified enumeration member.
        /// </summary>
        public bool TryGetValue(Enum? @enum, out object? value, GetValueSettings? getValueSettings = null)
        {
            value = null;
            if (@enum == null)
            {
                return false;
            }

            return TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified parameter definition.
        /// </summary>
        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(parameterDefinition, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified enumeration member.
        /// </summary>
        public bool TryGetValue<T>(Enum? @enum, out T? value, GetValueSettings? getValueSettings = null)
        {
            if (@enum is null)
            {
                value = default;
                return false;
            }

            return parameterGroupCollection.TryGetValue((EnumParameterDefinition)@enum!, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to retrieve the value of type <typeparamref name="T"/> associated with the specified unique identifier.
        /// </summary>
        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            return parameterGroupCollection.TryGetValue(uniqueId, out value, getValueSettings);
        }
    }
}