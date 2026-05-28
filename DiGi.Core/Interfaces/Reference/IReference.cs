using System;
 
namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that serves as a reference to another object.</summary>
    public interface IReference : IObject, IEquatable<IReference>
    {
    }
}