using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class UniqueObjectRelationCluster<T> : UniqueObjectCluster<T> where T : IUniqueObject
    {
        [JsonInclude, JsonPropertyName("RelationCluster"), System.ComponentModel.Description("RelationCluster")]
        private RelationCluster relationCluster = new RelationCluster();

        public UniqueObjectRelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueObjectRelationCluster()
            : base()
        {

        }

        public UniqueObjectRelationCluster(UniqueObjectRelationCluster<T> uniqueObjectRelationCluster)
            : base(uniqueObjectRelationCluster)
        {
            if(uniqueObjectRelationCluster != null)
            {

                relationCluster = uniqueObjectRelationCluster.relationCluster == null ? null : new RelationCluster(uniqueObjectRelationCluster.relationCluster);
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

        public List<X> GetRelations<X>(UniqueReference uniqueReference) where X : IRelation
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return relationCluster.FindAll<X>(uniqueReference);

        }

        public IRelation AddRelation(T uniqueObject_1, T uniqueObject_2)
        { 
            if(!Contains(uniqueObject_1) || !Contains(uniqueObject_2))
            {
                return default;
            }

            OneToOneBidirectionalRelation result = new OneToOneBidirectionalRelation(new UniqueReference(uniqueObject_1), new UniqueReference(uniqueObject_2));
            relationCluster.Add(result);

            return result;
        }

        public IRelation AddRelation(IRelation relation)
        {
            if(relation == null)
            {
                return null;
            }

            if(relationCluster == null)
            {
                relationCluster = new RelationCluster();
            }

            if(relationCluster.Add(relation))
            {
                return relation;
            }

            return null;
        }
    }
}
