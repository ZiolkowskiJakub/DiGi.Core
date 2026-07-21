using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.UniqueIdReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the nested type reference, then the unique identifier.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(UniqueIdReference), Kind = Constants.Reference.Kind.UniqueId)]
        public static IReference? UniqueIdReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            return new UniqueIdReference(Query.Reference<TypeReference>(segments[0]), Query.Unescaped(segments[1]));
        }
    }
}