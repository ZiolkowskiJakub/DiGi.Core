using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    public class UniqueObjectRelationCluster<TUniqueObject, XRelation> : UniqueObjectValueCluster<TUniqueObject> where TUniqueObject : IUniqueObject where XRelation: IRelation
    {
        [JsonInclude, JsonPropertyName("RelationListCluster"), System.ComponentModel.Description("RelationListCluster")]
        private RelationListCluster<XRelation> relationListCluster = new RelationListCluster<XRelation>();

        public UniqueObjectRelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueObjectRelationCluster()
            : base()
        {

        }

        public UniqueObjectRelationCluster(UniqueObjectRelationCluster<TUniqueObject, XRelation> uniqueObjectRelationCluster)
            : base(uniqueObjectRelationCluster)
        {
            if(uniqueObjectRelationCluster != null)
            {

                relationListCluster = uniqueObjectRelationCluster.relationListCluster == null ? null : new RelationListCluster<XRelation>(uniqueObjectRelationCluster.relationListCluster);
            }

        }

        public UniqueObjectRelationCluster(IEnumerable<TUniqueObject> uniqueObjects)
            : base(uniqueObjects)
        {

        }

        public ZRelation AddRelation<ZRelation>(ZRelation relation) where ZRelation : XRelation
        {
            if (relation == null)
            {
                return default;
            }

            if (relationListCluster == null)
            {
                relationListCluster = new RelationListCluster<XRelation>();
            }

            if (relationListCluster.Add(relation))
            {
                return relation;
            }

            return default;
        }

        public UUniqueObject GetRelatedValue<UUniqueObject>(TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject
        {
            return GetRelatedValue<UUniqueObject, XRelation>(value, func);
        }

        public UUniqueObject GetRelatedValue<UUniqueObject, ZRelation>(TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if (value == null)
            {
                return default;
            }

            List<ZRelation> relations = GetRelations<ZRelation>(value);
            if (relations == null)
            {
                return default;
            }

            GuidReference guidReference = new GuidReference(value);

            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, guidReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
                {
                    List<UUniqueObject> relatedValues = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.From)?.Cast<GuidReference>());
                    if (relatedValues != null)
                    {
                        foreach (UUniqueObject relatedValue in relatedValues)
                        {
                            if (func != null && !func.Invoke(relatedValue))
                            {
                                continue;
                            }

                            return relatedValue;
                        }
                    }
                }

                if (!relation.Contains(RelationSide.To, guidReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To))
                {
                    List<UUniqueObject> relatedValues = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.To)?.Cast<GuidReference>());
                    if (relatedValues != null)
                    {
                        foreach (UUniqueObject relatedValue in relatedValues)
                        {
                            if (func != null && !func.Invoke(relatedValue))
                            {
                                continue;
                            }

                            return relatedValue;
                        }
                    }
                }
            }

            return default;
        }

        public List<UUniqueObject> GetRelatedValues<UUniqueObject, ZRelation>(TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if (value == null)
            {
                return null;
            }

            List<ZRelation> relations = GetRelations<ZRelation>(value);
            if (relations == null)
            {
                return null;
            }

            GuidReference guidReference = new GuidReference(value);

            List<UUniqueObject> result = new List<UUniqueObject>();
            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, guidReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
                {
                    List<UUniqueObject> values = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.From)?.Cast<GuidReference>());
                    if (values != null)
                    {
                        result.AddRange(values);
                    }
                }

                if (!relation.Contains(RelationSide.To, guidReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To))
                {
                    List<UUniqueObject> values = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.To)?.Cast<GuidReference>());
                    if (values != null)
                    {
                        result.AddRange(values);
                    }
                }
            }

            if (func != null)
            {
                result.RemoveAll(x => !func(x));
            }

            return result;
        }

        public List<UUniqueObject> GetRelatedValues<UUniqueObject>(TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject
        {

            return GetRelatedValues<UUniqueObject, XRelation>(value, func);
        }

        public ZRelation GetRelation<ZRelation>(GuidReference guidReference, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            if (guidReference == null)
            {
                return default;
            }

            List<ZRelation> values = relationListCluster.GetValues(guidReference, func);
            if (values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public List<ZRelation> GetRelations<ZRelation>(TUniqueObject uniqueObject) where ZRelation : XRelation
        {
            if (uniqueObject == null)
            {
                return null;
            }

            return GetRelations<ZRelation>(new GuidReference(uniqueObject));
        }

        public List<ZRelation> GetRelations<ZRelation>(GuidReference guidReference) where ZRelation : XRelation
        {
            if (guidReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<ZRelation>(guidReference);
        }

        public List<ZRelation> GetRelations<ZRelation>(GuidReference guidReference, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            if (guidReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(guidReference, func);
        }

        public List<UUniqueObject> GetValues<UUniqueObject>(XRelation relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<UniqueReference> uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null)
            {
                return null;
            }

            List<GuidReference> guidReferences = new List<GuidReference>();
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is GuidReference)
                {
                    guidReferences.Add((GuidReference)uniqueReference);
                }
            }


            return GetValues<UUniqueObject>(guidReferences);
        }

        public override List<GuidReference> Remove(IEnumerable<GuidReference> keys_2)
        {
            List<GuidReference> result = base.Remove(keys_2);
            if(result == null || result.Count ==0)
            {
                return result;
            }

            relationListCluster.Remove(result);

            return result;
        }

        public override bool Remove(TUniqueObject uniqueObject)
        {
            if(uniqueObject == null)
            {
                return false;
            }

            GuidReference guidReference = new GuidReference(uniqueObject);

            bool result = Remove(guidReference);
            if(result)
            {
                relationListCluster.Remove(guidReference);
            }

            return result;
        }

        public override List<UUniqueObject> Remove<UUniqueObject>(IEnumerable<UUniqueObject> uniqueObjects)
        {
            if (uniqueObjects == null)
            {
                return null;
            }

            List<UUniqueObject> result = new List<UUniqueObject>();
            foreach(UUniqueObject uniqueObject in uniqueObjects)
            {
                if(Remove(uniqueObject))
                {
                    result.Add(uniqueObject);
                }
            }

            return result;
        }

        public virtual bool Remove(XRelation relation)
        {
            if(relation == null)
            {
                return false;
            }

            return relationListCluster.Remove(relation);
        }
        
        public bool TryGetRelatedValue<UUniqueObject>(out UUniqueObject uniqueObject, TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObject = GetRelatedValue(value, func);

            return uniqueObject != null;
        }

        public bool TryGetRelatedValue<UUniqueObject, ZRelation>(out UUniqueObject uniqueObject, TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObject = GetRelatedValue<UUniqueObject, ZRelation>(value, func);

            return uniqueObject != null;
        }

        public bool TryGetRelatedValues<UUniqueObject>(out List<UUniqueObject> uniqueObjects, TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObjects = GetRelatedValues(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelatedValues<UUniqueObject, ZRelation>(out List<UUniqueObject> uniqueObjects, TUniqueObject value, Func<UUniqueObject, bool> func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObjects = GetRelatedValues<UUniqueObject, ZRelation>(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelation<ZRelation>(out ZRelation relation, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            relation = default;
            if (relationListCluster == null)
            {
                return false;
            }

            relation = relationListCluster.GetValue(func);

            return relation != null;
        }

        public bool TryGetRelation<ZRelation>(GuidReference guidReference, out ZRelation relation, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            relation = GetRelation(guidReference, func);

            return relation != null;
        }

        public bool TryGetRelations<ZRelation>(out List<ZRelation> relations, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            relations = relationListCluster?.GetValues(func);

            return relations != null && relations.Count > 0;
        }
    }
}
