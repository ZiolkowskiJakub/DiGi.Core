using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public abstract class UniqueObjectRelationClusterModel<T, X> : UniqueModel where T : IUniqueObject where X : IRelation
    {
        [JsonInclude, JsonPropertyName("UniqueObjectRelationCluster")]
        protected UniqueObjectRelationCluster<T, X> uniqueObjectRelationCluster = new UniqueObjectRelationCluster<T, X>();

        public UniqueObjectRelationClusterModel()
        {
        }

        public UniqueObjectRelationClusterModel(UniqueObjectRelationClusterModel<T, X> uniqueObjectRelationClusterModel)
            : base(uniqueObjectRelationClusterModel)
        {
            if (uniqueObjectRelationClusterModel != null)
            {
                uniqueObjectRelationCluster = uniqueObjectRelationCluster?.Clone<UniqueObjectRelationCluster<T, X>>();
            }
        }

        public UniqueObjectRelationClusterModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public List<TypeReference> TypeReferences
        {
            get
            {
                return uniqueObjectRelationCluster?.TypeReferences;
            }
        }

        public Guid GetNewGuid(Type type)
        {
            return Create.Guid(uniqueObjectRelationCluster, type);
        }

        public Guid GetNewGuid<Y>() where Y : T
        {
            return Create.Guid(uniqueObjectRelationCluster, typeof(Y));
        }

        public Y GetObject<Y>(Func<Y, bool> func = null) where Y : T
        {
            if (TryGetObject(out Y result, func))
            {
                return result;
            }

            return default;
        }

        public List<Y> GetObjects<Y>(Func<Y, bool> func = null) where Y : T
        {
            if (TryGetObjects(out List<Y> result, func))
            {
                return result;
            }

            return default;
        }
        
        public Y GetRelation<Y>(Func<Y, bool> func = null) where Y : X
        {
            if (TryGetRelation(out Y result, func))
            {
                return result;
            }

            return default;
        }

        public List<Y> GetRelations<Y>(Func<Y, bool> func = null) where Y : X
        {
            if (TryGetRelations(out List<Y> result, func))
            {
                return result;
            }

            return default;
        }
        
        public virtual bool TryGetObject<U>(out U uniqueObject, Func<U, bool> func = null) where U : T
        {
            uniqueObject = default;

            if(uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if(!uniqueObjectRelationCluster.TryGetObject(out U uniqueObject_Temp, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            uniqueObject = uniqueObject_Temp.Clone<U>();
            return uniqueObject != null;
        }

        public virtual bool TryGetObjects<U>(out List<U> uniqueObjects, Func<U, bool> func = null) where U : T
        {
            uniqueObjects = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetObjects(out List<U> uniqueObjects_Temp, func) || uniqueObjects_Temp == null)
            {
                return false;
            }

            uniqueObjects = new List<U>();
            foreach(U uniqeObject in uniqueObjects_Temp)
            {
                if(uniqeObject == null)
                {
                    continue;
                }

                U uniqeObject_Temp = uniqeObject.Clone<U>();
                if(uniqeObject_Temp == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqeObject_Temp);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public virtual bool TryGetRelation<U>(out U relation, Func<U, bool> func = null) where U : X
        {
            relation = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelation(out U relation_Temp, func) || relation_Temp == null)
            {
                return false;
            }

            relation = relation_Temp.Clone<U>();
            return relation != null;
        }

        public virtual bool TryGetRelations<U>(out List<U> relations, Func<U, bool> func = null) where U : X
        {
            relations = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelations(out List<U> relations_Temp, func) || relations_Temp == null)
            {
                return false;
            }

            relations = new List<U>();
            foreach (U relation in relations_Temp)
            {
                if (relation == null)
                {
                    continue;
                }

                U relation_Temp = relation.Clone<U>();
                if (relation_Temp == null)
                {
                    continue;
                }

                relations.Add(relation_Temp);
            }

            return relations != null && relations.Count != 0;
        }
    }
}
