using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
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
        
        public abstract Type GetType_From();
        
        public abstract Type GetType_To();
    }

    public abstract class Relation<X, Y> : Relation, IRelation<X, Y> where X : IUniqueObject where Y : IUniqueObject
    {
        public Relation(Relation<X, Y> relation)
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

        public override Type GetType_From()
        {
            return typeof(X);
        }

        public override Type GetType_To()
        {
            return typeof(Y);
        }
    }
}
