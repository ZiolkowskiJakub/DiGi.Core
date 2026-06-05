using DiGi.Core.Parameter.Enums;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified access type allows write operations.
        /// </summary>
        /// <param name="accessType">The access type to evaluate.</param>
        /// <returns>True if the specified access type allows write operations; otherwise, false.</returns>
        public static bool Write(this AccessType accessType)
        {
            return accessType == AccessType.Write || accessType == AccessType.ReadWrite;
        }
    }
}