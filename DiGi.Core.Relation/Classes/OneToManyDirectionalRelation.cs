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
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReferences_To">The collection of destination unique references.</param>
        public OneToManyDirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        /// <param name="oneToManyDirectionalRelation">The existing relation to copy from.</param>
        public OneToManyDirectionalRelation(OneToManyDirectionalRelation? oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObjects_To">The collection of destination unique objects.</param>
        public OneToManyDirectionalRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the instance from.</param>
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
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReferences_To">The collection of destination unique references.</param>
        public OneToManyDirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        /// <param name="oneToManyDirectionalRelation">The existing relation to copy from.</param>
        public OneToManyDirectionalRelation(OneToManyDirectionalRelation<XUniqueObject, YUniqueObject>? oneToManyDirectionalRelation)
            : base(oneToManyDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObjects_To">The collection of destination unique objects.</param>
        public OneToManyDirectionalRelation(XUniqueObject? uniqueObject_From, IEnumerable<YUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the instance from.</param>
        public OneToManyDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}