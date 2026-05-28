using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents an abstract one-to-many relationship between unique objects.</summary>
    public abstract class OneToManyRelation : OneToManyRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the OneToManyRelation class from unique objects.</summary>
        public OneToManyRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyRelation class from unique references.</summary>
        public OneToManyRelation(IUniqueReference? uniqueReference_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {
        }

        /// <summary>Creates a new instance of the OneToManyRelation class by copying another instance.</summary>
        public OneToManyRelation(OneToManyRelation? oneToManyRelation)
            : base(oneToManyRelation)
        {
        }

        /// <summary>Creates a new instance of the OneToManyRelation class from a JSON object.</summary>
        public OneToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents an abstract one-to-many relationship between two types of unique objects.</summary>
    public abstract class OneToManyRelation<From, To> : Relation<From, To>, IOneToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {


        /// <summary>Creates a new instance of the OneToManyRelation class from unique objects.</summary>
        public OneToManyRelation(From? uniqueObject_From, IEnumerable<To>? uniqueObjects_To)
            : base()
        {
            uniqueReference_From = uniqueObject_From == null ? null : Create.UniqueReference(uniqueObject_From);
            if (uniqueObjects_To != null)
            {
                uniqueReferences_To = [];
                foreach (To uniqueObject_To in uniqueObjects_To)
                {
                    IUniqueReference? uniqueReference = Create.UniqueReference(uniqueObject_To);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    uniqueReferences_To.Add(uniqueReference);
                }
            }
        }

        /// <summary>Creates a new instance of the OneToManyRelation class from unique references.</summary>
        public OneToManyRelation(IUniqueReference? uniqueReference_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base()
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<IUniqueReference>();
            if (uniqueReferences_To != null)
            {
                this.uniqueReferences_To = [];
                foreach (IUniqueReference uniqueReference_To in uniqueReferences_To)
                {
                    IUniqueReference? uniqueReference = uniqueReference_To?.Clone<IUniqueReference>();
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    this.uniqueReferences_To.Add(uniqueReference);
                }
            }
        }

        /// <summary>Creates a new instance of the OneToManyRelation class by copying another instance.</summary>
        public OneToManyRelation(OneToManyRelation<From, To>? oneToManyRelation)
            : base()
        {
            if (oneToManyRelation != null)
            {
                uniqueReference_From = oneToManyRelation.uniqueReference_From?.Clone<IUniqueReference>();
                if (oneToManyRelation.uniqueReferences_To != null)
                {
                    uniqueReferences_To = [];
                    foreach (IUniqueReference uniqueReference_To in oneToManyRelation.uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference = uniqueReference_To?.Clone<IUniqueReference>();
                        if (uniqueReference == null)
                        {
                            continue;
                        }

                        uniqueReferences_To.Add(uniqueReference);
                    }
                }
            }
        }

        /// <summary>Creates a new instance of the OneToManyRelation class from a JSON object.</summary>
        public OneToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private IUniqueReference? uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<IUniqueReference>? uniqueReferences_To;


        /// <summary>Gets the unique reference from the source object.</summary>
        [JsonIgnore]
        public IUniqueReference? UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<IUniqueReference>();
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

                if (uniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference.Clone<IUniqueReference>();
                        if (uniqueReference_Temp != null)
                        {
                            result.Add(uniqueReference_Temp);
                        }
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
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp != null)
                    {
                        result.Add(uniqueReference_Temp);
                    }
                }
                return result;
            }
        }

        /// <summary>Adds a unique reference to the specified side of the relation.</summary>
        public override bool Add(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null || relationSide == RelationSide.Undefined)
            {
                return false;
            }

            if (relationSide == RelationSide.From)
            {
                uniqueReference_From = uniqueReference;
                return true;
            }

            if (relationSide == RelationSide.To)
            {
                uniqueReferences_To ??= [];

                uniqueReferences_To.Add(uniqueReference);
                return true;
            }

            return false;
        }

        /// <summary>Determines whether the relation contains the specified unique reference on the given side.</summary>
        public override bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To?.Find(uniqueReference.Equals) != null;
            }

            if (result || uniqueReference_From is null)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference.Equals(uniqueReference_From);
            }

            return result;
        }

        /// <summary>Determines whether the relation has a reference on the specified side.</summary>
        public override bool Has(RelationSide relationSide)
        {
            bool result = false;

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To != null && uniqueReferences_To.Count != 0;
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_From != null;
            }

            return result;
        }

        /// <summary>Removes a unique reference from the specified side of the relation.</summary>
        public override bool Remove(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From is not null && uniqueReference.Equals(uniqueReference_From))
                {
                    uniqueReference_From = null;
                    result = true;
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (Modify.RemoveFirst(uniqueReferences_To, uniqueReference))
                {
                    result = true;
                }
            }

            return result;
        }

        /// <summary>Removes multiple unique references from the specified side of the relation.</summary>
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

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From is TUniqueReference unigueReference_Temp)
                {
                    if (uniqueReferences.Contains(unigueReference_Temp))
                    {
                        result.Add(unigueReference_Temp);
                        uniqueReference_From = null;
                    }
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_To != null)
                {
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
            }

            return result;
        }
    }
}