using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class OneToOneBidirectionalRelation : OneToOneBidirectionalRelation<IUniqueObject, IUniqueObject>
    {
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {

        }

        public OneToOneBidirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneBidirectionalRelation(IUniqueObject uniqueObject_From, IUniqueObject uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
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

    public class OneToOneBidirectionalRelation<From, To> : OneToOneRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation<From, To> oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {

        }

        public OneToOneBidirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneBidirectionalRelation(From uniqueObject_From, To uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneBidirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToOneBidirectionalRelation<From, To>(this);
        }
    }
}
