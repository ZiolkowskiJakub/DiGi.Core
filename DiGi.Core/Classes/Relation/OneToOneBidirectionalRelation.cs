using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
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
