using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Globalization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a reference to a relation list cluster identified by two type references and an index.</summary>
    /// <example>
    /// Renders and parses (via <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator, the
    /// two nested type references, then the index:
    /// <code>RelationListCluster::(Type::DiGi.GIS.Classes.Building2D,DiGi.GIS)::(Type::DiGi.GIS.Classes.Space,DiGi.GIS)::3</code>
    /// </example>
    /// <remarks>
    /// TODO [ReferenceFormat]: This type renders its own string by hand. It derives from
    /// <see cref="ListClusterReference{TKey_1, TKey_2}"/>, which implements <see cref="IReference"/> directly rather
    /// than deriving from <see cref="SerializableReference"/>, so it does not inherit the sealed ToString that
    /// guarantees the grammar. Keep <see cref="ToString"/> below in step with
    /// <see cref="Convert.ToSystem_String(System.Type?, IEnumerable{string?})"/> and with its factory in
    /// Create/RelationListClusterReference.cs. The ReferenceKind facts assert this type still round-trips.
    /// </remarks>
    public class RelationListClusterReference(TypeReference? key_1, TypeReference? key_2, int index) : ListClusterReference<TypeReference, TypeReference>(key_1, key_2, index)
    {
        /// <summary>Determines whether this instance equals the specified reference.</summary>
        /// <param name="reference">The reference to compare with this instance.</param>
        /// <returns>True if the instances are equal; otherwise, false.</returns>
        public override bool Equals(IReference? reference)
        {
            if (reference is null)
            {
                return false;
            }

            if (ReferenceEquals(this, reference))
            {
                return true;
            }

            // A hash match alone made this true across unrelated reference types on any collision, and asymmetric
            // against types that check more. Compare the rendered form, which is the identity.
            if (reference.GetType() != GetType())
            {
                return false;
            }

            return reference.GetHashCode() == GetHashCode() && reference.ToString() == ToString();
        }

        /// <summary>Returns the reference string: this type's discriminator, both keys, then the index.</summary>
        /// <returns>The reference string.</returns>
        public override string? ToString()
        {
            return Convert.ToSystem_String(
                GetType(),
                [Core.Query.Segment(Key_1), Core.Query.Segment(Key_2), Core.Query.Segment(Index.ToString(CultureInfo.InvariantCulture))]);
        }

        /// <summary>Returns the hash code for this instance.</summary>
        /// <returns>The hash code for this instance.</returns>
        public override int GetHashCode()
        {
            List<int> values = [];
            if (Key_1 != null)
            {
                values.Add(Key_1.GetHashCode());
            }

            if (Key_2 != null)
            {
                values.Add(Key_2.GetHashCode());
            }

            values.Add(Index);

            return Core.Query.HashCode([.. values]);
        }
    }
}