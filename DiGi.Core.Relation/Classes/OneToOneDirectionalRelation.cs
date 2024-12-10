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

    /// <summary>
    /// One To One Directional Relation
    /// </summary>
    /// <typeparam name="XUniqueObject">Parent Unique Object</typeparam>
    /// <typeparam name="YUniqueObject">Related Unique Object</typeparam>
    public class OneToOneDirectionalRelation<XUniqueObject, YUniqueObject> : OneToOneRelation<XUniqueObject, YUniqueObject>, IDirectionalRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
        public OneToOneDirectionalRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {

        }

        public OneToOneDirectionalRelation(OneToOneDirectionalRelation<XUniqueObject, YUniqueObject> oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {

        }

        public OneToOneDirectionalRelation(XUniqueObject uniqueObject_From, YUniqueObject uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {

        }

        public OneToOneDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
