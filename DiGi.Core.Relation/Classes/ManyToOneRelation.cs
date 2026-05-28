using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents an abstract many-to-one relationship between unique objects.</summary>
    public abstract class ManyToOneRelation : ManyToOneRelation<IUniqueObject, IUniqueObject>
    {
        /// <summary>Creates a new instance of the ManyToOneRelation class from unique references.</summary>
        public ManyToOneRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IUniqueReference? uniqueReference_To)
            : base(uniqueReferences_From, uniqueReference_To)
        {
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class by copying another instance.</summary>
        public ManyToOneRelation(ManyToOneRelation? manyToOneRelation)
            : base(manyToOneRelation)
        {
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class from unique objects.</summary>
        public ManyToOneRelation(IEnumerable<IUniqueObject>? uniqueObjects_From, IUniqueObject? uniqueObject_To)
            : base(uniqueObjects_From, uniqueObject_To)
        {
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class from a JSON object.</summary>
        public ManyToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }

    /// <summary>Represents an abstract many-to-one relationship between two types of unique objects.</summary>
    public abstract class ManyToOneRelation<From, To> : Relation<From, To>, IManyToOneRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private IUniqueReference? uniqueReference_To;

        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<IUniqueReference>? uniqueReferences_From;

        /// <summary>Creates a new instance of the ManyToOneRelation class from unique references.</summary>
        public ManyToOneRelation(IEnumerable<IUniqueReference>? uniqueReferences_From, IUniqueReference? uniqueReference_To)
            : base()
        {
            this.uniqueReference_To = uniqueReference_To?.Clone<IUniqueReference>();
            if (uniqueReferences_From != null)
            {
                this.uniqueReferences_From = [];
                foreach (IUniqueReference? uniqueReference in uniqueReferences_From)
                {
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp == null)
                    {
                        continue;
                    }

                    this.uniqueReferences_From.Add(uniqueReference_Temp);
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class by copying another instance.</summary>
        public ManyToOneRelation(ManyToOneRelation<From, To>? manyToOneRelation)
            : base()
        {
            if (manyToOneRelation != null)
            {
                uniqueReference_To = manyToOneRelation.uniqueReference_To?.Clone<IUniqueReference>();
                if (manyToOneRelation.uniqueReferences_From != null)
                {
                    uniqueReferences_From = [];
                    foreach (IUniqueReference? uniqueReference in manyToOneRelation.uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                        if (uniqueReference_Temp == null)
                        {
                            continue;
                        }

                        uniqueReferences_From.Add(uniqueReference_Temp);
                    }
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class from unique objects.</summary>
        public ManyToOneRelation(IEnumerable<From>? uniqueObjects_From, To? uniqueObject_To)
            : base()
        {
            uniqueReference_To = uniqueObject_To == null ? null : Create.UniqueReference(uniqueObject_To);
            if (uniqueObjects_From != null)
            {
                uniqueReferences_From = [];
                foreach (From? from in uniqueObjects_From)
                {
                    IUniqueReference? uniqueReference_Temp = Create.UniqueReference(from);
                    if (uniqueReference_Temp == null)
                    {
                        continue;
                    }

                    uniqueReferences_From.Add(uniqueReference_Temp);
                }
            }
        }

        /// <summary>Creates a new instance of the ManyToOneRelation class from a JSON object.</summary>
        public ManyToOneRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {
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
                if (uniqueReference_To != null)
                {
                    IUniqueReference? uniqueReference = uniqueReference_To.Clone<IUniqueReference>();
                    if (uniqueReference != null)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if (uniqueReferences_From != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_From)
                    {
                        IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                        if (uniqueReference_Temp == null)
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
                    IUniqueReference? uniqueReference_Temp = uniqueReference?.Clone<IUniqueReference>();
                    if (uniqueReference_Temp == null)
                    {
                        continue;
                    }

                    result.Add(uniqueReference_Temp);
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

            if (relationSide == RelationSide.To)
            {
                uniqueReference_To = uniqueReference;
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
        public override bool Contains(RelationSide relationSide, IUniqueReference? uniqueReference)
        {
            bool result = false;

            if (uniqueReference == null)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_From?.Find(x => uniqueReference.Equals(x)) != null;
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
                result = uniqueReference_To != null;
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
                if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
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

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_To is TUniqueReference uniqueReference_Temp)
                {
                    if (uniqueReferences.Find(x => x is not null && uniqueReference_To.Equals(x)) != null)
                    {
                        result.Add(uniqueReference_Temp);
                        uniqueReference_To = null;
                    }
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                foreach (TUniqueReference uniqueReference in uniqueReferences)
                {
                    if (Modify.RemoveFirst(uniqueReferences_From, uniqueReference))
                    {
                        result.Add(uniqueReference);
                        if (uniqueReferences_From == null || uniqueReferences_From.Count == 0)
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