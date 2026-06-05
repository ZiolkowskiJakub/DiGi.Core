using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a one-to-one relationship between two IUniqueObject instances.</summary>
    public abstract class OneToOneRelation : OneToOneRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the OneToOneRelation class by copying another instance.</summary>
        /// <param name="oneToOneRelation">The existing OneToOneRelation instance to copy from.</param>
        public OneToOneRelation(OneToOneRelation? oneToOneRelation)
            : base(oneToOneRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The source unique reference for the relation.</param>
        /// <param name="uniqueReference_To">The destination unique reference for the relation.</param>
        public OneToOneRelation(UniqueReference? uniqueReference_From, UniqueReference? uniqueReference_To)
            : base(uniqueReference_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object for the relation.</param>
        /// <param name="uniqueObject_To">The destination unique object for the relation.</param>
        public OneToOneRelation(IUniqueObject? uniqueObject_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObject_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object used to initialize the relation.</param>
        public OneToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents a one-to-one relationship between two unique object instances.</summary>
    /// <typeparam name="From">The type of the source object.</typeparam>
    /// <typeparam name="To">The type of the target object.</typeparam>
    public abstract class OneToOneRelation<From, To> : Relation<From, To>, IOneToOneRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private IUniqueReference? uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private IUniqueReference? uniqueReference_To;

        /// <summary>Creates a new instance of the OneToOneRelation class by copying another instance.</summary>
        /// <param name="oneToOneRelation">The existing relation to copy from.</param>
        public OneToOneRelation(OneToOneRelation<From, To>? oneToOneRelation)
            : base()
        {
            uniqueReference_From = oneToOneRelation?.uniqueReference_From?.Clone<IUniqueReference>();
            uniqueReference_To = oneToOneRelation?.uniqueReference_To?.Clone<IUniqueReference>();
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from unique references.</summary>
        /// <param name="uniqueReference_From">The source unique reference.</param>
        /// <param name="uniqueReference_To">The target unique reference.</param>
        public OneToOneRelation(IUniqueReference? uniqueReference_From, IUniqueReference? uniqueReference_To)
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<IUniqueReference>();
            this.uniqueReference_To = uniqueReference_To?.Clone<IUniqueReference>();
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from unique objects.</summary>
        /// <param name="uniqueObject_From">The source unique object.</param>
        /// <param name="uniqueObject_To">The target unique object.</param>
        public OneToOneRelation(From? uniqueObject_From, To? uniqueObject_To)
        {
            uniqueReference_From = uniqueObject_From == null ? null : Create.UniqueReference(uniqueObject_From);
            uniqueReference_To = uniqueObject_To == null ? null : Create.UniqueReference(uniqueObject_To);
        }

        /// <summary>Creates a new instance of the OneToOneRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public OneToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Gets the unique reference from the source object.</summary>
        [JsonIgnore]
        public IUniqueReference? UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<IUniqueReference>();
            }
        }

        /// <summary>Gets the unique reference to the target object.</summary>
        [JsonIgnore]
        public IUniqueReference? UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<IUniqueReference>();
            }
        }

        /// <summary>Gets a list containing all unique references in this relation.</summary>
        [JsonIgnore]
        public override List<IUniqueReference>? UniqueReferences
        {
            get
            {
                List<IUniqueReference> result = [];
                if (uniqueReference_From != null)
                {
                    IUniqueReference? uniqueReference = uniqueReference_From.Clone<IUniqueReference>();
                    if (uniqueReference != null)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if (uniqueReference_To != null)
                {
                    IUniqueReference? uniqueReference = uniqueReference_To.Clone<IUniqueReference>();
                    if (uniqueReference != null)
                    {
                        result.Add(uniqueReference);
                    }
                }

                return result;
            }
        }

        /// <summary>Adds a unique reference to the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation to add the reference to.</param>
        /// <param name="uniqueReference">The unique reference to add.</param>
        /// <returns>True if the reference was successfully added; otherwise, false.</returns>
        public override bool Add(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null || relationSide == RelationSide.Undefined)
            {
                return false;
            }

            if (relationSide == RelationSide.To)
            {
                uniqueReference_To = uniqueReference;
                return true;
            }

            if (relationSide == RelationSide.From)
            {
                uniqueReference_From = uniqueReference;
                return true;
            }

            return true;
        }

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        /// <param name="relationSide">The side of the relation to check.</param>
        /// <param name="uniqueReference">The unique reference to locate.</param>
        /// <returns>True if the relation contains the specified unique reference on the given side; otherwise, false.</returns>
        public override bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From != null)
                {
                    result = uniqueReference.Equals(uniqueReference_From);
                }
            }

            if (result || uniqueReference_To is null)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference.Equals(uniqueReference_To);
            }

            return result;
        }

        /// <summary>Determines whether the relation has a reference on the specified side.</summary>
        /// <param name="relationSide">The side of the relation to check.</param>
        /// <returns>True if the relation has a reference on the specified side; otherwise, false.</returns>
        public override bool Has(RelationSide relationSide)
        {
            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_From != null;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_To != null;
            }

            return result;
        }

        /// <summary>Removes a unique reference from the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation to remove the reference from.</param>
        /// <param name="uniqueReference">The unique reference to remove.</param>
        /// <returns>True if the reference was successfully removed; otherwise, false.</returns>
        public override bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_To != null && uniqueReference.Equals(uniqueReference_To))
                {
                    uniqueReference_To = null;
                    result = true;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From != null && uniqueReference.Equals(uniqueReference_From))
                {
                    uniqueReference_From = null;
                    result = true;
                }
            }

            return result;
        }

        /// <summary>Removes multiple unique references from the specified side of the relation.</summary>
        /// <typeparam name="TUniqueReference">The type of the unique reference.</typeparam>
        /// <param name="relationSide">The side of the relation to remove references from.</param>
        /// <param name="uniqueReferences">The collection of unique references to remove.</param>
        /// <returns>A list of removed unique references, or null if none were removed.</returns>
        public override List<TUniqueReference>? Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference>? uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<TUniqueReference> result = [];
            if (uniqueReferences.Count() == 0)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_To is TUniqueReference uniqueReference_Temp_1)
                {
                    if (uniqueReferences.Find(x => x is not null && uniqueReference_To.Equals(x)) != null)
                    {
                        result.Add(uniqueReference_Temp_1);
                        uniqueReference_To = null;
                    }
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From is TUniqueReference uniqueReference_Temp_2)
                {
                    if (uniqueReferences.Find(x => x is not null && uniqueReference_From.Equals(x)) != null)
                    {
                        result.Add(uniqueReference_Temp_2);
                        uniqueReference_From = null;
                    }
                }
            }

            return result;
        }
    }
}