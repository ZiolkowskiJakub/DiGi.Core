using System;

namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object uniquely identified by a GUID.</summary>
    public interface IGuidObject : IUniqueObject
    {
        /// <summary>Gets the GUID of the object.</summary>
        Guid Guid { get; }

        /// <summary>Creates a duplicate of the object with the specified GUID.</summary>
        /// <param name="guid">The GUID to use for the duplicated object. If null, a new GUID is generated.</param>
        /// <returns>A duplicated IGuidObject.</returns>
        IGuidObject? Duplicate(Guid? guid = null);
    }
}