using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class OneToManyRelation : OneToManyRelation<IUniqueObject, IUniqueObject>
    {
        public OneToManyRelation(IUniqueObject? uniqueObject_From, IEnumerable<IUniqueObject>? uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyRelation(IUniqueReference? uniqueReference_From, IEnumerable<IUniqueReference>? uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyRelation(OneToManyRelation? oneToManyRelation)
            : base(oneToManyRelation)
        {

        }

        public OneToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class OneToManyRelation<From, To> : Relation<From, To>, IOneToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private IUniqueReference? uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<IUniqueReference>? uniqueReferences_To;

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

        public OneToManyRelation(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public IUniqueReference? UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<IUniqueReference>();
            }
        }

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
