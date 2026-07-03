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

        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class with a specified name.
        /// </summary>
        /// <param name="name">The name of the parameter group.</param>
        public ParameterGroup(string? name)
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class with a specified name and a collection of parameters.
        /// </summary>
        /// <param name="name">The name of the parameter group.</param>
        /// <param name="parameters">The collection of parameters to include in the group.</param>
        public ParameterGroup(string? name, IEnumerable<Parameter>? parameters)
        {
            this.name = name;
            SetParameters(parameters);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroup"/> class by copying another group.
        /// </summary>
        /// <param name="parameterGroup">The parameter group to copy from.</param>
        public ParameterGroup(ParameterGroup? parameterGroup)
            : base(parameterGroup)
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
        /// <param name="jsonObject">The JSON object to initialize the group from.</param>
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

        [JsonInclude, JsonPropertyName(nameof(Parameters))]
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
        /// <returns>A shallow copy of the current parameter group collection.</returns>
        public override ISerializableObject? Clone()
        {
            return new ParameterGroup(this);
        }

        /// <summary>
        /// Determines whether any group in the collection contains a parameter with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the parameter to search for.</param>
        /// <returns>True if the collection contains a parameter with the specified unique identifier; otherwise, false.</returns>
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
        /// <param name="parameterDefinition">The parameter definition to search for.</param>
        /// <returns>True if the collection contains a parameter matching the specified definition; otherwise, false.</returns>
        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            return Contains(parameterDefinition?.UniqueId);
        }

        /// <summary>
        /// Returns an enumerator that iterates through the parameters in the group.
        /// </summary>
        /// <returns>An enumerator that iterates through the parameters in the group.</returns>
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
        /// <typeparam name="TParameterDefinition">The type of parameter definition to retrieve.</typeparam>
        /// <returns>A list of parameter definitions of the specified type, or null if none are found.</returns>
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
        /// <param name="name">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use when matching the name.</param>
        /// <param name="caseSensitive">A value indicating whether the name comparison is case-sensitive.</param>
        /// <returns>A list of parameter definitions that match the specified criteria, or null if no matches are found.</returns>
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
        /// <typeparam name="T">The type of parameter definitions to retrieve.</typeparam>
        /// <param name="name">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use when matching the name.</param>
        /// <param name="caseSensitive">A value indicating whether the name comparison is case-sensitive.</param>
        /// <returns>A list of parameter definitions of type <typeparamref name="T"/> that match the specified criteria, or null if no matches are found.</returns>
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
        /// <param name="parameterDefinition">The parameter definition to retrieve the value for.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified parameter definition, or null if not found.</returns>
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return GetValue(parameterDefinition?.UniqueId, getValueSettings);
        }

        /// <summary>
        /// Gets the value associated with the specified unique identifier from the collection.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the value to get.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value associated with the specified unique identifier, or null if not found.</returns>
        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return null;
            }

            if (!dictionary.TryGetValue(uniqueId, out Parameter? parameter) || parameter == null)
            {
                return null;
            }

            return parameter.GetValue<object>(getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified unique identifier.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueId">The unique identifier of the value to get.</param>
        /// <param name="getValueSettings">Optional settings for retrieving the value.</param>
        /// <returns>The value of type <typeparamref name="T"/> associated with the specified unique identifier, or null if not found.</returns>
        public T? GetValue<T>(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return default;
            }

            if (!dictionary.TryGetValue(uniqueId, out Parameter? parameter) || parameter == null)
            {
                return default;
            }

            return parameter.GetValue<T>(getValueSettings);
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The definition of the parameter whose value is to be retrieved.</param>
        /// <param name="getValueSettings">Optional settings to control how the value is retrieved.</param>
        /// <returns>The value associated with the specified parameter definition, or the default value for type <typeparamref name="T"/> if not found.</returns>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            return GetValue<T>(parameterDefinition?.UniqueId, getValueSettings);
        }

        /// <summary>
        /// Removes the parameter matching the specified definition from the collection.
        /// </summary>
        /// <param name="parameterDefinition">The definition of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
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
        /// <param name="uniqueId">The unique identifier of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
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
        /// <param name="name">The name of the parameter to set.</param>
        /// <param name="value">The value to assign to the parameter.</param>
        /// <param name="setValueSettings">Optional settings to control how the value is set.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
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
        /// <param name="parameterDefinition">The definition of the parameter to set.</param>
        /// <param name="value">The value to assign to the parameter.</param>
        /// <param name="setValueSettings">Optional settings to control how the value is set.</param>
        /// <returns>True if the value was successfully set; otherwise, false.</returns>
        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(parameterDefinition.UniqueId, out Parameter? parameter))
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
        /// <param name="parameter">The parameter to add or update.</param>
        /// <returns>True if the operation was successful; otherwise, false.</returns>
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
        /// <param name="uniqueId">The unique identifier of the parameter for which to retrieve the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value if found; otherwise, null.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
        {
            value = null;
            if (uniqueId == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(uniqueId, out Parameter? parameter) || parameter == null)
            {
                return false;
            }

            return parameter.TryGetValue(out value, getValueSettings);
        }

        /// <summary>
        /// Attempts to get the value associated with the specified parameter definition from the collection.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition for which to retrieve the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value if found; otherwise, null.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
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
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueId">The unique identifier of the parameter for which to retrieve the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value of type <typeparamref name="T"/> if found; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
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
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The parameter definition for which to retrieve the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value of type <typeparamref name="T"/> if found; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
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