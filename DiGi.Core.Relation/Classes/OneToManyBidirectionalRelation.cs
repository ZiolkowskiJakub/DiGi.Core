using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class OneToManyBidirectionalRelation : OneToManyBidirectionalRelation<IUniqueObject, IUniqueObject>
    {
        public OneToManyBidirectionalRelation(IUniqueObject uniqueObject_From, IEnumerable<IUniqueObject> uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyBidirectionalRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            :base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {

        }

        public OneToManyBidirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public class OneToManyBidirectionalRelation<From, To> : OneToManyRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        public OneToManyBidirectionalRelation(From uniqueObject_From, IEnumerable<To> uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyBidirectionalRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation<From, To> oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {

        }

        public OneToManyBidirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
