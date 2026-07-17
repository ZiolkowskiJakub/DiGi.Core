using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.ComplexReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: one nested reference per step of the chain, in order.</param>
        /// <returns>The reference, or <c>null</c> if any segment is not a nested serializable reference.</returns>
        /// <remarks>
        /// The only factory accepting a variable number of segments, because a chain has no fixed depth. No segments
        /// yields an empty chain, which is what an empty chain renders back to.
        /// </remarks>
        [ReferenceFactory(typeof(ComplexReference), Kind = Constants.Reference.Kind.Complex)]
        public static IReference? ComplexReference(IReadOnlyList<string?>? segments)
        {
            List<ISerializableReference?> references = [];

            if (segments == null)
            {
                // Explicitly typed: a collection expression passed straight to the constructor is ambiguous with the
                // JsonObject overload, which is also collection-initializable.
                return new ComplexReference(references);
            }

            foreach (string? segment in segments)
            {
                // A step that does not parse makes the whole chain wrong. Dropping it would silently return a path
                // that addresses something else.
                if (Query.Reference(segment) is not ISerializableReference serializableReference)
                {
                    return null;
                }

                references.Add(serializableReference);
            }

            return new ComplexReference(references);
        }
    }
}
