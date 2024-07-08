using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class ManyToOneRelation : Relation
    {
        [JsonInclude, JsonPropertyName("UniqueReferences_From")]
        private List<UniqueReference> uniqueReferences_From;

        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private UniqueReference uniqueReference_To;

        public ManyToOneRelation(IEnumerable<UniqueReference> uniqueReferences_From, UniqueReference uniqueReference_To)
            :base()
        {
            this.uniqueReference_To = uniqueReference_To?.Clone<UniqueReference>();
            this.uniqueReferences_From = uniqueReferences_From == null ? null : uniqueReferences_From.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
        }

        public ManyToOneRelation(ManyToOneRelation manyToOneRelation)
            : base()
        {
            if(manyToOneRelation != null)
            {
                uniqueReference_To = manyToOneRelation.uniqueReference_To?.Clone<UniqueReference>();
                uniqueReferences_From = manyToOneRelation.uniqueReferences_From?.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        public ManyToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public UniqueReference UniqueReference_From
        {
            get
            {
                return UniqueReference_From?.Clone<UniqueReference>();
            }
        }

        [JsonIgnore]
        public List<UniqueReference> UniqueReferences_To
        {
            get
            {
                return UniqueReferences_To?.ConvertAll(x => x?.Clone<UniqueReference>());
            }
        }

        [JsonIgnore]
        public override List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
                if(uniqueReference_To != null)
                {
                    result.Add(uniqueReference_To.Clone<UniqueReference>());
                }

                if(uniqueReferences_From != null)
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
    }
}
