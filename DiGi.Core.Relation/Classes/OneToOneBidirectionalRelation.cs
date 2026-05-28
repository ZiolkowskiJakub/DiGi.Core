using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a bidirectional one-to-one relationship between two IUniqueObject instances.</summary>
    public class OneToOneBidirectionalRelation : OneToOneBidirectionalRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance.</summary>
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation? oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique references.</summary>
        public OneToOneBidirectionalRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique objects.</summary>
        public OneToOneBidirectionalRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object.</summary>
        public OneToOneBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents a bidirectional one-to-one relationship between two unique object instances.</summary>
    public class OneToOneBidirectionalRelation<From, To> : OneToOneRelation<From, To>, IBidirectionalRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class by copying another instance.</summary>
        public OneToOneBidirectionalRelation(OneToOneBidirectionalRelation<From, To>? oneToOneBidirectionalRelation)
            : base(oneToOneBidirectionalRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique references.</summary>
        public OneToOneBidirectionalRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from unique objects.</summary>
        public OneToOneBidirectionalRelation(From? uniqueObject_From, To? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneBidirectionalRelation class from a JSON object.</summary>
        public OneToOneBidirectionalRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}