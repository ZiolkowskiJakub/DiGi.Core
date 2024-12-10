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
    public abstract class ManyToOneRelation : ManyToOneRelation<IUniqueObject, IUniqueObject>
    {
        public ManyToOneRelation(IEnumerable<UniqueReference> uniqueReferences_From, UniqueReference uniqueReference_To)
            : base(uniqueReferences_From, uniqueReference_To)
        {

        }

        public ManyToOneRelation(ManyToOneRelation manyToOneRelation)
            : base(manyToOneRelation)
        {

        }

        public ManyToOneRelation(IEnumerable<IUniqueObject> uniqueObjects_From, IUniqueObject uniqueObject_To)
            : base(uniqueObjects_From, uniqueObject_To)
        {

        }

        public ManyToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class ManyToOneRelation<From, To> : Relation<From, To>, IManyToOneRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private UniqueReference uniqueReference_To;

        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<UniqueReference> uniqueReferences_From;
        public ManyToOneRelation(IEnumerable<UniqueReference> uniqueReferences_From, UniqueReference uniqueReference_To)
            :base()
        {
            this.uniqueReference_To = uniqueReference_To?.Clone<UniqueReference>();
            this.uniqueReferences_From = uniqueReferences_From == null ? null : uniqueReferences_From.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
        }

        public ManyToOneRelation(ManyToOneRelation<From, To> manyToOneRelation)
            : base()
        {
            if(manyToOneRelation != null)
            {
                uniqueReference_To = manyToOneRelation.uniqueReference_To?.Clone<UniqueReference>();
                uniqueReferences_From = manyToOneRelation.uniqueReferences_From?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        public ManyToOneRelation(IEnumerable<From> uniqueObjects_From, To uniqueObject_To)
            : base()
        {
            uniqueReference_To = uniqueObject_To == null ? null : new GuidReference(uniqueObject_To);
            uniqueReferences_From = uniqueObjects_From == null ? null : uniqueObjects_From.ToList().FindAll(x => x != null).ConvertAll(x => (UniqueReference) new GuidReference(x));
        }

        public ManyToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public UniqueReference UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<UniqueReference>();
            }
        }

        [JsonIgnore]
        public override List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
                if (uniqueReference_To != null)
                {
                    result.Add(uniqueReference_To.Clone<UniqueReference>());
                }

                if (uniqueReferences_From != null)
                {
                    foreach (UniqueReference uniqueReference in uniqueReferences_From)
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
        public List<UniqueReference> UniqueReferences_From
        {
            get
            {
                return uniqueReferences_From?.ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }
        
        public override bool Contains(RelationSide relationSide, UniqueReference uniqueReference)
        {
            bool result = false;

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_From != null && uniqueReferences_From.Contains(uniqueReference);
            }

            if (result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReference_To == uniqueReference;
            }

            return result;
        }

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

        public override bool Remove(RelationSide relationSide, UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReference_To == uniqueReference)
                {
                    uniqueReference_To = null;
                    result = true;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences_From != null)
                {
                    if (uniqueReferences_From.Remove(uniqueReference))
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

            if (relationSide == RelationSide.To)
            {
                uniqueReference_To = uniqueReference;
                return true;
            }

            if (relationSide == RelationSide.From)
            {
                if(uniqueReferences_From == null)
                {
                    uniqueReferences_From = new List<UniqueReference>();
                }

                uniqueReferences_From.Add(uniqueReference);
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

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                if (uniqueReferences.Contains(uniqueReference_To))
                {
                    result.Add(uniqueReference_To);
                    uniqueReference_To = null;
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                foreach (TUniqueReference uniqueReference in uniqueReferences)
                {
                    if (uniqueReferences_From.Remove(uniqueReference))
                    {
                        result.Add(uniqueReference);
                        if (uniqueReferences_From.Count == 0)
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
