using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class OneToManyDirectionalRelation : OneToManyRelation<IUniqueObject, IUniqueObject>
    {
        public OneToManyDirectionalRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            :base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyDirectionalRelation(OneToManyDirectionalRelation oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {

        }

        public OneToManyDirectionalRelation(IUniqueObject uniqueObject_From, IEnumerable<IUniqueObject> uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToManyDirectionalRelation(this);
        }
    }

    /// <summary>
    /// One To One Directional Relation
    /// </summary>
    /// <typeparam name="XUniqueObject">Parent Unique Object</typeparam>
    /// <typeparam name="YUniqueObject">Related Unique Object</typeparam>
    public class OneToManyDirectionalRelation<XUniqueObject, YUniqueObject> : OneToManyRelation<XUniqueObject, YUniqueObject>, IDirectionalRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
        
        
        public OneToManyDirectionalRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyDirectionalRelation(OneToManyDirectionalRelation<XUniqueObject, YUniqueObject> oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {

        }

        public OneToManyDirectionalRelation(XUniqueObject uniqueObject_From, IEnumerable<YUniqueObject> uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyDirectionalRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new OneToManyDirectionalRelation<XUniqueObject, YUniqueObject>(this);
        }
    }
}
