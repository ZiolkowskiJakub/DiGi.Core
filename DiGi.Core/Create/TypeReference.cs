using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a type reference for the specified type.</summary>
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