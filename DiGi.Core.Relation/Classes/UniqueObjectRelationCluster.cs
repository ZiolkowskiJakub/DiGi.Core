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
    public class UniqueObjectRelationCluster<TUniqueObject, XRelation> : UniqueObjectValueCluster<TUniqueObject> where TUniqueObject : IUniqueObject where XRelation : IRelation
    {
        [JsonInclude, JsonPropertyName("RelationListCluster"), System.ComponentModel.Description("RelationListCluster")]
        private RelationListCluster<XRelation> relationListCluster = [];

        public UniqueObjectRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public UniqueObjectRelationCluster()
            : base()
        {
        }

        public UniqueObjectRelationCluster(UniqueObjectRelationCluster<TUniqueObject, XRelation>? uniqueObjectRelationCluster)
            : base(uniqueObjectRelationCluster)
        {
            if (uniqueObjectRelationCluster != null)
            {
                relationListCluster = uniqueObjectRelationCluster.relationListCluster == null ? [] : [.. uniqueObjectRelationCluster.relationListCluster];
            }
        }

        public UniqueObjectRelationCluster(IEnumerable<TUniqueObject>? uniqueObjects)
            : base(uniqueObjects)
        {
        }

        public ZRelation? AddRelation<ZRelation>(ZRelation? relation) where ZRelation : XRelation
        {
            if (relation == null)
            {
                return default;
            }

            relationListCluster ??= [];

            if (relationListCluster.Add(relation))
            {
                return relation;
            }

            return default;
        }

        public UUniqueObject? GetRelatedValue<UUniqueObject>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            return GetRelatedValue<UUniqueObject, XRelation>(value, func);
        }

        public UUniqueObject? GetRelatedValue<UUniqueObject, ZRelation>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if (value == null)
            {
                return default;
            }

            IUniqueReference? uniqueReference = Create.UniqueReference(value);

            List<ZRelation>? relations = GetRelations<ZRelation>(uniqueReference);
            if (relations == null)
            {
                return default;
            }

            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
                {
                    List<UUniqueObject>? relatedValues = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.From));
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
                    List<UUniqueObject>? relatedValues = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.To));
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

        public Dictionary<IUniqueReference, UUniqueObject>? GetRelatedValueDictionary<UUniqueObject, ZRelation>(IEnumerable<TUniqueObject>? values, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if(values is null)
            {
                return null;
            }

            HashSet<IUniqueReference> uniqueReferences = [];
            foreach (TUniqueObject value in values)
            {
                if(Create.UniqueReference(value) is IUniqueReference uniqueReference)
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            if(uniqueReferences.Count == 0)
            {
                return [];
            }

            List<ZRelation>? relations = GetRelations<ZRelation>(uniqueReferences);
            if (relations == null || relations.Count == 0)
            {
                return [];
            }


            Dictionary<IUniqueReference, UUniqueObject> result = [];

            Func<XRelation, IUniqueReference, RelationSide, UUniqueObject?> find = new((relation, uniqueReference, relationSide) =>
            {
                if (relation.Contains(relationSide, uniqueReference))
                {
                    return default;
                }

                List<UUniqueObject>? relatedValues = GetValues<UUniqueObject>(Query.UniqueReferences(relation, relationSide));
                if (relatedValues == null || relatedValues.Count == 0)
                {
                    return default;
                }

                foreach (UUniqueObject relatedValue in relatedValues)
                {
                    if (func != null && !func.Invoke(relatedValue))
                    {
                        continue;
                    }

                    return relatedValue;
                }

                return default;
            });

            foreach (XRelation relation in relations)
            {
                bool isValid_From = Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From);
                bool isValid_To = Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To);

                if(!isValid_From && !isValid_To)
                {
                    continue;
                }

                UUniqueObject? uniqueObject = default;
                IUniqueReference? uniqueReference = default;

                if (uniqueReference is null && isValid_From)
                {
                    foreach(IUniqueReference uniqueReference_Temp in uniqueReferences)
                    {
                        if(find.Invoke(relation, uniqueReference_Temp, RelationSide.From) is UUniqueObject uniqueObject_Temp)
                        {
                            uniqueObject = uniqueObject_Temp;
                            uniqueReference = uniqueReference_Temp;
                            break;
                        }
                    }
                }

                if (uniqueReference is null && isValid_To)
                {
                    foreach (IUniqueReference uniqueReference_Temp in uniqueReferences)
                    {
                        if (find.Invoke(relation, uniqueReference_Temp, RelationSide.To) is UUniqueObject uniqueObject_Temp)
                        {
                            uniqueObject = uniqueObject_Temp;
                            uniqueReference = uniqueReference_Temp;
                            break;
                        }
                    }
                }

                if (uniqueReference is not null && uniqueObject is not null)
                {
                    result[uniqueReference] = uniqueObject;
                    uniqueReferences.Remove(uniqueReference);

                    if (uniqueReferences.Count == 0)
                    {
                        break;
                    }
                }
            }

            return result;
        }
        
        public List<UUniqueObject>? GetRelatedValues<UUniqueObject, ZRelation>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if (value == null)
            {
                return null;
            }

            List<ZRelation>? relations = GetRelations<ZRelation>(value);
            if (relations == null)
            {
                return null;
            }

            IUniqueReference? uniqueReference = Create.UniqueReference(value);

            List<UUniqueObject> result = [];
            foreach (XRelation relation in relations)
            {
                if (!relation.Contains(RelationSide.From, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.From))
                {
                    List<UUniqueObject>? values = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.From));
                    if (values != null)
                    {
                        result.AddRange(values);
                    }
                }

                if (!relation.Contains(RelationSide.To, uniqueReference) && Query.IsValid(relation, typeof(UUniqueObject), RelationSide.To))
                {
                    List<UUniqueObject>? values = GetValues<UUniqueObject>(Query.UniqueReferences(relation, RelationSide.To));
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

        public List<UUniqueObject>? GetRelatedValues<UUniqueObject>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            return GetRelatedValues<UUniqueObject, XRelation>(value, func);
        }

        public ZRelation? GetRelation<ZRelation>(IUniqueReference? uniqueReference, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return default;
            }

            List<ZRelation>? values = relationListCluster.GetValues(uniqueReference, func);
            if (values == null || values.Count == 0)
            {
                return default;
            }

            return values[0];
        }

        public ZRelation? GetRelation<ZRelation>(TUniqueObject? value, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            List<ZRelation>? relations = GetRelations(value, func);
            if (relations == null || relations.Count == 0)
            {
                return default;
            }

            return relations[0];
        }

        public List<ZRelation>? GetRelations<ZRelation>(TUniqueObject? uniqueObject, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueObject == null)
            {
                return null;
            }

            return GetRelations(Create.UniqueReference(uniqueObject), func);
        }

        public List<ZRelation>? GetRelations<ZRelation>(IEnumerable<TUniqueObject>? uniqueObjects, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueObjects == null)
            {
                return null;
            }

            HashSet<IUniqueReference> uniqueReferences = [];
            foreach (TUniqueObject uniqueObject in uniqueObjects)
            {
                if(Create.UniqueReference(uniqueObject) is IUniqueReference uniqueReference)
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            return GetRelations(uniqueReferences, func);
        }

        public List<ZRelation>? GetRelations<ZRelation>(IUniqueReference? uniqueReference) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<ZRelation>(uniqueReference);
        }

        public List<ZRelation>? GetRelations<ZRelation>(IEnumerable<IUniqueReference>? uniqueReferences, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReferences, func);
        }

        public List<ZRelation>? GetRelations<ZRelation>(IUniqueReference? uniqueReference, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReference, func);
        }

        public UUniqueObject? GetValue<UUniqueObject>(XRelation? relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<IUniqueReference>? uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return default;
            }

            return GetValue<UUniqueObject>(uniqueReferences.First());
        }

        public List<UUniqueObject>? GetValues<UUniqueObject>(XRelation? relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<IUniqueReference>? uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null)
            {
                return null;
            }

            return GetValues<UUniqueObject>(uniqueReferences);
        }

        public override List<IUniqueReference>? Remove(IEnumerable<IUniqueReference>? keys_2)
        {
            List<IUniqueReference>? result = base.Remove(keys_2);
            if (result == null || result.Count == 0)
            {
                return result;
            }

            relationListCluster.Remove(result);

            return result;
        }

        public override bool Remove(TUniqueObject? uniqueObject)
        {
            if (uniqueObject == null)
            {
                return false;
            }

            IUniqueReference? uniqueReference = Create.UniqueReference(uniqueObject);

            bool result = Remove(uniqueReference);
            if (result)
            {
                relationListCluster.Remove(uniqueReference);
            }

            return result;
        }

        public override List<UUniqueObject>? Remove<UUniqueObject>(IEnumerable<UUniqueObject>? uniqueObjects)
        {
            if (uniqueObjects == null)
            {
                return null;
            }

            List<UUniqueObject> result = [];
            foreach (UUniqueObject uniqueObject in uniqueObjects)
            {
                if (Remove(uniqueObject))
                {
                    result.Add(uniqueObject);
                }
            }

            return result;
        }

        public virtual bool Remove(XRelation? relation)
        {
            if (relation == null)
            {
                return false;
            }

            return relationListCluster.Remove(relation);
        }

        public bool TryGetRelatedValue<UUniqueObject>(out UUniqueObject? uniqueObject, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObject = GetRelatedValue(value, func);

            return uniqueObject != null;
        }

        public bool TryGetRelatedValue<UUniqueObject, ZRelation>(out UUniqueObject? uniqueObject, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObject = GetRelatedValue<UUniqueObject, ZRelation>(value, func);

            return uniqueObject != null;
        }

        public bool TryGetRelatedValues<UUniqueObject>(out List<UUniqueObject>? uniqueObjects, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObjects = GetRelatedValues(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelatedValues<UUniqueObject, ZRelation>(out List<UUniqueObject>? uniqueObjects, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObjects = GetRelatedValues<UUniqueObject, ZRelation>(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelation<ZRelation>(out ZRelation? relation, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            relation = default;
            if (relationListCluster == null)
            {
                return false;
            }

            relation = relationListCluster.GetValue(func);

            return relation != null;
        }

        public bool TryGetRelation<ZRelation>(IUniqueReference? uniqueReference, out ZRelation? relation, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            relation = GetRelation(uniqueReference, func);

            return relation != null;
        }

        public bool TryGetRelations<ZRelation>(out List<ZRelation>? relations, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            relations = relationListCluster?.GetValues(func);

            return relations != null && relations.Count > 0;
        }
    }
}