using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a bidirectional one-to-one relationship between two IUniqueObject instances.</summary>
    public class OneToOneBidirectionalRelation : OneToOneBidirectionalRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance.</summary>
        /// <param name="oneToOneBidirectionalRelation">The existing relation to copy from.</param>
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation? oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReference_To">The destination unique reference.</param>
        public OneToOneBidirectionalRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObject_To">The destination unique object.</param>
        public OneToOneBidirectionalRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public OneToOneBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents a bidirectional one-to-one relationship between two unique object instances.</summary>
    /// <typeparam name="From">The type of the source object.</typeparam>
    /// <typeparam name="To">The type of the destination object.</typeparam>
    public class OneToOneBidirectionalRelation<From, To> : OneToOneRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance.</summary>
        /// <param name="oneToOneBidirectionalRelation">The existing relation to copy from.</param>
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation<From, To>? oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReference_To">The destination unique reference.</param>
        public OneToOneBidirectionalRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObject_To">The destination unique object.</param>
        public OneToOneBidirectionalRelation(From? uniqueObject_From, To? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public OneToOneBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}