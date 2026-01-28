using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.Parameter.Interfaces
{
    public interface IParameterDefinition : ISerializableObject, IEquatable<IParameterDefinition>, INamedObject
    {
        string? UniqueId { get; }

        Enums.ParameterType ParameterType { get; }

        bool IsValid(object? value);

        string? GroupName { get; }
    }
}