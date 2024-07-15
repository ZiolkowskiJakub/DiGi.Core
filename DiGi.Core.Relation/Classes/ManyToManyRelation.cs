using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class ManyToManyRelation : Relation, IManyToManyRelation
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

        public ManyToManyRelation(ManyToManyRelation manyToManyRelation)
            : base()
        {
            if(manyToManyRelation != null)
            {
                uniqueReferences_To = manyToManyRelation.uniqueReferences_To?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
                uniqueReferences_From = manyToManyRelation.uniqueReferences_From?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            }
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

        public override bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (uniqueReferences_To != null)
            {
                if (uniqueReferences_To.Remove(uniqueReference))
                {
                    result = true;
                }
            }

            if (uniqueReferences_From != null)
            {
                if (uniqueReferences_From.Remove(uniqueReference))
                {
                    result = true;
                }
            }

            return result;
        }

        public override bool Remove_To(UniqueReference uniqueReference)
        {
            if (uniqueReference == null || uniqueReferences_To == null)
            {
                return false;
            }

            return uniqueReferences_To.Remove(uniqueReference);
        }

        public override bool Remove_From(UniqueReference uniqueReference)
        {
            if (uniqueReference == null || uniqueReferences_From == null)
            {
                return false;
            }

            return uniqueReferences_From.Remove(uniqueReference);
        }
    }
}
