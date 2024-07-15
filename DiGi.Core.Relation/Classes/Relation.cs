using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class Relation : SerializableObject, IRelation
    {
        public Relation(Relation relation)
            : base()
        {

        }

        public Relation()
            :base()
        { 

        }

        public Relation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public abstract List<UniqueReference> UniqueReferences { get; }

        public bool Contains(UniqueReference uniqueReference)
        {
            bool? contains = UniqueReferences?.Contains(uniqueReference);

            return contains != null && contains.HasValue  && contains.Value;
        }

        public abstract bool Contains_From(UniqueReference uniqueReference);

        public abstract bool Contains_To(UniqueReference uniqueReference);

        public abstract bool Remove(UniqueReference uniqueReference);

        public abstract bool Remove_From(UniqueReference uniqueReference);

        public abstract bool Remove_To(UniqueReference uniqueReference);
    }
}
