using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
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

        public abstract bool Contains(RelationSide relationSide, UniqueReference uniqueReference);

        public abstract Type GetType(RelationSide relationSide);

        public abstract bool Has(RelationSide relationSide);

        public abstract bool Remove(RelationSide relationSide, UniqueReference uniqueReference);

        public abstract List<UniqueReference> Remove<TUniqueReference>(RelationSide relationSide, IEnumerable<TUniqueReference> uniqueReferences) where TUniqueReference : UniqueReference;
    }

    public abstract class Relation<From, To> : Relation, IRelation<From, To> where From : IUniqueObject where To : IUniqueObject
    {
        public Relation(Relation<From, To> relation)
            : base(relation)
        {

        }

        public Relation()
            : base()
        {

        }

        public Relation(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override Type GetType(RelationSide relationSide)
        {
            switch(relationSide)
            {
                case RelationSide.From:
                    return typeof(From);

                case RelationSide.To:
                    return typeof(To);
            }

            return null;
        }
    }
}
