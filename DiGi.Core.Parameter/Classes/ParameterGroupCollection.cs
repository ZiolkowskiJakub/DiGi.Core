using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Parameter.Classes
{
    /// <summary>
    /// Represents a collection of parameter groups.
    /// </summary>
    public class ParameterGroupCollection : SerializableObject, IEnumerable<ParameterGroup>
    {
        [JsonIgnore]
        private readonly Dictionary<string, ParameterGroup> dictionary = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupCollection"/> class.
        /// </summary>
        public ParameterGroupCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupCollection"/> class from a collection of parameters.
        /// </summary>
        /// <param name="parameters">The collection of parameters to initialize the collection with.</param>
        public ParameterGroupCollection(IEnumerable<Parameter>? parameters)
        {
            if (parameters != null)
            {
                foreach (Parameter parameter in parameters)
                {
                    SetValue(parameter);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the collection from.</param>
        public ParameterGroupCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="parameterGroupCollection">The parameter group collection to copy from.</param>
        public ParameterGroupCollection(ParameterGroupCollection? parameterGroupCollection)
            : base(parameterGroupCollection)
        {
            this.ParameterGroups = parameterGroupCollection?.ParameterGroups;
        }

        [JsonInclude, JsonPropertyName("ParameterGroups")]
        private List<ParameterGroup>? ParameterGroups
        {
            get
            {
                return GetParameterGroups();
            }

            set
            {
                SetParameterGroups(value);
            }
        }

        /// <summary>
        /// Gets the parameter group associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the parameter group to retrieve.</param>
        /// <returns>The <see cref="ParameterGroup"/> if a group with the specified name exists; otherwise, <see langword="null"/>.</returns>
        public ParameterGroup? this[string? name]
        {
            get
            {
                if (name == null || !dictionary.TryGetValue(name, out ParameterGroup? parameterGroup))
                {
                    return null;
                }

                return parameterGroup;
            }
            //set
            //{
            //    if (value == null || value.Name == null)
            //    {
            //        return;
            //    }

            //    dictionary[value.Name] = value;
            //}
        }

        /// <summary>
        /// Creates a shallow copy of the current parameter group collection.
        /// </summary>
        /// <returns>A shallow copy of the current parameter group collection.</returns>
        public override ISerializableObject? Clone()
        {
            return new ParameterGroupCollection(this);
        }

        /// <summary>
        /// Determines whether any group in the collection contains a parameter with the specified unique identifier.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the parameter to search for.</param>
        /// <returns>True if any group in the collection contains a parameter with the specified unique identifier; otherwise, false.</returns>
        public bool Contains(string? uniqueId)
        {
            if (uniqueId == null)
            {
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Contains(uniqueId))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether any group in the collection contains a parameter matching the specified definition.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition to search for.</param>
        /// <returns>True if any group in the collection contains a parameter matching the specified definition; otherwise, false.</returns>
        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Contains(parameterDefinition))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Returns an enumerator that iterates through the parameter groups in the collection.
        /// </summary>
        /// <returns>An enumerator that iterates through the parameter groups in the collection.</returns>
        public IEnumerator<ParameterGroup> GetEnumerator()
        {
            return GetParameterGroups()?.GetEnumerator() ?? Enumerable.Empty<ParameterGroup>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Retrieves a list of all parameter definitions of the specified type across all groups.
        /// </summary>
        /// <typeparam name="TParameterDefinition">The type of parameter definition to retrieve.</typeparam>
        /// <returns>A list containing all parameter definitions of the specified type.</returns>
        public List<TParameterDefinition> GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition
        {
            List<TParameterDefinition> result = [];
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                List<TParameterDefinition>? parameterDefinitions = parameterGroup?.GetParameterDefinitions<TParameterDefinition>();
                if (parameterDefinitions != null)
                {
                    result.AddRange(parameterDefinitions);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of parameter definitions that match the specified name and comparison criteria across all groups.
        /// </summary>
        /// <param name="parameterName">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use when matching the name.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns>A list of parameter definitions that match the criteria, or null if none are found.</returns>
        public List<IParameterDefinition>? GetParameterDefinitions(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            if (parameterName == null)
            {
                return null;
            }

            List<IParameterDefinition> result = [];
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                List<IParameterDefinition>? parameterDefinitions = parameterGroup?.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
                if (parameterDefinitions != null)
                {
                    result.AddRange(parameterDefinitions);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves a list of parameter definitions of type <typeparamref name="TParameterDefinition"/> that match the specified name and comparison criteria across all groups.
        /// </summary>
        /// <typeparam name="TParameterDefinition">The type of parameter definition to retrieve.</typeparam>
        /// <param name="parameterName">The name of the parameters to search for.</param>
        /// <param name="textComparisonType">The type of text comparison to use when matching the name.</param>
        /// <param name="caseSensitive">A value indicating whether the comparison should be case-sensitive.</param>
        /// <returns>A list of parameter definitions that match the criteria, or null if none are found.</returns>
        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where TParameterDefinition : IParameterDefinition
        {
            if (parameterName == null)
            {
                return null;
            }

            List<TParameterDefinition> result = [];
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                List<TParameterDefinition>? parameterDefinitions = parameterGroup?.GetParameterDefinitions<TParameterDefinition>(parameterName, textComparisonType, caseSensitive);
                if (parameterDefinitions != null)
                {
                    result.AddRange(parameterDefinitions);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the value associated with the specified parameter definition from the collection.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition used to retrieve the value.</param>
        /// <param name="getValueSettings">Optional settings to customize how the value is retrieved.</param>
        /// <returns>The value associated with the specified parameter definition, or null if not found.</returns>
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return null;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(parameterDefinition, out object? value, getValueSettings))
                {
                    return value;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the value associated with the specified unique identifier from the collection.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the value to retrieve.</param>
        /// <param name="getValueSettings">Optional settings to customize how the value is retrieved.</param>
        /// <returns>The value associated with the specified unique identifier, or null if not found.</returns>
        public object? GetValue(string? uniqueId, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                return null;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(uniqueId, out object? value, getValueSettings))
                {
                    return value;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The definition of the parameter whose value is to be retrieved.</param>
        /// <param name="getValueSettings">Optional settings to control how the value is retrieved.</param>
        /// <returns>The value associated with the specified parameter definition, cast to type <typeparamref name="T"/>, or null if not found.</returns>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return default;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(parameterDefinition, out T? value, getValueSettings))
                {
                    return value;
                }
            }

            return default;
        }

        /// <summary>
        /// Removes the parameter matching the specified definition from the collection.
        /// </summary>
        /// <param name="parameterDefinition">The definition of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
        public bool Remove(IParameterDefinition? parameterDefinition)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Remove(parameterDefinition))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Removes the parameter with the specified unique identifier from the collection.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the parameter to remove.</param>
        /// <returns>True if the parameter was successfully removed; otherwise, false.</returns>
        public bool Remove(string? uniqueId)
        {
            if (uniqueId == null)
            {
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Remove(uniqueId))
                {
                    return true;
                }
            }

            return false;
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
            if (parameterDefinition == null)
            {
                return false;
            }

            string? groupName = parameterDefinition.GroupName;
            groupName ??= Constants.Names.DefaultGroupName;

            if (!dictionary.TryGetValue(groupName, out ParameterGroup parameterGroup) || parameterGroup == null)
            {
                parameterGroup = new ParameterGroup(groupName);
                dictionary[groupName] = parameterGroup;
            }

            bool result = parameterGroup.SetValue(parameterDefinition, value, setValueSettings);
            if (!result)
            {
                return result;
            }

            dictionary[groupName] = parameterGroup;
            return result;
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
            List<IParameterDefinition>? parameterDefinitions = GetParameterDefinitions(name);
            if (parameterDefinitions != null)
            {
                foreach (IParameterDefinition parameterDefinition in parameterDefinitions)
                {
                    if (SetValue(parameterDefinition, value, setValueSettings))
                    {
                        return true;
                    }
                }
            }

            Parameter? parameter = Create.Parameter(name, value);
            if (parameter == null)
            {
                return false;
            }

            string? groupName = parameter.ParameterDefinition?.GroupName;
            if (groupName == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(groupName, out ParameterGroup parameterGroup) || parameterGroup == null)
            {
                parameterGroup = new ParameterGroup(groupName);
                dictionary[groupName] = parameterGroup;
            }

            bool result = parameterGroup.SetValue(name, value, setValueSettings);
            if (!result)
            {
                return result;
            }

            dictionary[groupName] = parameterGroup;
            return result;
        }

        /// <summary>
        /// Adds or updates a parameter in the collection.
        /// </summary>
        /// <param name="parameter">The parameter to add or update.</param>
        /// <returns><c>true</c> if the operation was successful; otherwise, <c>false</c>.</returns>
        public bool SetValue(Parameter? parameter)
        {
            if (parameter?.UniqueId == null)
            {
                return false;
            }

            string? groupName = parameter.ParameterDefinition?.GroupName;
            groupName ??= Constants.Names.DefaultGroupName;

            if (!dictionary.TryGetValue(groupName, out ParameterGroup parameterGroup) || parameterGroup == null)
            {
                parameterGroup = new ParameterGroup(groupName);
                dictionary[groupName] = parameterGroup;
            }

            bool result = parameterGroup.SetValue(parameter);
            if (!result)
            {
                return result;
            }

            dictionary[groupName] = parameterGroup;
            return result;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified unique identifier from the collection.
        /// </summary>
        /// <param name="uniqueId">The unique identifier of the value to get.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified unique identifier, if found; otherwise, <c>null</c>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns><c>true</c> if the value was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue(string? uniqueId, out object? value, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                value = default;
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(uniqueId, out value, getValueSettings))
                {
                    return true;
                }
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Attempts to get the value associated with the specified parameter definition from the collection.
        /// </summary>
        /// <param name="parameterDefinition">The parameter definition associated with the value to get.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified parameter definition, if found; otherwise, <c>null</c>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns><c>true</c> if the value was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue(IParameterDefinition? parameterDefinition, out object? value, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                value = default;
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(parameterDefinition.UniqueId, out value, getValueSettings))
                {
                    return true;
                }
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Attempts to get the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="parameterDefinition">The parameter definition associated with the value to get.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified parameter definition, if found; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns><c>true</c> if the value was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                value = default;
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(parameterDefinition, out value, getValueSettings))
                {
                    return true;
                }
            }
            value = default;
            return false;
        }

        /// <summary>
        /// Attempts to get the value of type <typeparamref name="T"/> associated with the specified unique identifier from the collection.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueId">The unique identifier of the value to get.</param>
        /// <param name="value">When this method returns, contains the value associated with the specified unique identifier, if found; otherwise, the default value of <typeparamref name="T"/>.</param>
        /// <param name="getValueSettings">Optional settings to use when retrieving the value.</param>
        /// <returns><c>true</c> if the value was found; otherwise, <c>false</c>.</returns>
        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            if (uniqueId == null)
            {
                value = default;
                return false;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.TryGetValue(uniqueId, out value, getValueSettings))
                {
                    return true;
                }
            }
            value = default;
            return false;
        }

        private List<ParameterGroup>? GetParameterGroups()
        {
            List<ParameterGroup> result = [];
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup == null)
                {
                    continue;
                }

                result.Add(new ParameterGroup(parameterGroup));
            }

            return result;
        }

        private void SetParameterGroups(IEnumerable<ParameterGroup>? parameterGroups)
        {
            dictionary.Clear();
            if (parameterGroups == null)
            {
                return;
            }

            foreach (ParameterGroup parameterGroup in parameterGroups)
            {
                string? name = parameterGroup?.Name;
                if (name == null)
                {
                    continue;
                }

                dictionary[name] = new ParameterGroup(parameterGroup);
            }
        }
    }
}