using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

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

        private List<ListClusterReference<TypeReference, TypeReference>> GetListClusterReferences<U>(UniqueReference uniqueReference, Func<U, bool> func = null) where U : T
        {
            Type type = uniqueReference?.TypeReference?.Type();
            if (type == null)
            {
                return null;
            }

            List<TypeReference> typeReferences_1 = GetKeys_1();
            if (typeReferences_1 == null)
            {
                return null;
            }

            List<ListClusterReference<TypeReference, TypeReference>> result = new List<ListClusterReference<TypeReference, TypeReference>>();
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

                    if (!type.IsAssignableFrom(type_1) && !type.IsAssignableFrom(type_2))
                    {
                        continue;
                    }

                    Func<U, bool> func_Temp = new Func<U, bool>( x => 
                    { 
                       if(func != null && !func.Invoke(x))
                        {
                            return false;
                        }

                        return x.Contains_To(uniqueReference) || x.Contains_From(uniqueReference);

                    });

                    List<int> indexes = GetIndexes(typeReference_1, typeReference_2, func_Temp);
                    if (indexes == null)
                    {
                        continue;
                    }

                    foreach(int index in indexes)
                    {
                        result.Add(new ListClusterReference<TypeReference, TypeReference>(typeReference_1, typeReference_2, index));
                    }
                }
            }

            return result;
        }

        public List<U> GetValues<U>(UniqueReference uniqueReference, Func<U, bool> func = null) where U : T
        {
            List<ListClusterReference<TypeReference, TypeReference>> listClusterRefereces = GetListClusterReferences(uniqueReference, func);
            if(listClusterRefereces == null)
            {
                return null;
            }

            return GetValues<U>(listClusterRefereces);
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            List<ListClusterReference<TypeReference, TypeReference>> listClusterReferences = GetListClusterReferences<T>(uniqueReference);
            if(listClusterReferences == null || listClusterReferences.Count == 0)
            {
                return false;
            }


            List<T> relations = GetValues<T>(uniqueReference);
            if(relations == null || relations.Count == 0)
            {
                return false;
            }

            List<ListClusterReference<TypeReference, TypeReference>> listClusterReferences_ToRemove = new List<ListClusterReference<TypeReference, TypeReference>>();

            foreach (ListClusterReference<TypeReference, TypeReference> ListClusterReference in listClusterReferences)
            {
                T relation = GetValue<T>(ListClusterReference);

                if (relation is IOneToOneRelation)
                {
                    listClusterReferences_ToRemove.Add(ListClusterReference);
                }
                else if (relation is IOneToManyRelation)
                {
                    IOneToManyRelation oneToManyRelation = (IOneToManyRelation)relation;
                    if (oneToManyRelation.Contains_From(uniqueReference))
                    {
                        listClusterReferences_ToRemove.Add(ListClusterReference);
                    }
                    else
                    {
                        if (oneToManyRelation.Remove_To(uniqueReference))
                        {
                            List<UniqueReference> uniqueReferences = oneToManyRelation.UniqueReferences_To;
                            if (uniqueReferences == null || uniqueReferences.Count == 0)
                            {
                                listClusterReferences_ToRemove.Add(ListClusterReference);
                            }
                        }

                    }
                }
                else if (relation is IManyToOneRelation)
                {
                    IManyToOneRelation manyToOneRelation = (IManyToOneRelation)relation;
                    if (manyToOneRelation.Contains_To(uniqueReference))
                    {
                        listClusterReferences_ToRemove.Add(ListClusterReference);
                    }
                    else
                    {
                        if (manyToOneRelation.Remove_From(uniqueReference))
                        {
                            List<UniqueReference> uniqueReferences = manyToOneRelation.UniqueReferences_From;
                            if (uniqueReferences == null || uniqueReferences.Count == 0)
                            {
                                listClusterReferences_ToRemove.Add(ListClusterReference);
                            }
                        }

                    }
                }
                else if (relation is IManyToManyRelation)
                {
                    IManyToManyRelation manyToManyRelation = (IManyToManyRelation)relation;

                    bool removed = false;

                    if (manyToManyRelation.Remove_From(uniqueReference))
                    {
                        List<UniqueReference> uniqueReferences = manyToManyRelation.UniqueReferences_From;
                        if (uniqueReferences == null || uniqueReferences.Count == 0)
                        {
                            listClusterReferences_ToRemove.Add(ListClusterReference);
                            removed = true;
                        }
                    }

                    if (!removed)
                    {
                        if (manyToManyRelation.Remove_To(uniqueReference))
                        {
                            List<UniqueReference> uniqueReferences = manyToManyRelation.UniqueReferences_To;
                            if (uniqueReferences == null || uniqueReferences.Count == 0)
                            {
                                listClusterReferences_ToRemove.Add(ListClusterReference);
                            }
                        }
                    }
                }
                else
                {
                    throw new NotImplementedException();
                }
            }


            if(listClusterReferences_ToRemove != null && listClusterReferences_ToRemove.Count != 0)
            {
                Remove(listClusterReferences_ToRemove);
            }

            return true;
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
