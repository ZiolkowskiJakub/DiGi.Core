using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class OneToOneBidirectionalRelation : OneToOneRelation, IBidirectionalRelation
    {
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {

        }

        public OneToOneBidirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneBidirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToOneBidirectionalRelation(this);
        }
    }
}
