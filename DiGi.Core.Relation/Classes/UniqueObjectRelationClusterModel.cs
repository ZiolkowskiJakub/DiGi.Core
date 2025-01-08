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
    public abstract class UniqueObjectRelationClusterModel<TUniqueObject, XRelation> : UniqueModel where TUniqueObject : IUniqueObject where XRelation : IRelation
    {
        [JsonInclude, JsonPropertyName("UniqueObjectRelationCluster")]
        protected UniqueObjectRelationCluster<TUniqueObject, XRelation> uniqueObjectRelationCluster = new UniqueObjectRelationCluster<TUniqueObject, XRelation>();

        public UniqueObjectRelationClusterModel()
        {
        }

        public UniqueObjectRelationClusterModel(UniqueObjectRelationClusterModel<TUniqueObject, XRelation> uniqueObjectRelationClusterModel)
            : base(uniqueObjectRelationClusterModel)
        {
            if (uniqueObjectRelationClusterModel != null)
            {
                uniqueObjectRelationCluster = uniqueObjectRelationCluster?.Clone<UniqueObjectRelationCluster<TUniqueObject, XRelation>>();
            }
        }

        public UniqueObjectRelationClusterModel(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Guid GetNewGuid(Type type)
        {
            return Create.Guid(uniqueObjectRelationCluster, type);
        }

        public Guid GetNewGuid<YUniqueObject>() where YUniqueObject : TUniqueObject
        {
            return Create.Guid(uniqueObjectRelationCluster, typeof(YUniqueObject));
        }

        public YUniqueObject GetObject<YUniqueObject>(Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObject(out YUniqueObject result, func))
            {
                return result;
            }

            return default;
        }

        public YUniqueObject GetObject<YUniqueObject>(GuidReference guidReference) where YUniqueObject : TUniqueObject
        {
            if(guidReference == null)
            {
                return default;
            }

            return uniqueObjectRelationCluster.GetValue<YUniqueObject>(guidReference);
        }

        public List<YUniqueObject> GetObjects<YUniqueObject>(Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(out List<YUniqueObject> result, func))
            {
                return result;
            }

            return default;
        }

        public List<YUniqueObject> GetObjects<YUniqueObject>(XRelation relation, RelationSide relationSide, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(relation, relationSide, out List<YUniqueObject> result, func))
            {
                return result;
            }

            return default;
        }

        public YUniqueObject GetRelatedObject<YUniqueObject>(TUniqueObject uniqueObject, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            return uniqueObjectRelationCluster.GetRelatedValue<YUniqueObject>(uniqueObject, func);
        }

        public List<YUniqueObject> GetRelatedObjects<YUniqueObject>(TUniqueObject uniqueObject, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            if (uniqueObject == null)
            {
                return null;
            }

            if (!TryGetRelatedObjects(uniqueObject, out List<YUniqueObject> result, func))
            {
                return null;
            }

            return result;
        }

        public YUniqueObject GetRelation<YUniqueObject>(Func<YUniqueObject, bool> func = null) where YUniqueObject : XRelation
        {
            if (TryGetRelation(out YUniqueObject result, func))
            {
                return result;
            }

            return default;
        }

        public URelation GetRelation<URelation>(TUniqueObject uniqueObject, Func<URelation, bool> func = null) where URelation : XRelation
        {
            if(uniqueObject == null)
            {
                return default;
            }

            URelation relation = uniqueObjectRelationCluster.GetRelation(new GuidReference(uniqueObject), func);
            if(relation == null)
            {
                return default;
            }

            return relation.Clone<URelation>();
        }

        public List<URelation> GetRelations<URelation>(Func<URelation, bool> func = null) where URelation : XRelation
        {
            if (TryGetRelations(out List<URelation> result, func))
            {
                return result;
            }

            return default;
        }

        public virtual bool TryGetObject<YUniqueObject>(out YUniqueObject uniqueObject, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValue(out YUniqueObject uniqueObject_Temp, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            uniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return uniqueObject != null;
        }

        public bool TryGetObject<YUniqueObject>(GuidReference guidReference, out YUniqueObject uniqueObject) where YUniqueObject : TUniqueObject
        {
            uniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValue(guidReference, out YUniqueObject uniqueObject_Temp) || uniqueObject_Temp == null)
            {
                return false;
            }

            uniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return uniqueObject != null;
        }

        public virtual bool TryGetObjects<YUniqueObject>(out List<YUniqueObject> uniqueObjects, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObjects = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValues(out List<YUniqueObject> uniqueObjects_Temp, func) || uniqueObjects_Temp == null)
            {
                return false;
            }

            uniqueObjects = new List<YUniqueObject>();
            foreach (YUniqueObject uniqeObject in uniqueObjects_Temp)
            {
                if (uniqeObject == null)
                {
                    continue;
                }

                YUniqueObject uniqeObject_Temp = uniqeObject.Clone<YUniqueObject>();
                if (uniqeObject_Temp == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqeObject_Temp);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public virtual bool TryGetObjects<YUniqueObject>(XRelation relation, RelationSide relationSide, out List<YUniqueObject> uniqueObjects, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObjects = null;

            HashSet<IUniqueReference> uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return false;
            }

            uniqueObjects = new List<YUniqueObject>();
            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                GuidReference guidReference = uniqueReference as GuidReference;

                if (guidReference == null)
                {
                    continue;
                }

                YUniqueObject uniqueObject = GetObject<YUniqueObject>(guidReference);
                if (uniqueObject == null)
                {
                    continue;
                }

                if (func != null && !func(uniqueObject))
                {
                    continue;
                }

                uniqueObject = uniqueObject.Clone<YUniqueObject>();
                if (uniqueObject == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqueObject);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public virtual bool TryGetRelatedObject<YUniqueObject>(TUniqueObject uniqueObject, out YUniqueObject relatedUniqueObject, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            relatedUniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValue(out YUniqueObject uniqueObject_Temp, uniqueObject, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            relatedUniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return relatedUniqueObject != null;
        }

        public virtual bool TryGetRelatedObject<YUniqueObject, URelation>(TUniqueObject uniqueObject, out YUniqueObject relatedUniqueObject, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            relatedUniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValue<YUniqueObject, URelation>(out YUniqueObject uniqueObject_Temp, uniqueObject, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            relatedUniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return relatedUniqueObject != null;
        }

        public virtual bool TryGetRelatedObjects<YUniqueObject>(TUniqueObject uniqueObject, out List<YUniqueObject> uniqueObjects, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject
        {
            return TryGetRelatedObjects<YUniqueObject, XRelation>(uniqueObject, out uniqueObjects, func);
        }

        public virtual bool TryGetRelatedObjects<YUniqueObject, URelation>(TUniqueObject uniqueObject, out List<YUniqueObject> uniqueObjects, Func<YUniqueObject, bool> func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            uniqueObjects = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValues<YUniqueObject, URelation>(out List<YUniqueObject> uniqueObjects_Temp, uniqueObject, func) || uniqueObjects_Temp == null)
            {
                return false;
            }

            uniqueObjects = new List<YUniqueObject>();
            foreach (YUniqueObject uniqeObject in uniqueObjects_Temp)
            {
                if (uniqeObject == null)
                {
                    continue;
                }

                YUniqueObject uniqeObject_Temp = uniqeObject.Clone<YUniqueObject>();
                if (uniqeObject_Temp == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqeObject_Temp);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelation<URelation>(TUniqueObject uniqueObject, out URelation relation, Func<URelation, bool> func = null) where URelation : XRelation
        {
            relation = default;
            if(uniqueObject == null)
            {
                return false;
            }

            if(!uniqueObjectRelationCluster.TryGetRelation<URelation>(new GuidReference(uniqueObject), out relation, func) || relation == null)
            {
                return false;
            }

            relation = relation.Clone<URelation>();
            return relation != null;
        }
        
        public virtual bool TryGetRelation<URelation>(out URelation relation, Func<URelation, bool> func = null) where URelation : XRelation
        {
            relation = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelation(out URelation relation_Temp, func) || relation_Temp == null)
            {
                return false;
            }

            relation = relation_Temp.Clone<URelation>();
            return relation != null;
        }

        public virtual bool TryGetRelations<URelation>(out List<URelation> relations, Func<URelation, bool> func = null) where URelation : XRelation
        {
            relations = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelations(out List<URelation> relations_Temp, func) || relations_Temp == null)
            {
                return false;
            }

            relations = new List<URelation>();
            foreach (URelation relation in relations_Temp)
            {
                if (relation == null)
                {
                    continue;
                }

                URelation relation_Temp = relation.Clone<URelation>();
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
