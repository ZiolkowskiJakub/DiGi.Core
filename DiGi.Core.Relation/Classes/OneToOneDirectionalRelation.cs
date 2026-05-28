using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a one-to-one directional relationship between IUniqueObject instances.</summary>
    public class OneToOneDirectionalRelation : OneToOneRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance from unique references.</summary>
        public OneToOneDirectionalRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        public OneToOneDirectionalRelation(OneToOneDirectionalRelation? oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        public OneToOneDirectionalRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        public OneToOneDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a shallow copy of this relation.</summary>
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
        /// <summary>Creates a new instance from unique references.</summary>
        public OneToOneDirectionalRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        public OneToOneDirectionalRelation(OneToOneDirectionalRelation<XUniqueObject, YUniqueObject>? oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        public OneToOneDirectionalRelation(XUniqueObject? uniqueObject_From, YUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        public OneToOneDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}