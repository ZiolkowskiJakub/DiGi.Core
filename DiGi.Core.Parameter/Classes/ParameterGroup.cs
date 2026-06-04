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
    /// <summary>
    /// Represents a group of parameters.
    /// </summary>
    public class ParameterGroup : SerializableObject, IEnumerable<Parameter>
    {
        [JsonIgnore]
        private readonly Dictionary<string, Parameter> dictionary = [];

        [JsonInclude, JsonPropertyName("Name")]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class with a specified name.
        /// </summary>
        public ParameterGroup(string? name)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class with a specified name and a collection of parameters.
        /// </summary>
        public ParameterGroup(string? name, IEnumerable<Parameter>? parameters)
        {
            this.name = name;
            SetParameters(parameters);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class by copying another group.
        /// </summary>
        public ParameterGroup(ParameterGroup? parameterGroup)
            : base()
        {
            if (parameterGroup != null)
            {
                name = parameterGroup.name;
                SetParameters(parameterGroup.dictionary?.Values);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class from a JSON object.
        /// </summary>
        public ParameterGroup(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the display name of the parameter.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        [JsonInclude, JsonPropertyName("Parameters")]
        private List<Parameter> Parameters
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

        /// <summary>
        /// Creates a shallow copy of the current parameter group collection.
        /// </summary>
        public override ISerializableObject? Clone()
        {
            return new ParameterGroup(this);
        }

        /// <summary>
        /// Determines whether any group in the collection contains a parameter with the specified unique identifier.
        /// </summary>
        public bool Contains(string? uniqueId)
        {
            if (uniqueId == null)
            {
                return false;
            }

            return dictionary.ContainsKey(uniqueId);
        }

        /// <summary>
        /// Determines whether any group in the collection contains a parameter matching the specified definition.
        /// </summary>
        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            return Contains(parameterDefinition?.UniqueId);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the parameters in the group.
        /// </summary>
        public IEnumerator<Parameter> GetEnumerator()
        {
            return GetParameters().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Retrieves a list of parameter definitions of the specified type within the group.
        /// </summary>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            List<TParameterDefinition> result = [];

            foreach (Parameter parameter in dictionary.Values)
            {
                IParameterDefinition? parameterDefinition = parameter?.ParameterDefinition;
                if (parameterDefinition == null || parameterDefinition is not TParameterDefinition)
                {
                    continue;
                }

                result.Add((TParameterDefinition)parameterDefinition);
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of parameter definitions that match the specified name and comparison criteria.
        /// </summary>
        public List<IParameterDefinition>? GetParameterDefinitions(string? name, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            List<IParameterDefinition> result = [];

            foreach (Parameter parameter in dictionary.Values)
            {
                if (parameter == null)
                {
                    continue;
                }

                if (Core.Query.Compare(parameter.Name, name, textComparisonType, caseSensitive))
                {
                    IParameterDefinition? parameterDefinition = parameter.ParameterDefinition;
                    if (parameterDefinition == null)
                    {
                        continue;
                    }

                    result.Add(parameterDefinition);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of parameter definitions of type <typeparamref name="T"/> that match the specified name and comparison criteria.
        /// </summary>
        public List<T>? GetParameterDefinitions<T>(string? name, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where T : IParameterDefinition
        {
            if (name == null)
            {
                return null;
            }

            List<T> result = [];

            foreach (Parameter parameter in dictionary.Values)
            {
                IParameterDefinition? parameterDefinition = parameter?.ParameterDefinition;
                if (parameterDefinition is T t)
                {
                    if (Core.Query.Compare(parameterDefinition.Name, name, textComparisonType, caseSensitive))
                    {
                        result.Add(t);
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the value associated with the specified parameter definition from the collection.
        /// </summary>
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return GetValue(parameterDefinition?.UniqueId, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified unique identifier from the collection.
        /// </summary>
        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
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

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified unique identifier.
        /// </summary>
        public T? GetValue<T>(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return default;
            }

            Parameter? parameter = dictionary[uniqueId];
            if (parameter == null)
            {
                return default;
            }

            return parameter.GetValue<T>(getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return GetValue<T>(parameterDefinition?.UniqueId, getValueSettings);
        }

        /// <summary>
        /// Removes the parameter matching the specified definition from the collection.
        /// </summary>
        public bool Remove(IParameterDefinition? parameterDefinition)
        {
            string? uniqueId = parameterDefinition?.UniqueId;
            if (uniqueId == null)
            {
                return false;
            }

            return Remove(uniqueId);
        }

        /// <summary>
        /// Removes the parameter with the specified unique identifier from the group.
        /// </summary>
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

        /// <summary>
        /// Sets the value for the parameter identified by the specified name within the collection.
        /// </summary>
        public bool SetValue(string? name, object? value, SetValueSettings? setValueSettings = null)
        {
            if (name == null)
            {
                return false;
            }

            foreach (Parameter? parameter in dictionary.Values)
            {
                IParameterDefinition? parameterDefinition = parameter?.ParameterDefinition;
                if (parameterDefinition == null)
                {
                    continue;
                }

                if (parameterDefinition?.Name == name)
                {
                    if (parameter!.SetValue(value, setValueSettings))
                    {
                        return true;
                    }
                }
            }

            Parameter? parameter_New = Create.Parameter(name, value);
            if (parameter_New?.UniqueId == null)
            {
                return false;
            }

            dictionary[parameter_New.UniqueId] = parameter_New;
            return true;
        }

        /// <summary>
        /// Sets the value for the parameter matching the specified definition within the collection.
        /// </summary>
        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(parameterDefinition.UniqueId, out Parameter? parameter) && parameter == null)
            {
                parameter = Create.Parameter(parameterDefinition, value, setValueSettings);
                if (parameter == null)
                {
                    return false;
                }

                dictionary[parameterDefinition.UniqueId] = parameter;
                return true;
            }

            return parameter.SetValue(value, setValueSettings);
        }

        /// <summary>
        /// Adds or updates a parameter in the collection.
        /// </summary>
        public bool SetValue(Parameter? parameter)
        {
            if (parameter?.UniqueId == null)
            {
                return false;
            }

            dictionary[parameter.UniqueId] = new Parameter(parameter);
            return true;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified unique identifier from the collection.
        /// </summary>
        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
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

        /// <summary>
        /// Attempts to get the value associated with the specified parameter definition from the collection.
        /// </summary>
        public bool TryGetValue(IParameterDefinition? parameterDefinition, out object? value, GetValueSettings? getValueSettings = null)
        {
            value = default;
            if (parameterDefinition == null)
            {
                return false;
            }

            return TryGetValue(parameterDefinition.UniqueId, out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to get the value of type <typeparamref name="T"/> associated with the specified unique identifier from the collection.
        /// </summary>
        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            value = default;
            if (uniqueId == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(uniqueId, out Parameter parameter) || parameter == null)
            {
                return false;
            }

            return parameter.TryGetValue(out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to get the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            value = default;
            if (parameterDefinition == null)
            {
                return false;
            }

            return TryGetValue(parameterDefinition.UniqueId, out value, getValueSettings);
        }

        private List<Parameter> GetParameters()
        {
            List<Parameter> result = [];
            foreach (Parameter parameter in dictionary.Values)
            {
                if (parameter == null)
                {
                    continue;
                }

                result.Add(new Parameter(parameter));
            }

            return result;
        }

        private void SetParameters(IEnumerable<Parameter>? parameters)
        {
            dictionary.Clear();

            if (parameters == null)
            {
                return;
            }

            foreach (Parameter parameter in parameters)
            {
                string? uniqueId = parameter?.UniqueId;
                if (uniqueId == null)
                {
                    continue;
                }

                dictionary[uniqueId] = new Parameter(parameter);
            }
        }
    }
}