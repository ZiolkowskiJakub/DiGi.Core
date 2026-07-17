using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.Core.Relation
{
    public static partial class Create
    {
        /// <summary>Rebuilds a <see cref="Classes.RelationListClusterReference"/> from the segments of its string form.</summary>
        /// <param name="segments">The segments: the first key, the second key, then the index.</param>
        /// <returns>The reference, or <c>null</c> if the segments do not describe one.</returns>
        [ReferenceFactory(typeof(Classes.RelationListClusterReference), Kind = Constants.ReferenceKind.RelationListCluster)]
        public static IReference? RelationListClusterReference(IReadOnlyList<string?>? segments)
        {
            if (segments == null || segments.Count != 3)
            {
                return null;
            }

            if (!int.TryParse(Core.Query.Unescaped(segments[2]), NumberStyles.Integer, CultureInfo.InvariantCulture, out int index))
            {
                return null;
            }

            return new Classes.RelationListClusterReference(
                Core.Query.Reference<TypeReference>(segments[0]),
                Core.Query.Reference<TypeReference>(segments[1]),
                index);
        }
    }
}
