using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents an abstract relationship between unique objects.</summary>
    public abstract class Relation : SerializableObject, IRelation
    {
        /// <summary>Creates a new instance of the Relation class by copying another instance.</summary>
        public Relation(Relation? relation)
            : base(relation)
        {
        }

        /// <summary>Creates a new instance of the Relation class.</summary>
        public Relation()
            : base()
        {
        }

        /// <summary>Creates a new instance of the Relation class from a JSON object.</summary>
        public Relation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Gets a list containing all unique references in this relation.</summary>
        [JsonIgnore]
        public abstract List<IUniqueReference>? UniqueReferences { get; }

        /// <summary>Adds a unique reference to the specified side of the relation.</summary>
        public abstract bool Add(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        public abstract bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Gets the type of the object on the specified side of the relation.</summary>
        public abstract Type? GetType(RelationSide relationSide);

        /// <summary>Determines whether the relation has a reference on the specified side.</summary>
        public abstract bool Has(RelationSide relationSide);

        /// <summary>Removes a unique reference from the specified side of the relation.</summary>
        public abstract bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Removes multiple unique references from the specified side of the relation.</summary>
        public abstract List<TUniqueReference>? Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference>? uniqueReferences) where TUniqueReference : IUniqueReference;
    }

    /// <summary>Represents an abstract relationship between two types of unique objects.</summary>
    public abstract class Relation<From, To> : Relation, IRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the Relation class by copying another instance.</summary>
        public Relation(Relation<From, To>? relation)
            : base(relation)
        {
        }

        /// <summary>Creates a new instance of the Relation class.</summary>
        public Relation()
            : base()
        {
        }

        /// <summary>Creates a new instance of the Relation class from a JSON object.</summary>
        public Relation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public override Type? GetType(RelationSide relationSide)
        {
            switch (relationSide)
            {
                case RelationSide.From:
                    return typeof(From);

                case RelationSide.To:
                    return typeof(To);

                case RelationSide.Undefined:
                    break;
            }

            return null;
        }
    }
}