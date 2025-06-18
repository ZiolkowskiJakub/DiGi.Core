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
    public class ParameterGroups : SerializableObject, IEnumerable<ParameterGroup>
    {
        public Dictionary<string, ParameterGroup> dictionary = new Dictionary<string, ParameterGroup>();

        public ParameterGroups()
            : base()
        {

        }

        public ParameterGroups(IEnumerable<Parameter> parameters)
        {
            if(parameters != null)
            {
                foreach(Parameter parameter in parameters)
                {
                    SetValue(parameter);
                }
            }
        }

        public ParameterGroups(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ParameterGroups(ParameterGroups parameterGroups)
        {
            this.parameterGroups = parameterGroups?.parameterGroups;

        }

        [JsonInclude, JsonPropertyName("ParameterGroups")]
        private List<ParameterGroup> parameterGroups
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

        public override ISerializableObject Clone()
        {
            return new ParameterGroups(this);
        }

        public bool Contains(string uniqueId)
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

        public bool Contains(IParameterDefinition parameterDefinition)
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
            return GetParameterGroups().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<IParameterDefinition> GetParameterDefinitions(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true)
        {
            if(parameterName == null)
            {
                return null;
            }

            List<IParameterDefinition> result = new List<IParameterDefinition>();
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                List<IParameterDefinition> parameterDefinitions = parameterGroup?.GetParameterDefinitions(parameterName, textComparisonType, caseSensitive);
                if (parameterDefinitions != null)
                {
                    result.AddRange(parameterDefinitions);
                }
            }

            return result;
        }

        public List<T> GetParameterDefinitions<T>(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true) where T : IParameterDefinition
        {
            if(parameterName == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                List<T> parameterDefinitions = parameterGroup?.GetParameterDefinitions<T>(parameterName, textComparisonType, caseSensitive);
                if (parameterDefinitions != null)
                {
                    result.AddRange(parameterDefinitions);
                }
            }

            return result;
        }

        public object GetValue(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
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

        public object GetValue(string uniqueId, GetValueSettings getValueSettings = null)
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

        public T GetValue<T>(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null)
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

        public bool Remove(IParameterDefinition parameterDefinition)
        {
            if (parameterDefinition.UniqueId == null)
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

        public bool Remove(string uniqueId)
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

        public bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null)
        {
            if(parameterDefinition == null)
            {
                return false;
            }

            string groupName = parameterDefinition.GroupName;
            if(groupName == null)
            {
                groupName = Constans.Names.DefaultGroupName;
            }

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

        public bool SetValue(string name, object value, SetValueSettings setValueSettings = null)
        {
            List<IParameterDefinition> parameterDefinitions = GetParameterDefinitions(name);
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

            Parameter parameter = Create.Parameter(name, value);
            if(parameter == null)
            {
                return false;
            }

            string groupName = parameter.ParameterDefinition?.GroupName;
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

        public bool SetValue(Parameter parameter)
        {
            if(parameter?.UniqueId == null)
            {
                return false;
            }

            string groupName = parameter.ParameterDefinition?.GroupName;
            if(groupName == null)
            {
                groupName = Constans.Names.DefaultGroupName;
            }

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

        public bool TryGetValue(string uniqueId, out object value, GetValueSettings getValueSettings = null)
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

        public bool TryGetValue(IParameterDefinition parameterDefinition, out object value, GetValueSettings getValueSettings = null)
        {
            if (parameterDefinition.UniqueId == null)
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

        public bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value, GetValueSettings getValueSettings = null)
        {
            if(parameterDefinition.UniqueId == null)
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

        public bool TryGetValue<T>(string uniqueId, out T value, GetValueSettings getValueSettings = null)
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

        private List<ParameterGroup> GetParameterGroups()
        {
            List<ParameterGroup> result = new List<ParameterGroup>();
            foreach (ParameterGroup parameterGroup in dictionary.Values)
            {
                result.Add(parameterGroup == null ? null : new ParameterGroup(parameterGroup));
            }

            return result;
        }

        private void SetParameterGroups(IEnumerable<ParameterGroup> parameterGroups)
        {
            dictionary.Clear();
            if(parameterGroups == null)
            {
                return;
            }

            foreach (ParameterGroup parameterGroup in parameterGroups)
            {
                string name = parameterGroup?.Name;
                if (name == null)
                {
                    continue;
                }

                dictionary[name] = new ParameterGroup(parameterGroup);
            }
        }
    }
}
