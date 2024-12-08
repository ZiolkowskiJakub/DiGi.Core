﻿using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class ManyToManyRelation : ManyToManyRelation<IUniqueObject, IUniqueObject>
    {
        public ManyToManyRelation(IEnumerable<UniqueReference> uniqueReferences_From, IEnumerable<UniqueReference> uniqueReferences_To)
            : base(uniqueReferences_From, uniqueReferences_To)
        {

        }

        public ManyToManyRelation(ManyToManyRelation manyToManyRelation)
            : base(manyToManyRelation)
        {

        }

        public ManyToManyRelation(IEnumerable<IUniqueObject> uniqueObjects_From, IEnumerable<IUniqueObject> uniqueObjects_To)
            : base(uniqueObjects_From, uniqueObjects_To)
        {

        }

        public ManyToManyRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }

    public abstract class ManyToManyRelation<From, To> : Relation<From, To>, IManyToManyRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<UniqueReference> uniqueReferences_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<UniqueReference> uniqueReferences_To;

        public ManyToManyRelation(IEnumerable<UniqueReference> uniqueReferences_From, IEnumerable<UniqueReference> uniqueReferences_To)
            :base()
        {
            this.uniqueReferences_To = uniqueReferences_To == null ? null : uniqueReferences_To.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            this.uniqueReferences_From = uniqueReferences_From == null ? null : uniqueReferences_From.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
        }

        public ManyToManyRelation(ManyToManyRelation<From, To> manyToManyRelation)
            : base()
        {
            if(manyToManyRelation != null)
            {
                uniqueReferences_To = manyToManyRelation.uniqueReferences_To?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
                uniqueReferences_From = manyToManyRelation.uniqueReferences_From?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        public ManyToManyRelation(IEnumerable<From> uniqueObjects_From, IEnumerable<To> uniqueObjects_To)
            : base()
        {
            uniqueReferences_From = uniqueObjects_From == null ? null : uniqueObjects_From.ToList().FindAll(x => x != null).ConvertAll(x => (UniqueReference) new GuidReference(x));
            uniqueReferences_To = uniqueObjects_To == null ? null : uniqueObjects_To.ToList().FindAll(x => x != null).ConvertAll(x => (UniqueReference) new GuidReference(x));
        }

        public ManyToManyRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public List<UniqueReference> UniqueReferences_To
        {
            get
            {
                return uniqueReferences_To?.ConvertAll(x => x?.Clone<UniqueReference>());
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

        [JsonIgnore]
        public override List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
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

                if (uniqueReferences_From != null)
                {
                    foreach(UniqueReference uniqueReference in uniqueReferences_From)
                    {
                        if(uniqueReference == null)
                        {
                            continue;
                        }

                        result.Add(uniqueReference.Clone<UniqueReference>());
                    }
                }

                return result;
            }
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
                if(uniqueReferences_To != null)
                {
                    if (uniqueReferences_To.Remove(uniqueReference))
                    {
                        result = true;
                    }
                }
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                if(uniqueReferences_From != null)
                {
                    if (uniqueReferences_From.Remove(uniqueReference))
                    {
                        result = true;
                    }
                }
            }

            return result;
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

        public override bool Has(RelationSide relationSide)
        {
            bool result = false;

            if(relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_From != null && uniqueReferences_From.Count != 0;
            }

            if(result)
            {
                return result;
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                result = uniqueReferences_To != null && uniqueReferences_To.Count != 0;
            }

            return result;
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
                result = uniqueReferences_To != null && uniqueReferences_To.Contains(uniqueReference);
            }

            return result;
        }
    }
}
