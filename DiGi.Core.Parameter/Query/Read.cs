using DiGi.Core.Parameter.Enums;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        /// <summary>
        /// Determines whether the specified access type allows read operations.
        /// </summary>
        public static bool Read(this AccessType accessType)
        {
            return accessType == AccessType.Read || accessType == AccessType.ReadWrite;
        }
    }
}