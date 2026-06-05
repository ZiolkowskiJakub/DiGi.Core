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
        /// <param name="relation">The relation instance to copy from.</param>
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
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public Relation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Gets a list containing all unique references in this relation.</summary>
        [JsonIgnore]
        public abstract List<IUniqueReference>? UniqueReferences { get; }

        /// <summary>Adds a unique reference to the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation where the reference should be added.</param>
        /// <param name="uniqueReference">The unique reference to add.</param>
        /// <returns>True if the reference was successfully added; otherwise, false.</returns>
        public abstract bool Add(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        /// <param name="relationSide">The side of the relation to search.</param>
        /// <param name="uniqueReference">The unique reference to locate within the relation.</param>
        /// <returns>True if the specified unique reference is found on the given side; otherwise, false.</returns>
        public abstract bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Gets the type of the object on the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation to retrieve the type for.</param>
        /// <returns>The type of the object on the specified side, or null if no type is associated with that side.</returns>
        public abstract Type? GetType(RelationSide relationSide);

        /// <summary>Determines whether the relation has a reference on the specified side.</summary>
        /// <param name="relationSide">The side of the relation to check for a reference.</param>
        /// <returns>True if the relation has a reference on the specified side; otherwise, false.</returns>
        public abstract bool Has(RelationSide relationSide);

        /// <summary>Removes a unique reference from the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation to remove the reference from.</param>
        /// <param name="uniqueReference">The unique reference to remove.</param>
        /// <returns>True if the reference was successfully removed; otherwise, false.</returns>
        public abstract bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference);

        /// <summary>Removes multiple unique references from the specified side of the relation.</summary>
        /// <typeparam name="TUniqueReference">The type of the unique reference being removed.</typeparam>
        /// <param name="relationSide">The side of the relation from which to remove references.</param>
        /// <param name="uniqueReferences">The collection of unique references to be removed.</param>
        /// <returns>A list of the removed unique references, or <c>null</c> if no references were removed.</returns>
        public abstract List<TUniqueReference>? Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference>? uniqueReferences) where TUniqueReference : IUniqueReference;
    }

    /// <summary>Represents an abstract relationship between two types of unique objects.</summary>
    /// <typeparam name="From">The type of the source object in the relation.</typeparam>
    /// <typeparam name="To">The type of the destination object in the relation.</typeparam>
    public abstract class Relation<From, To> : Relation, IRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        /// <summary>Creates a new instance of the Relation class by copying another instance.</summary>
        /// <param name="relation">The relation instance to copy from.</param>
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
        /// <param name="jsonObject">The JSON object to initialize the relation from.</param>
        public Relation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the type associated with the specified relation side.
        /// </summary>
        /// <param name="relationSide">The side of the relation to retrieve the type for.</param>
        /// <returns>The type associated with the specified relation side, or <c>null</c> if not found.</returns>
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