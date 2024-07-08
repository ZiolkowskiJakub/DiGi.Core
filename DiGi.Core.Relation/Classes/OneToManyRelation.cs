using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class OneToManyRelation : Relation
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private UniqueReference uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReferences_To")]
        private List<UniqueReference> uniqueReferences_To;

        public OneToManyRelation(IUniqueObject uniqueObject_From, IEnumerable<IUniqueObject> uniqueObjects_To)
            : base()
        {
            uniqueReference_From = uniqueObject_From == null ? null : new UniqueReference(uniqueObject_From);
            uniqueReferences_To = uniqueObjects_To == null ? null : uniqueObjects_To.ToList().FindAll(x => x != null).ConvertAll(x => new UniqueReference(x));
        }

        public OneToManyRelation(UniqueReference uniqueReference_From, IEnumerable<UniqueReference> uniqueReferences_To)
            :base()
        {
            this.uniqueReference_From = uniqueReference_From?.Clone<UniqueReference>();
            this.uniqueReferences_To = uniqueReferences_To == null ? null : uniqueReferences_To.ToList().ConvertAll(x => x?.Clone<UniqueReference>());
        }

        public OneToManyRelation(OneToManyRelation oneToManyRelation)
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
                if(uniqueReference_From != null)
                {
                    result.Add(uniqueReference_From.Clone<UniqueReference>());
                }

                if(uniqueReferences_To != null)
                {
                    foreach(UniqueReference uniqueReference in uniqueReferences_To)
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

        public override bool Contains_From(UniqueReference uniqueReference)
        {
            return uniqueReference_From == uniqueReference;
        }

        public override bool Contains_To(UniqueReference uniqueReference)
        {
            return uniqueReferences_To != null && uniqueReferences_To.Contains(uniqueReference);
        }
    }
}
