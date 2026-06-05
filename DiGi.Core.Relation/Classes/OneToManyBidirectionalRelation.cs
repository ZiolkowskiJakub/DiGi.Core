using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a bidirectional one-to-many relationship between unique objects.</summary>
    public class OneToManyBidirectionalRelation : OneToManyBidirectionalRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The unique object for the 'from' side of the relation.</param>
        /// <param name="uniqueObjects_To">The collection of unique objects for the 'to' side of the relation.</param>
        public OneToManyBidirectionalRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The unique reference for the 'from' side of the relation.</param>
        /// <param name="uniqueReferences_To">The collection of unique references for the 'to' side of the relation.</param>
        public OneToManyBidirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance.</summary>
        /// <param name="oneToManyBidirectionalRelation">The existing relation instance to copy from.</param>
        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation? oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public OneToManyBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents a bidirectional one-to-many relationship between two types of unique objects.</summary>
    /// <typeparam name="From">The type of the object on the 'one' side of the relation.</typeparam>
    /// <typeparam name="To">The type of the objects on the 'many' side of the relation.</typeparam>
    public class OneToManyBidirectionalRelation<From, To> : OneToManyRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The unique object for the 'from' side of the relation.</param>
        /// <param name="uniqueObjects_To">The collection of unique objects for the 'to' side of the relation.</param>
        public OneToManyBidirectionalRelation(From? uniqueObject_From, IEnumerable<To>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The unique reference for the 'from' side of the relation.</param>
        /// <param name="uniqueReferences_To">The collection of unique references for the 'to' side of the relation.</param>
        public OneToManyBidirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance.</summary>
        /// <param name="oneToManyBidirectionalRelation">The existing relation instance to copy from.</param>
        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation<From, To>? oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public OneToManyBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}