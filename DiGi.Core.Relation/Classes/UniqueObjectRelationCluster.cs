using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Classes;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class UniqueObjectRelationCluster<T, X> : UniqueObjectCluster<T> where T : IUniqueObject where X: IRelation
    {
        [JsonInclude, JsonPropertyName("RelationCluster"), System.ComponentModel.Description("RelationCluster")]
        private RelationCluster<X> relationCluster = new RelationCluster<X>();

        public UniqueObjectRelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueObjectRelationCluster()
            : base()
        {

        }

        public UniqueObjectRelationCluster(UniqueObjectRelationCluster<T, X> uniqueObjectRelationCluster)
            : base(uniqueObjectRelationCluster)
        {
            if(uniqueObjectRelationCluster != null)
            {

                relationCluster = uniqueObjectRelationCluster.relationCluster == null ? null : new RelationCluster<X>(uniqueObjectRelationCluster.relationCluster);
            }

        }

        public UniqueObjectRelationCluster(IEnumerable<T> uniqueObjects)
            : base(uniqueObjects)
        {

        }

        public override bool Remove(UniqueReference uniqueReference)
        {
            bool result = base.Remove(uniqueReference);
            if(result)
            {
                relationCluster.Remove(uniqueReference);
            }

            return result;
        }

        public virtual bool Remove(X relation)
        {
            if(relation == null)
            {
                return false;
            }

            return relationCluster.Remove(relation);
        }

        public List<Z> GetRelations<Z>(UniqueReference uniqueReference) where Z : X
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return relationCluster.FindAll<Z>(uniqueReference);

        }

        public Z GetRelation<Z>(UniqueReference uniqueReference, Func<Z, bool> func = null) where Z : X
        {
            if (uniqueReference == null)
            {
                return default;
            }

            return relationCluster.Find<Z>(uniqueReference, func);
        }

        public Z AddRelation<Z>(Z relation) where Z : X
        {
            if(relation == null)
            {
                return default;
            }

            if(relationCluster == null)
            {
                relationCluster = new RelationCluster<X>();
            }

            if(relationCluster.Add(relation))
            {
                return relation;
            }

            return default;
        }
    }
}
