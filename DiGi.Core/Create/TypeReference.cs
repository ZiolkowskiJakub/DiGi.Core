using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a type reference for the specified type.</summary>
        /// <param name="type">The type for which to create a type reference.</param>
        /// <returns>A type reference for the specified type, or <c>null</c> if the provided type is null.</returns>
        public static TypeReference? TypeReference(this System.Type? type)
        {
            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return new TypeReference(fullTypeName);
        }
    }
}