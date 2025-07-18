using DiGi.Core.Interfaces;
using DiGi.Core.Parameter.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Parameter.Interfaces
{
    public interface IParametrizedObject : ISerializableObject
    {
        List<TParameterDefinition> GetParameterDefinitions<TParameterDefinition>() where TParameterDefinition : IParameterDefinition;

        bool Remove(IParameterDefinition parameterDefinition);

        bool SetValue(IParameterDefinition parameterDefinition, object value, SetValueSettings setValueSettings = null);

        bool TryGetValue<T>(IParameterDefinition parameterDefinition, out T value, GetValueSettings getValueSettings = null);
    }
}
