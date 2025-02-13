using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation.Classes
{
    public class RelationListClusterReference : ListClusterReference<TypeReference, TypeReference>
    {
        public RelationListClusterReference(TypeReference key_1, TypeReference key_2, int index)
            :base(key_1, key_2, index)
        {

        }

        public override bool Equals(IReference reference)
        {
            if(reference == null)
            {
                return false;
            }

            return reference.GetHashCode() == GetHashCode();
        }

        public override int GetHashCode()
        {
            List<int> values = new List<int>();
            if(Key_1 != null)
            {
                values.Add(Key_1.GetHashCode());
            }

            if (Key_2 != null)
            {
                values.Add(Key_2.GetHashCode());
            }

            values.Add(Index);

            return Core.Query.HashCode(values.ToArray());
        }

    }
}
