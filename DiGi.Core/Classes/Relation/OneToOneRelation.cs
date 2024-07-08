using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class OneToOneRelation : SerializableObject, IOneToOneRelation
    {
        [JsonInclude, JsonPropertyName("UniqueReference_From")]
        private UniqueReference uniqueReference_From;

        [JsonInclude, JsonPropertyName("UniqueReference_To")]
        private UniqueReference uniqueReference_To;

        public OneToOneRelation(OneToOneRelation oneToOneRelation)
            : base()
        {
            uniqueReference_From = oneToOneRelation.uniqueReference_From?.Clone<UniqueReference>();
            uniqueReference_To = oneToOneRelation.uniqueReference_To?.Clone<UniqueReference>();
        }

        public OneToOneRelation(UniqueReference uniqueReference_From, UniqueReference uniqueReference_To) 
        { 
            uniqueReference_From = uniqueReference_From?.Clone<UniqueReference>();
            uniqueReference_To = uniqueReference_To?.Clone<UniqueReference>();
        }

        public OneToOneRelation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public List<UniqueReference> UniqueReferences
        {
            get
            {
                List<UniqueReference> result = new List<UniqueReference>();
                if(uniqueReference_From != null)
                {
                    result.Add(uniqueReference_From.Clone<UniqueReference>());
                }

                if (uniqueReference_To != null)
                {
                    result.Add(uniqueReference_To.Clone<UniqueReference>());
                }

                return result;
            }
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
        public UniqueReference UniqueReference_To
        {
            get
            {
                return uniqueReference_To?.Clone<UniqueReference>();
            }
        }

        public bool Contains(UniqueReference uniqueReference)
        {
            if(uniqueReference_From == uniqueReference)
            {
                return true;
            }

            if (uniqueReference_To == uniqueReference)
            {
                return true;
            }

            return false;
        }
    }
}
