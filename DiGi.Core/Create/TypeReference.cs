using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

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

        /// <summary>Rebuilds a <see cref="Classes.TypeReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the full type name.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(TypeReference), Kind = Constants.Reference.Kind.Type)]
        public static IReference? TypeReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 1)
            {
                return null;
            }

            return new TypeReference(Query.Unescaped(segments[0]));
        }
    }
}