﻿using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class ManyToOneRelation : Relation, IManyToOneRelation
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
        public UniqueReference UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<UniqueReference>();
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

        public override bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;
            if (uniqueReference_To == uniqueReference)
            {
                uniqueReference_To = null;
                result = true;
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
            if (uniqueReference != uniqueReference_To)
            {
                return false;
            }

            uniqueReference_To = null;
            return true;
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
