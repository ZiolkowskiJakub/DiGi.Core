namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to retrieve the unique identifier of the specified object.
        /// </summary>
        /// <param name="object">The object whose unique ID to retrieve.</param>
        /// <param name="uniqueId">When this method returns, contains the unique identifier string, or null if it could not be determined.</param>
        /// <returns>True if the unique ID was successfully retrieved; otherwise, false.</returns>
        public static bool TryGetUniqueId(this object? @object, out string? uniqueId)
        {
            uniqueId = null;

            if (@object == null)
            {
                return false;
            }

            uniqueId = UniqueId(@object as dynamic);
            return uniqueId != null;
        }
    }
}