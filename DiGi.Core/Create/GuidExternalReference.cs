using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.GuidExternalReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the source, then the nested GUID reference.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        /// <remarks>
        /// Renders identically to <see cref="Classes.InstanceRelatedExternalReference"/> apart from the
        /// discriminator, which is the only thing that keeps the two apart on the way back.
        /// </remarks>
        [ReferenceFactory(typeof(GuidExternalReference), Kind = Constants.Reference.Kind.GuidExternal)]
        public static IReference? GuidExternalReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            GuidReference? guidReference = Query.Reference<GuidReference>(segments[1]);
            if (guidReference == null)
            {
                return null;
            }

            return new GuidExternalReference(Query.Unescaped(segments[0]), guidReference);
        }
    }
}
