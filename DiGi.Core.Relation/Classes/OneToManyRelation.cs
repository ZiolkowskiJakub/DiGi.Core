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
    public abstract class OneToManyRelation : OneToManyRelation<IUniqueObject, IUniqueObject>
    {
        public OneToManyRelation(IUniqueObject uniqueObject_From, IEnumerable<IUniqueObject> uniqueObjects_To)
            : base(uniqueObject_From, uniqueObjects_To)
        {

        }

        public OneToManyRelation(IUniqueReference uniqueReference_From, IEnumerable<IUniqueReference> uniqueReferences_To)
            : base(uniqueReference_From, uniqueReferences_To)
        {

        }

        public OneToManyRelation(OneToManyRelation oneToManyRelation)
            : base(oneToManyRelation)
        {

        }

        public OneToManyRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class OneToManyRelation<From, To> : Relation<From, To>, IOneToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private IUniqueReference uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<IUniqueReference> uniqueReferences_To;

        public OneToManyRelation(From uniqueObject_From, IEnumerable<To> uniqueObjects_To)
            : base()
        {
            uniqueReference_From = uniqueObject_From == null ? null : new GuidReference(uniqueObject_From);
            uniqueReferences_To = uniqueObjects_To == null ? null : uniqueObjects_To.ToList().FindAll(x => x != null).ConvertAll(x => (IUniqueReference) new GuidReference(x));
        }

        public OneToManyRelation(IUniqueReference uniqueReference_From, IEnumerable<IUniqueReference> uniqueReferences_To)
            :base()
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<IUniqueReference>();
            this.uniqueReferences_To = uniqueReferences_To == null ? null : uniqueReferences_To.ToList().ConvertAll(x => x?.Clone<IUniqueReference>());
        }

        public OneToManyRelation(OneToManyRelation<From, To> oneToManyRelation)
            : base()
        {
            if(oneToManyRelation != null)
            {
                uniqueReference_From = oneToManyRelation.uniqueReference_From?.Clone<IUniqueReference>();
                uniqueReferences_To = oneToManyRelation.uniqueReferences_To?.ToList().ConvertAll(x => x?.Clone<IUniqueReference>());
            }
        }

        public OneToManyRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public IUniqueReference UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<IUniqueReference>();
            }
        }

        [JsonIgnore]
        public override List<IUniqueReference> UniqueReferences
        {
            get
            {
                List<IUniqueReference> result = new List<IUniqueReference>();
                if (uniqueReference_From != null)
                {
                    result.Add(uniqueReference_From.Clone<IUniqueReference>());
                }

                if (uniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in uniqueReferences_To)
                    {
                        if (uniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference.Clone<IUniqueReference>());
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public List<IUniqueReference> UniqueReferences_To
        {
            get
            {
                return uniqueReferences_To?.ConvertAll(x => x?.Clone<IUniqueReference>());
            }
        }

        public override bool Contains(RelationSide relationSide, IUniqueReference uniqueReference)
        {
            bool result = false;

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To != null && uniqueReferences_To.Contains(uniqueReference);
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_From == uniqueReference;
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

        public override bool Remove(RelationSide relationSide, IUniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_From == uniqueReference)
                {
                    uniqueReference_From = null;
                    result = true;
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_To != null)
                {
                    if (uniqueReferences_To.Remove(uniqueReference))
                    {
                        result = true;
                    }
                }
            }

            return result;
        }

        public override bool Add(RelationSide relationSide, IUniqueReference uniqueReference)
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
                if(uniqueReferences_To == null)
                {
                    uniqueReferences_To = new List<IUniqueReference>();
                }

                uniqueReferences_To.Add(uniqueReference);
                return true;
            }

            return false;
        }


        public override List<TUniqueReference> Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference> uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<TUniqueReference> result = new List<TUniqueReference>();
            if (uniqueReferences.Count() == 0)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if(uniqueReference_From is TUniqueReference)
                {
                    if (uniqueReferences.Contains((TUniqueReference)uniqueReference_From))
                    {
                        result.Add((TUniqueReference)uniqueReference_From);
                        uniqueReference_From = null;
                    }
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                foreach (TUniqueReference uniqueReference in uniqueReferences)
                {
                    if (uniqueReferences_To.Remove(uniqueReference))
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
