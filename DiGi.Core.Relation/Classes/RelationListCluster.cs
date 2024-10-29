using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationListCluster<T> : SerializableObjectListCluster<TypeReference, TypeReference, T> where T : IRelation 
    {
        public RelationListCluster() 
            :base()
        { 

        }

        public RelationListCluster(IEnumerable<T> relations)
            :base(relations)
        {
        }

        public RelationListCluster(RelationListCluster<T> relationListCluster)
            :base(relationListCluster)
        {
        }

        public RelationListCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public List<TypeReference> TypeReferences_From
        {
            get
            {
                return base.GetKeys_1();
            }
        }

        private List<RelationListClusterReference> GetRelationListClusterReferences<U, X>(IEnumerable<X> uniqueReferences, Func<U, bool> func = null) where U : T where X : UniqueReference
        {
            if(uniqueReferences == null)
            {
                return null;
            }

            HashSet<X> uniqueReferences_Temp = new HashSet<X>();
            HashSet<Type> types = new HashSet<Type>();
            foreach(X uniqueReference in uniqueReferences)
            {
                Type type = uniqueReference?.TypeReference?.Type();
                if(type != null)
                {
                    types.Add(type);
                    uniqueReferences_Temp.Add(uniqueReference);
                }
            }

            if(types.Count == 0)
            {
                return null;
            }

            List<TypeReference> typeReferences_1 = GetKeys_1();
            if (typeReferences_1 == null)
            {
                return null;
            }

            List<RelationListClusterReference> result = new List<RelationListClusterReference>();
            foreach (TypeReference typeReference_1 in typeReferences_1)
            {
                Type type_1 = typeReference_1?.Type();
                if (type_1 == null)
                {
                    continue;
                }

                foreach (TypeReference typeReference_2 in GetKeys_2(typeReference_1))
                {
                    Type type_2 = typeReference_2?.Type();
                    if (type_2 == null)
                    {
                        continue;
                    }

                    bool @break = true;

                    foreach(Type type in types)
                    {
                        if (!type_1.IsAssignableFrom(type) && !type_2.IsAssignableFrom(type))
                        {
                            continue;
                        }

                        @break = false;
                        break;
                    }

                    if (@break)
                    {
                        continue;
                    }

                    Func<U, bool> func_Temp = new Func<U, bool>(x =>
                    {
                        if (func != null && !func.Invoke(x))
                        {
                            return false;
                        }

                        foreach(X uniqueReference_Temp in uniqueReferences_Temp)
                        {
                            if(x.Contains_To(uniqueReference_Temp) || x.Contains_From(uniqueReference_Temp))
                            {
                                return true;
                            }
                        }

                        return false;
                    });

                    List<int> indexes = GetIndexes(typeReference_1, typeReference_2, func_Temp);
                    if (indexes == null)
                    {
                        continue;
                    }

                    foreach (int index in indexes)
                    {
                        result.Add(new RelationListClusterReference(typeReference_1, typeReference_2, index));
                    }
                }
            }

            return result;
        }

        private List<RelationListClusterReference> GetRelationListClusterReferences<U>(UniqueReference uniqueReference, Func<U, bool> func = null) where U : T
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return GetRelationListClusterReferences(new UniqueReference[] { uniqueReference }, func);
        }

        public List<U> GetValues<U>(UniqueReference uniqueReference, Func<U, bool> func = null) where U : T
        {
            List<RelationListClusterReference> relationListClusterRefereces = GetRelationListClusterReferences(uniqueReference, func);
            if(relationListClusterRefereces == null)
            {
                return null;
            }

            return GetValues<U>(relationListClusterRefereces);
        }

        public List<T> Remove<X>(IEnumerable<X> uniqueReferences) where X: UniqueReference
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<X> uniqueReferences_Temp = new List<X>(uniqueReferences.Distinct());

            List<RelationListClusterReference> relationListClusterReferences = GetRelationListClusterReferences<T, X>(uniqueReferences_Temp);
            if (relationListClusterReferences == null || relationListClusterReferences.Count == 0)
            {
                return null;
            }

            List<T> result = new List<T>();

            List<RelationListClusterReference> relationListClusterReferences_ToRemove = new List<RelationListClusterReference>();

            foreach (RelationListClusterReference relationListClusterReference in relationListClusterReferences)
            {
                T relation = GetValue<T>(relationListClusterReference);

                List<UniqueReference> uniqueReferences_Removed = relation.Remove(uniqueReferences_Temp);
                if(uniqueReferences_Removed == null || uniqueReferences_Removed.Count == 0)
                {
                    continue;
                }

                result.Add(relation);

                if(!relation.Has_From() || !relation.Has_To())
                {
                    relationListClusterReferences_ToRemove.Add(relationListClusterReference);
                }
            }

            if (relationListClusterReferences_ToRemove != null && relationListClusterReferences_ToRemove.Count != 0)
            {
                base.Remove(relationListClusterReferences_ToRemove);
            }

            return result;
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            List<T> relations = Remove(new UniqueReference[] { uniqueReference });
            return relations != null && relations.Count > 0;
        }

        protected override TypeReference GetKey_1(T value)
        {
            return Create.TypeReference(value?.GetType_From());
        }

        protected override TypeReference GetKey_2(T value)
        {
            return Create.TypeReference(value?.GetType_To());
        }
    }

    public class RelationListCluster : RelationListCluster<IRelation>
    {
        public RelationListCluster()
            : base()
        {

        }

        public RelationListCluster(IEnumerable<IRelation> relations)
            : base(relations)
        {

        }

        public RelationListCluster(RelationListCluster relationCluster)
            : base(relationCluster)
        {

        }

        public RelationListCluster(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
