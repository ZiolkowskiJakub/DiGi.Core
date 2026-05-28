using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a one-to-many directional relationship between IUniqueObject instances.</summary>
    public class OneToManyDirectionalRelation : OneToManyRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance from unique references.</summary>
        public OneToManyDirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        public OneToManyDirectionalRelation(OneToManyDirectionalRelation? oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        public OneToManyDirectionalRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        public OneToManyDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>
    /// One To One Directional Relation
    /// </summary>
    /// <typeparam name="XUniqueObject">Parent Unique Object</typeparam>
    /// <typeparam name="YUniqueObject">Related Unique Object</typeparam>
    public class OneToManyDirectionalRelation<XUniqueObject, YUniqueObject> : OneToManyRelation<XUniqueObject, YUniqueObject>, IDirectionalRelation<XUniqueObject, YUniqueObject> where XUniqueObject : IUniqueObject where YUniqueObject : IUniqueObject
    {
        /// <summary>Creates a new instance from unique references.</summary>
        public OneToManyDirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        public OneToManyDirectionalRelation(OneToManyDirectionalRelation<XUniqueObject, YUniqueObject>? oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        public OneToManyDirectionalRelation(XUniqueObject? uniqueObject_From, IEnumerable<YUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        public OneToManyDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}