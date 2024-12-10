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

        public OneToManyRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
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
        private UniqueReference uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<UniqueReference> uniqueReferences_To;

        public OneToManyRelation(From uniqueObject_From, IEnumerable<To> uniqueObjects_To)
            : base()
        {
            uniqueReference_From = uniqueObject_From == null ? null : new GuidReference(uniqueObject_From);
            uniqueReferences_To = uniqueObjects_To == null ? null : uniqueObjects_To.ToList().FindAll(x => x != null).ConvertAll(x => (UniqueReference) new GuidReference(x));
        }

        public OneToManyRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            :base()
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<UniqueReference>();
            this.uniqueReferences_To = uniqueReferences_To == null ? null : uniqueReferences_To.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
        }

        public OneToManyRelation(OneToManyRelation<From, To> oneToManyRelation)
            : base()
        {
            if(oneToManyRelation != null)
            {
                uniqueReference_From = oneToManyRelation.uniqueReference_From?.Clone<UniqueReference>();
                uniqueReferences_To = oneToManyRelation.uniqueReferences_To?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        public OneToManyRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public UniqueReference UniqueReference_From
        {
            get
            {
                return uniqueReference_From?.Clone<UniqueReference>();
            }
        }

        [JsonIgnore]
        public override List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
                if (uniqueReference_From != null)
                {
                    result.Add(uniqueReference_From.Clone<UniqueReference>());
                }

                if (uniqueReferences_To != null)
                {
                    foreach (UniqueReference uniqueReference in uniqueReferences_To)
                    {
                        if (uniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference.Clone<UniqueReference>());
                    }
                }

                return result;
            }
        }

        [JsonIgnore]
        public List<UniqueReference> UniqueReferences_To
        {
            get
            {
                return uniqueReferences_To?.ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        public override bool Contains(RelationSide relationSide, UniqueReference uniqueReference)
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

        public override bool Remove(RelationSide relationSide, UniqueReference uniqueReference)
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

        public override bool Add(RelationSide relationSide, UniqueReference uniqueReference)
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
                    uniqueReferences_To = new List<UniqueReference>();
                }

                uniqueReferences_To.Add(uniqueReference);
                return true;
            }

            return false;
        }


        public override List<UniqueReference> Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference> uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<UniqueReference> result = new List<UniqueReference>();
            if (uniqueReferences.Count() == 0)
            {
                return result;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences.Contains(uniqueReference_From))
                {
                    result.Add(uniqueReference_From);
                    uniqueReference_From = null;
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
