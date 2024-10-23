using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public class UniqueObjectRelationCluster<T, X> : UniqueObjectValueCluster<T> where T : IUniqueObject where X: IRelation
    {
        [JsonInclude, JsonPropertyName("RelationListCluster"), System.ComponentModel.Description("RelationListCluster")]
        private RelationListCluster<X> relationListCluster = new RelationListCluster<X>();

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

                relationListCluster = uniqueObjectRelationCluster.relationListCluster == null ? null : new RelationListCluster<X>(uniqueObjectRelationCluster.relationListCluster);
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
                relationListCluster.Remove(uniqueReference);
            }

            return result;
        }

        public override bool Remove(T uniqueObject)
        {
            if(uniqueObject == null)
            {
                return false;
            }

            return Remove(new UniqueReference(uniqueObject));
        }

        public virtual bool Remove(X relation)
        {
            if(relation == null)
            {
                return false;
            }

            return relationListCluster.Remove(relation);
        }

        public List<Z> GetRelations<Z>(UniqueReference uniqueReference) where Z : X
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<Z>(uniqueReference);
        }

        public List<Z> GetRelations<Z>(UniqueReference uniqueReference, Func<Z, bool> func = null) where Z : X
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReference, func);
        }

        public bool TryGetRelations<Z>(out List<Z> relations, Func<Z, bool> func = null) where Z : X
        {
            relations = relationListCluster?.GetValues(func);

            return relations != null && relations.Count > 0;
        }

        public bool TryGetRelation<Z>(out Z relation, Func<Z, bool> func = null) where Z : X
        {
            relation = default;
            if(relationListCluster == null)
            {
                return false;
            }

            relation = relationListCluster.GetValue(func);

            return relation != null;
        }

        public Z GetRelation<Z>(UniqueReference uniqueReference, Func<Z, bool> func = null) where Z : X
        {
            if (uniqueReference == null)
            {
                return default;
            }

            List<Z> values = relationListCluster.GetValues(uniqueReference, func);
            if(values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public Z AddRelation<Z>(Z relation) where Z : X
        {
            if(relation == null)
            {
                return default;
            }

            if(relationListCluster == null)
            {
                relationListCluster = new RelationListCluster<X>();
            }

            if(relationListCluster.Add(relation))
            {
                return relation;
            }

            return default;
        }
    }
}
