using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Creates a duplicate of an IGuidObject, optionally assigning it a new Guid.
        /// </summary>
        /// <typeparam name="TGuidObject">The type of the GUID object.</typeparam>
        /// <param name="guidObject">The object to duplicate.</param>
        /// <param name="guid">The optional new GUID to assign to the duplicate.</param>
        /// <returns>A duplicated object, or default if the duplication fails.</returns>
        public static TGuidObject? Duplicate<TGuidObject>(this TGuidObject? guidObject, Guid? guid = null) where TGuidObject : IGuidObject
        {
            IGuidObject? result = guidObject?.Duplicate(guid);

            return result is TGuidObject guidObject_Temp ? guidObject_Temp : default;
        }
    }
}