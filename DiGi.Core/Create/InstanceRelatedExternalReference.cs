using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds an <see cref="Classes.InstanceRelatedExternalReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the source, then the nested instance-related reference.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(InstanceRelatedExternalReference), Kind = Constants.Reference.Kind.InstanceExternal)]
        public static IReference? InstanceRelatedExternalReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            if (Query.Reference(segments[1]) is not IInstanceRelatedSerializableReference instanceRelatedSerializableReference)
            {
                return null;
            }

            return new InstanceRelatedExternalReference(Query.Unescaped(segments[0]), instanceRelatedSerializableReference);
        }
    }
}
