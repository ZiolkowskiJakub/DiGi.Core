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

            IUniqueReference uniqueReference = Create.UniqueReference(value);

            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
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

                if (!relation.Contains(RelationSide.To, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To))
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

            IUniqueReference uniqueReference = Create.UniqueReference(value);

            List<UUniqueObject> result = new List<UUniqueObject>();
            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
                {
                    List<UUniqueObject> values = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.From)?.Cast<GuidReference>());
                    if (values != null)
                    {
                        result.AddRange(values);
                    }
                }

                if (!relation.Contains(RelationSide.To, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To))
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

        public ZRelation GetRelation<ZRelation>(IUniqueReference uniqueReference, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return default;
            }

            List<ZRelation> values = relationListCluster.GetValues(uniqueReference, func);
            if (values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public ZRelation GetRelation<ZRelation>(TUniqueObject value, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            List<ZRelation> relations = GetRelations(value, func);
            if (relations == null || relations.Count == 0)
            {
                return default;
            }

            return relations[0];
        }

        public List<ZRelation> GetRelations<ZRelation>(TUniqueObject uniqueObject, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            if (uniqueObject == null)
            {
                return null;
            }

            return GetRelations(Create.UniqueReference(uniqueObject), func);
        }

        public List<ZRelation> GetRelations<ZRelation>(IUniqueReference uniqueReference) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<ZRelation>(uniqueReference);
        }

        public List<ZRelation> GetRelations<ZRelation>(IUniqueReference uniqueReference, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReference, func);
        }

        public List<UUniqueObject> GetValues<UUniqueObject>(XRelation relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<IUniqueReference> uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null)
            {
                return null;
            }

            List<GuidReference> guidReferences = new List<GuidReference>();
            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is GuidReference)
                {
                    guidReferences.Add((GuidReference)uniqueReference);
                }
            }


            return GetValues<UUniqueObject>(guidReferences);
        }

        public override List<IUniqueReference> Remove(IEnumerable<IUniqueReference> keys_2)
        {
            List<IUniqueReference> result = base.Remove(keys_2);
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

            IUniqueReference uniqueReference = Create.UniqueReference(uniqueObject);

            bool result = Remove(uniqueReference);
            if(result)
            {
                relationListCluster.Remove(uniqueReference);
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

        public bool TryGetRelation<ZRelation>(IUniqueReference uniqueReference, out ZRelation relation, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            relation = GetRelation(uniqueReference, func);

            return relation != null;
        }

        public bool TryGetRelations<ZRelation>(out List<ZRelation> relations, Func<ZRelation, bool> func = null) where ZRelation : XRelation
        {
            relations = relationListCluster?.GetValues(func);

            return relations != null && relations.Count > 0;
        }
    }
}
