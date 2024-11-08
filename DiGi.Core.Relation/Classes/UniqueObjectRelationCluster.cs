using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public override bool Remove(T uniqueObject)
        {
            if(uniqueObject == null)
            {
                return false;
            }

            return Remove(new GuidReference(uniqueObject));
        }

        public override List<U> Remove<U>(IEnumerable<U> uniqueObjects)
        {
            if (uniqueObjects == null)
            {
                return null;
            }

            List<U> result = new List<U>();
            foreach(U uniqueObject in uniqueObjects)
            {
                if(Remove(uniqueObject))
                {
                    result.Add(uniqueObject);
                }
            }

            return result;
        }

        public virtual bool Remove(X relation)
        {
            if(relation == null)
            {
                return false;
            }

            return relationListCluster.Remove(relation);
        }

        public List<Z> GetRelations<Z>(T uniqueObject) where Z : X
        {
            if(uniqueObject == null)
            {
                return null;
            }

            return GetRelations<Z>(new GuidReference(uniqueObject));
        }

        public List<Z> GetRelations<Z>(GuidReference guidReference) where Z : X
        {
            if(guidReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<Z>(guidReference);
        }

        public List<Z> GetRelations<Z>(GuidReference guidReference, Func<Z, bool> func = null) where Z : X
        {
            if (guidReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(guidReference, func);
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

        public bool TryGetRelation<Z>(GuidReference guidReference, out Z relation, Func<Z, bool> func = null) where Z : X
        {
            relation = GetRelation(guidReference, func);

            return relation != null;
        }

        public Z GetRelation<Z>(GuidReference guidReference, Func<Z, bool> func = null) where Z : X
        {
            if (guidReference == null)
            {
                return default;
            }

            List<Z> values = relationListCluster.GetValues(guidReference, func);
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

        public List<U> GetValues<U>(X relation, bool from = true, bool to = true) where U : T
        {
            HashSet<UniqueReference> uniqueReferences = Query.UniqueReferences(relation, from, to);
            if(uniqueReferences == null)
            {
                return null;
            }

            List<GuidReference> guidReferences = new List<GuidReference>();
            foreach(UniqueReference uniqueReference in uniqueReferences)
            {
                if(uniqueReference is GuidReference)
                {
                    guidReferences.Add((GuidReference)uniqueReference);
                }
            }


            return GetValues<U>(guidReferences);
        }

        public List<U> GetRelatedValues<U>(T value, Func<U, bool> func = null) where U : T
        {
            if(value == null)
            {
                return null;
            }

            List<X> relations = GetRelations<X>(value);
            if(relations == null)
            {
                return null;
            }

            GuidReference guidReference = new GuidReference(value);

            List<U> result = new List<U>();
            foreach(X relation in relations)
            {
                if(!relation.Contains_From(guidReference) && Query.IsValid(relation, typeof(U), true, false))
                {
                    List<U> values = GetValues<U>(Query.UniqueReferences(relation, true, false)?.Cast<GuidReference>());
                    if(values != null)
                    {
                        result.AddRange(values);
                    }
                }

                if (!relation.Contains_To(guidReference) && Query.IsValid(relation, typeof(U), false, true))
                {
                    List<U> values = GetValues<U>(Query.UniqueReferences(relation, false, true)?.Cast<GuidReference>());
                    if (values != null)
                    {
                        result.AddRange(values);
                    }
                }
            }

            if(func != null)
            {
                result.RemoveAll(x => !func(x));
            }

            return result;
        }

        public U GetRelatedValue<U>(T value, Func<U, bool> func = null) where U : T
        {
            if (value == null)
            {
                return default;
            }

            List<X> relations = GetRelations<X>(value);
            if (relations == null)
            {
                return default;
            }

            GuidReference guidReference = new GuidReference(value);

            foreach (X relation in relations)
            {
                if (!relation.Contains_From(guidReference) && Query.IsValid(relation, typeof(U), true, false))
                {
                    List<U> relatedValues = GetValues<U>(Query.UniqueReferences(relation, true, false)?.Cast<GuidReference>());
                    if (relatedValues != null)
                    {
                        foreach (U relatedValue in relatedValues)
                        {
                            if (func != null && !func.Invoke(relatedValue))
                            {
                                continue;
                            }

                            return relatedValue;
                        }
                    }
                }

                if (!relation.Contains_To(guidReference) && Query.IsValid(relation, typeof(U), false, true))
                {
                    List<U> relatedValues = GetValues<U>(Query.UniqueReferences(relation, false, true)?.Cast<GuidReference>());
                    if (relatedValues != null)
                    {
                        foreach (U relatedValue in relatedValues)
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

        public bool TryGetRelatedValues<U>(out List<U> uniqueObjects, T value, Func<U, bool> func = null) where U : T
        {
            uniqueObjects = GetRelatedValues(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetRelatedValue<U>(out U uniqueObject, T value, Func<U, bool> func = null) where U : T
        {
            uniqueObject = GetRelatedValue(value, func);

            return uniqueObject != null;
        }
    }
}
