using DiGi.Core.Classes;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationListCluster<XRelation> : SerializableObjectListCluster<TypeReference, TypeReference, XRelation> where XRelation : IRelation 
    {
        public RelationListCluster() 
            :base()
        { 

        }

        public RelationListCluster(IEnumerable<XRelation> relations)
            :base(relations)
        {
        }

        public RelationListCluster(RelationListCluster<XRelation> relationListCluster)
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

        private List<RelationListClusterReference> GetRelationListClusterReferences<U, X>(IEnumerable<X> uniqueReferences, Func<U, bool> func = null) where U : XRelation where X : UniqueReference
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
                            if(x.Contains(RelationSide.Undefined, uniqueReference_Temp))
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

        private List<RelationListClusterReference> GetRelationListClusterReferences<U>(UniqueReference uniqueReference, Func<U, bool> func = null) where U : XRelation
        {
            if(uniqueReference == null)
            {
                return null;
            }

            return GetRelationListClusterReferences(new UniqueReference[] { uniqueReference }, func);
        }

        public List<URelation> GetValues<URelation>(UniqueReference uniqueReference, Func<URelation, bool> func = null) where URelation : XRelation
        {
            List<RelationListClusterReference> relationListClusterRefereces = GetRelationListClusterReferences(uniqueReference, func);
            if(relationListClusterRefereces == null)
            {
                return null;
            }

            return GetValues<URelation>(relationListClusterRefereces);
        }

        public List<XRelation> Remove<XUniqueReference>(IEnumerable<XUniqueReference> uniqueReferences) where XUniqueReference: UniqueReference
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<XUniqueReference> uniqueReferences_Temp = new List<XUniqueReference>(uniqueReferences.Distinct());

            List<RelationListClusterReference> relationListClusterReferences = GetRelationListClusterReferences<XRelation, XUniqueReference>(uniqueReferences_Temp);
            if (relationListClusterReferences == null || relationListClusterReferences.Count == 0)
            {
                return null;
            }

            List<XRelation> result = new List<XRelation>();

            List<RelationListClusterReference> relationListClusterReferences_ToRemove = new List<RelationListClusterReference>();

            foreach (RelationListClusterReference relationListClusterReference in relationListClusterReferences)
            {
                XRelation relation = GetValue<XRelation>(relationListClusterReference);

                List<UniqueReference> uniqueReferences_Removed = relation.Remove(RelationSide.Undefined, uniqueReferences_Temp);
                if(uniqueReferences_Removed == null || uniqueReferences_Removed.Count == 0)
                {
                    continue;
                }

                result.Add(relation);

                if(!relation.Has(RelationSide.Undefined))
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

            List<XRelation> relations = Remove(new UniqueReference[] { uniqueReference });
            return relations != null && relations.Count > 0;
        }

        protected override TypeReference GetKey_1(XRelation value)
        {
            return Create.TypeReference(value?.GetType(RelationSide.From));
        }

        protected override TypeReference GetKey_2(XRelation value)
        {
            return Create.TypeReference(value?.GetType(RelationSide.To));
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
