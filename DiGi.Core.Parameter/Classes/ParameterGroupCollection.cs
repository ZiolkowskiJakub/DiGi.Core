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
        public ParameterGroupCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterGroupCollection"/> class by copying another collection.
        /// </summary>
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
        public override ISerializableObject? Clone()
        {
            return new ParameterGroupCollection(this);
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
        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return null;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Contains(parameterDefinition))
                {
                    return parameterGroup.GetValue(parameterDefinition, getValueSettings);
                }
            }

            return null;
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

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Contains(uniqueId))
                {
                    return parameterGroup.GetValue(uniqueId, getValueSettings);
                }
            }

            return null;
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T"/> associated with the specified parameter definition from the collection.
        /// </summary>
        public T? GetValue<T>(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if (parameterDefinition?.UniqueId == null)
            {
                return default;
            }

            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                if (parameterGroup != null && parameterGroup.Contains(parameterDefinition))
                {
                    return parameterGroup.GetValue<T>(parameterDefinition, getValueSettings);
                }
            }

            return default;
        }

        /// <summary>
        /// Removes the parameter matching the specified definition from the collection.
        /// </summary>
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