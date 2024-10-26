using DiGi.Core.Classes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationListClusterReference : ListClusterReference<TypeReference, TypeReference>
    {
        public RelationListClusterReference(TypeReference key_1, TypeReference key_2, int index)
            :base(key_1, key_2, index)
        {

        }
    }
}
