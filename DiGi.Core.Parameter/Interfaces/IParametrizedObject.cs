using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Parameter.Interfaces
{
    public interface IParametrizedObject : ISerializableObject
    {
        bool Contains(IParameterDefinition parameterDefinition);

        object GetValue(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null);

        T GetValue<T>(IParameterDefinition parameterDefinition, GetValueSettings getValueSettings = null);

        List<IParameterDefinition> GetParameterDefinitions(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true);

        bool Remove(IParameterDefinition parameterDefinition);

        bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null);

        bool TryGetValue(IParameterDefinition parameterDefinition, out object value, GetValueSettings getValueSettings = null);

        bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value, GetValueSettings getValueSettings = null);
    }
}
