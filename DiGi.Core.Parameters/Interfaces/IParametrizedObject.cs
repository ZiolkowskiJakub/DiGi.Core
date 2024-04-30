using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Parameters.Interfaces
{
    public interface IParametrizedObject : ISerializableObject
    {
        bool Contains(IParameterDefinition parameterDefinition);

        object GetValue(IParameterDefinition parameterDefinition);

        List<IParameterDefinition> GetParameterDefinitions(string parameterName, TextComparisonType textComparisonType = TextComparisonType.Equals, bool caseSensitive = true);

        bool Remove(IParameterDefinition parameterDefinition);

        bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null);

        bool TryGetValue(IParameterDefinition parameterDefinition, out object value);

        bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value);
    }
}
