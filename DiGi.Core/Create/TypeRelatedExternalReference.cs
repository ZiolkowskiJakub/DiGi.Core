using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.TypeRelatedExternalReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the source, then the nested type-related reference.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(TypeRelatedExternalReference), Kind = Constants.Reference.Kind.TypeExternal)]
        public static IReference? TypeRelatedExternalReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            // The nested slot is polymorphic, so a string naming an incompatible reference must fail the parse
            // rather than silently produce an external reference with no target.
            if (Query.Reference(segments[1]) is not ITypeRelatedSerializableReference typeRelatedSerializableReference)
            {
                return null;
            }

            return new TypeRelatedExternalReference(Query.Unescaped(segments[0]), typeRelatedSerializableReference);
        }
    }
}
