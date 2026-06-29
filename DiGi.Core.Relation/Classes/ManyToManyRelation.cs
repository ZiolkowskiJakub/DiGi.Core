using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents an abstract many-to-many relationship between unique objects.</summary>
    public abstract class ManyToManyRelation : ManyToManyRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the ManyToManyRelation class from unique references.</summary>
        /// <param name="uniqueReferences_From">The collection of unique references representing the source side of the relation.</param>
        /// <param name="uniqueReferences_To">The collection of unique references representing the target side of the relation.</param>
        public ManyToManyRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base(uniqueReferences_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class by copying another instance.</summary>
        /// <param name="manyToManyRelation">The existing ManyToManyRelation instance to copy from.</param>
        public ManyToManyRelation(ManyToManyRelation? manyToManyRelation)
            : base(manyToManyRelation)
        {
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class from unique objects.</summary>
        /// <param name="uniqueObjects_From">The collection of unique objects representing the source side of the relation.</param>
        /// <param name="uniqueObjects_To">The collection of unique objects representing the target side of the relation.</param>
        public ManyToManyRelation(IEnumerable<IUniqueObject>? uniqueObjects_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObjects_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public ManyToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents an abstract many-to-many relationship between two types of unique objects.</summary>
    /// <typeparam name="From">The type of the source objects in the relation.</typeparam>
    /// <typeparam name="To">The type of the destination objects in the relation.</typeparam>
    public abstract class ManyToManyRelation<From, To> : Relation<From, To>, IManyToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<IUniqueReference>? uniqueReferences_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<IUniqueReference>? uniqueReferences_To;

        /// <summary>Creates a new instance of the ManyToManyRelation class from unique references.</summary>
        /// <param name="uniqueReferences_From">The collection of unique references from the source side.</param>
        /// <param name="uniqueReferences_To">The collection of unique references from the destination side.</param>
        public ManyToManyRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base()
        {
            if (uniqueReferences_To != null)
            {
                this.uniqueReferences_To = [];
                foreach (IUniqueReference? uniqueReference in uniqueReferences_To)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        this.uniqueReferences_To.Add(uniqueReference_Temp);
                    }
                }
            }

            if (uniqueReferences_From != null)
            {
                this.uniqueReferences_From = [];
                foreach (IUniqueReference? uniqueReference in uniqueReferences_From)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        this.uniqueReferences_From.Add(uniqueReference_Temp);
                    }
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class by copying another instance.</summary>
        /// <param name="manyToManyRelation">The existing relation instance to copy from.</param>
        public ManyToManyRelation(ManyToManyRelation<From, To>? manyToManyRelation)
            : base()
        {
            if (manyToManyRelation != null)
            {
                if (manyToManyRelation.uniqueReferences_To != null)
                {
                    uniqueReferences_To = [];
                    foreach (IUniqueReference uniqueReference_To in manyToManyRelation.uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference = uniqueReference_To?.Clone<IUniqueReference>();
                        if (uniqueReference != null)
                        {
                            uniqueReferences_To.Add(uniqueReference);
                        }
                    }
                }

                if (manyToManyRelation.uniqueReferences_From != null)
                {
                    uniqueReferences_From = [];
                    foreach (IUniqueReference uniqueReference_From in manyToManyRelation.uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference = uniqueReference_From?.Clone<IUniqueReference>();
                        if (uniqueReference != null)
                        {
                            uniqueReferences_From.Add(uniqueReference);
                        }
                    }
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class from unique objects.</summary>
        /// <param name="uniqueObjects_From">The collection of unique objects from the source side.</param>
        /// <param name="uniqueObjects_To">The collection of unique objects from the destination side.</param>
        public ManyToManyRelation(IEnumerable<From>? uniqueObjects_From, IEnumerable<To>? uniqueObjects_To)
            : base()
        {
            if (uniqueObjects_To != null)
            {
                uniqueReferences_To = [];
                foreach (To to in uniqueObjects_To)
                {
                    IUniqueReference? uniqueReference = Create.UniqueReference(to);
                    if (uniqueReference != null)
                    {
                        uniqueReferences_To.Add(uniqueReference);
                    }
                }
            }

            if (uniqueObjects_From != null)
            {
                uniqueReferences_From = [];
                foreach (From from in uniqueObjects_From)
                {
                    IUniqueReference? uniqueReference = Create.UniqueReference(from);
                    if (uniqueReference != null)
                    {
                        uniqueReferences_From.Add(uniqueReference);
                    }
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToManyRelation class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to create the relation from.</param>
        public ManyToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Gets a list containing all unique references in this relation.</summary>
        [JsonIgnore]
        public override List<IUniqueReference>? UniqueReferences
        {
            get
            {
                List<IUniqueReference> result = [];
                if (uniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                        if (uniqueReference_Temp is null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference_Temp);
                    }
                }

                if (uniqueReferences_From != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                        if (uniqueReference_Temp is null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference_Temp);
                    }
                }

                return result;
            }
        }

        /// <summary>Gets a list of unique references on the "from" side of the relation.</summary>
        [JsonIgnore]
        public List<IUniqueReference>? UniqueReferences_From
        {
            get
            {
                if (uniqueReferences_From == null)
                {
                    return null;
                }

                List<IUniqueReference> result = [];
                foreach (IUniqueReference uniqueReference in uniqueReferences_From)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        result.Add(uniqueReference_Temp);
                    }
                }

                return result;
            }
        }

        /// <summary>Gets a list of unique references on the "to" side of the relation.</summary>
        [JsonIgnore]
        public List<IUniqueReference>? UniqueReferences_To
        {
            get
            {
                if (uniqueReferences_To == null)
                {
                    return null;
                }

                List<IUniqueReference> result = [];
                foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        result.Add(uniqueReference_Temp);
                    }
                }

                return result;
            }
        }

        /// <summary>Adds a unique reference to the specified side of the relation.</summary>
        /// <param name="relationSide">The side of the relation where the reference should be added.</param>
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
                uniqueReferences_To ??= [];

                uniqueReferences_To.Add(uniqueReference);
                return true;
            }

            if (relationSide == RelationSide.From)
            {
                uniqueReferences_From ??= [];

                uniqueReferences_From.Add(uniqueReference);
                return true;
            }

            return false;
        }

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        /// <param name="relationSide">The side of the relation to check.</param>
        /// <param name="uniqueReference">The unique reference to locate in the relation.</param>
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
                result = uniqueReferences_From?.Find(x => uniqueReference.Equals(x)) != null;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To?.Find(x => uniqueReference.Equals(x)) != null;
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
                result = uniqueReferences_From != null && uniqueReferences_From.Count != 0;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To != null && uniqueReferences_To.Count != 0;
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
                if (Modify.RemoveFirst(uniqueReferences_To, uniqueReference))
                {
                    result = true;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
                {
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
            if (!uniqueReferences.Any())
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_From != null)
                {
                    foreach (TUniqueReference uniqueReference in uniqueReferences)
                    {
                        if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
                        {
                            result.Add(uniqueReference);
                            if (uniqueReferences_From.Count == 0)
                            {
                                break;
                            }
                        }
                    }
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_To == null)
                {
                    return result;
                }

                foreach (TUniqueReference uniqueReference in uniqueReferences)
                {
                    if (Modify.RemoveFirst(uniqueReferences_To, uniqueReference))
                    {
                        result.Add(uniqueReference);
                        if (uniqueReferences_To.Count == 0)
                        {
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}