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
        public OneToManyBidirectionalRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique references.</summary>
        public OneToManyBidirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance.</summary>
        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation? oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object.</summary>
        public OneToManyBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents a bidirectional one-to-many relationship between two types of unique objects.</summary>
    public class OneToManyBidirectionalRelation<From, To> : OneToManyRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique objects.</summary>
        public OneToManyBidirectionalRelation(From? uniqueObject_From, IEnumerable<To>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from unique references.</summary>
        public OneToManyBidirectionalRelation(UniqueReference? uniqueReference_From, IEnumerable<UniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class by copying another instance.</summary>
        public OneToManyBidirectionalRelation(OneToManyBidirectionalRelation<From, To>? oneToManyBidirectionalRelation)
            : base(oneToManyBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToManyBidirectionalRelation class from a JSON object.</summary>
        public OneToManyBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}