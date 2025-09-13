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
    public class ParameterGroupCollection : SerializableObject, IEnumerable<ParameterGroup>
    {
        [JsonIgnore]
        private readonly Dictionary<string, ParameterGroup> dictionary = [];

        public ParameterGroupCollection()
            : base()
        {

        }

        public ParameterGroupCollection(IEnumerable<Parameter>? parameters)
        {
            if(parameters != null)
            {
                foreach(Parameter parameter in parameters)
                {
                    SetValue(parameter);
                }
            }
        }

        public ParameterGroupCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ParameterGroupCollection(ParameterGroupCollection? parameterGroupCollection)
            :base(parameterGroupCollection)
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

        public override ISerializableObject? Clone()
        {
            return new ParameterGroupCollection(this);
        }

        public bool Contains(string? uniqueId)
        {
            if(uniqueId == null)
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

        public bool Contains(IParameterDefinition? parameterDefinition)
        {
            if(parameterDefinition?.UniqueId == null)
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

        public IEnumerator<ParameterGroup> GetEnumerator()
        {
            return GetParameterGroups()?.GetEnumerator() ?? Enumerable.Empty<ParameterGroup>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

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

        public List<IParameterDefinition>? GetParameterDefinitions(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            if(parameterName == null)
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

        public List<TParameterDefinition>? GetParameterDefinitions<TParameterDefinition>(string? parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where TParameterDefinition : IParameterDefinition
        {
            if(parameterName == null)
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

        public object? GetValue(IParameterDefinition? parameterDefinition, GetValueSettings? getValueSettings = null)
        {
            if(parameterDefinition?.UniqueId == null)
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

        public bool SetValue(IParameterDefinition? parameterDefinition, object? value, SetValueSettings? setValueSettings = null)
        {
            if(parameterDefinition == null)
            {
                return false;
            }

            string? groupName = parameterDefinition.GroupName;
            groupName ??= Constans.Names.DefaultGroupName;

            if(!dictionary.TryGetValue(groupName, out ParameterGroup parameterGroup) || parameterGroup == null)
            {
                parameterGroup = new ParameterGroup(groupName);
                dictionary[groupName] = parameterGroup;
            }

            bool result = parameterGroup.SetValue(parameterDefinition, value, setValueSettings);
            if(!result)
            {
                return result;
            }

            dictionary[groupName] = parameterGroup;
            return result;
        }

        public bool SetValue(string? name, object? value, SetValueSettings? setValueSettings = null)
        {
            List<IParameterDefinition>? parameterDefinitions = GetParameterDefinitions(name);
            if(parameterDefinitions != null)
            {
                foreach(IParameterDefinition parameterDefinition in parameterDefinitions)
                {
                    if(SetValue(parameterDefinition, value, setValueSettings))
                    {
                        return true;
                    }
                }
            }

            Parameter? parameter = Create.Parameter(name, value);
            if(parameter == null)
            {
                return false;
            }

            string? groupName = parameter.ParameterDefinition?.GroupName;
            if(groupName == null)
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

        public bool SetValue(Parameter? parameter)
        {
            if(parameter?.UniqueId == null)
            {
                return false;
            }

            string? groupName = parameter.ParameterDefinition?.GroupName;
            groupName ??= Constans.Names.DefaultGroupName;

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

        public bool TryGetValue<T>(IParameterDefinition? parameterDefinition, out T? value, GetValueSettings? getValueSettings = null)
        {
            if(parameterDefinition?.UniqueId == null)
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

        public bool TryGetValue<T>(string? uniqueId, out T? value, GetValueSettings? getValueSettings = null)
        {
            if(uniqueId == null)
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
                if(parameterGroup == null)
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
            if(parameterGroups == null)
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
