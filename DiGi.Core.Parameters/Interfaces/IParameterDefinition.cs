using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.Parameters
{
    public interface IParameterDefinition : ISerializableObject, IEquatable<IParameterDefinition>
    {
        string UniqueId { get; }

        string Name { get; }

        Enums.ParameterType ParameterType { get; }

        bool IsValid(object value);

        string GroupName { get; }
    }
}
