using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class OneToOneDirectionalRelation : OneToOneRelation<IUniqueObject, IUniqueObject>
    {
        public OneToOneDirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            :base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneDirectionalRelation(OneToOneDirectionalRelation oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {

        }

        public OneToOneDirectionalRelation(IUniqueObject uniqueObject_From, IUniqueObject uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToOneDirectionalRelation(this);
        }
    }

    public class OneToOneDirectionalRelation<X, Y> : OneToOneRelation<X, Y>, IDirectionalRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {
        
        
        public OneToOneDirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneDirectionalRelation(OneToOneDirectionalRelation<X, Y> oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {

        }

        public OneToOneDirectionalRelation(X uniqueObject_From, Y uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToOneDirectionalRelation<X, Y>(this);
        }
    }
}
