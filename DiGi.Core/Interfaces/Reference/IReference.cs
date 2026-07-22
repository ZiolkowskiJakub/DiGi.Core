using System;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that serves as a reference to another object.</summary>
    /// <remarks>
    /// Compare two <see cref="IReference"/> values with <see cref="Query.Equals(IReference?, IReference?)"/>, NEVER with
    /// <c>==</c> or <c>!=</c>. The equality operators are declared on <see cref="Classes.SerializableReference"/> and
    /// C# gathers operator candidates from the static types of the operands - an interface contributes none - so
    /// <c>reference_1 == reference_2</c> compiles to plain reference equality and is false for two equal references
    /// held in separate instances. The operators do apply, correctly, as soon as one operand is statically typed as a
    /// <see cref="Classes.SerializableReference"/> derived type.
    /// <para>Beware of properties that return <c>Query.Clone(...)</c>: they hand back a new instance on every read, so
    /// even comparing such a property with itself using <c>==</c> yields false. Read it into a local first.</para>
    /// <para><see cref="System.Collections.Generic.Dictionary{TKey, TValue}"/>, <c>HashSet</c> and <c>List.Contains</c>
    /// are safe - they route through <see cref="IEquatable{T}"/> and <c>GetHashCode</c>.</para>
    /// <para>Not every implementation derives from <see cref="Classes.SerializableReference"/>, so do not cast to it.</para>
    /// </remarks>
    public interface IReference : IObject, IEquatable<IReference>
    {
    }
}