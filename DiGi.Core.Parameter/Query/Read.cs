using DiGi.Core.Parameter.Enums;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified access type allows read operations.
        /// </summary>
        /// <param name="accessType">The access type to check for read permissions.</param>
        /// <returns>True if the access type allows read operations; otherwise, false.</returns>
        public static bool Read(this AccessType accessType)
        {
            return accessType == AccessType.Read || accessType == AccessType.ReadWrite;
        }
    }
}