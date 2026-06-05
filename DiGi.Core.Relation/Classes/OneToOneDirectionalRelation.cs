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
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReference_To">The destination unique reference.</param>
        public OneToOneDirectionalRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        /// <param name="oneToOneDirectionalRelation">The relation instance to copy from.</param>
        public OneToOneDirectionalRelation(OneToOneDirectionalRelation? oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObject_To">The destination unique object.</param>
        public OneToOneDirectionalRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the instance from.</param>
        public OneToOneDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a shallow copy of this relation.</summary>
        /// <returns>A shallow copy of the current relation as an <see cref="ISerializableObject"/>.</returns>
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
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReference_To">The destination unique reference.</param>
        public OneToOneDirectionalRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance by copying another instance.</summary>
        /// <param name="oneToOneDirectionalRelation">The relation instance to copy from.</param>
        public OneToOneDirectionalRelation(OneToOneDirectionalRelation<XUniqueObject, YUniqueObject>? oneToOneDirectionalRelation)
            : base(oneToOneDirectionalRelation)
        {
        }

        /// <summary>Creates a new instance from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObject_To">The destination unique object.</param>
        public OneToOneDirectionalRelation(XUniqueObject? uniqueObject_From, YUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the instance from.</param>
        public OneToOneDirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}