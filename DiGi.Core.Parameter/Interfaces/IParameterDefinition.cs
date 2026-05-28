using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.Parameter.Interfaces
{
    /// <summary>Defines the contract for a parameter definition.</summary>
    public interface IParameterDefinition : ISerializableObject, IEquatable<IParameterDefinition>, INamedObject
    {
        /// <summary>Gets the unique identifier of the parameter definition.</summary>
        string? UniqueId { get; }
 
        /// <summary>Gets the type of the parameter.</summary>
        Enums.ParameterType ParameterType { get; }
 
        /// <summary>Determines whether the specified value is valid for this parameter definition.</summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if the value is valid, false otherwise.</returns>
        bool IsValid(object? value);
 
        /// <summary>Gets the group name to which this parameter belongs.</summary>
        string? GroupName { get; }
    }
}