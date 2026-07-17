using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.GuidPropertyReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the nested GUID reference, then the property name.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(GuidPropertyReference), Kind = Constants.Reference.Kind.GuidProperty)]
        public static IReference? GuidPropertyReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 2)
            {
                return null;
            }

            return new GuidPropertyReference(Query.Reference<GuidReference>(segments[0]), Query.Unescaped(segments[1]));
        }
    }
}
