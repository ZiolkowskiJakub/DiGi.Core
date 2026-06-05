using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a cluster that organizes relations by their source type references.</summary>
    /// <typeparam name="XRelation">The type of relation used in the cluster.</typeparam>
    public class RelationListCluster<XRelation> : SerializableObjectListCluster<TypeReference, TypeReference, XRelation> where XRelation : IRelation
    {
        /// <summary>Initializes a new instance of the RelationListCluster class.</summary>
        public RelationListCluster()
            : base()
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class with the specified relations.</summary>
        /// <param name="relations">The collection of relations to initialize the cluster with.</param>
        public RelationListCluster(IEnumerable<XRelation>? relations)
            : base(relations)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class by copying another RelationListCluster.</summary>
        /// <param name="relationListCluster">The source cluster to copy from.</param>
        public RelationListCluster(RelationListCluster<XRelation>? relationListCluster)
            : base(relationListCluster)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to initialize the cluster from.</param>
        public RelationListCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Gets the list of source type references.</summary>
        public List<TypeReference>? TypeReferences_From
        {
            get
            {
                return base.GetKeys_1();
            }
        }

        /// <summary>Gets all relations of the specified type that contain the given unique reference and optionally match the predicate.</summary>
        /// <typeparam name="URelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>A list of matching relations, or null if none are found.</returns>
        public List<URelation>? GetValues<URelation>(IUniqueReference? uniqueReference, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            List<RelationListClusterReference>? relationListClusterRefereces = GetRelationListClusterReferences(uniqueReference, func);
            if (relationListClusterRefereces == null)
            {
                return null;
            }

            return GetValues<URelation>(relationListClusterRefereces);
        }

        /// <summary>Gets all relations of the specified type that contain any of the given unique references and optionally match the predicate.</summary>
        /// <typeparam name="URelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReferences">A collection of unique references to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>A list of matching relations, or null if none are found.</returns>
        public List<URelation>? GetValues<URelation>(IEnumerable<IUniqueReference>? uniqueReferences, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            List<RelationListClusterReference>? relationListClusterRefereces = GetRelationListClusterReferences(uniqueReferences, func);
            if (relationListClusterRefereces == null)
            {
                return null;
            }

            return GetValues<URelation>(relationListClusterRefereces);
        }

        /// <summary>Removes the specified unique references from the relations and returns the affected relations.</summary>
        /// <typeparam name="XUniqueReference">The type of unique reference.</typeparam>
        /// <param name="uniqueReferences">The collection of unique references to remove.</param>
        /// <returns>A list of the affected relations, or null if none were removed.</returns>
        public List<XRelation>? Remove<XUniqueReference>(IEnumerable<XUniqueReference>? uniqueReferences) where XUniqueReference : IUniqueReference
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            List<XUniqueReference> uniqueReferences_Temp = [.. uniqueReferences.Distinct()];

            List<RelationListClusterReference>? relationListClusterReferences = GetRelationListClusterReferences<XRelation, XUniqueReference>(uniqueReferences_Temp);
            if (relationListClusterReferences == null || relationListClusterReferences.Count == 0)
            {
                return null;
            }

            List<XRelation> result = [];

            List<RelationListClusterReference> relationListClusterReferences_ToRemove = [];

            foreach (RelationListClusterReference relationListClusterReference in relationListClusterReferences)
            {
                XRelation? relation = GetValue<XRelation>(relationListClusterReference);
                if (relation == null)
                {
                    continue;
                }

                List<XUniqueReference>? uniqueReferences_Removed = relation.Remove(RelationSide.Undefined, uniqueReferences_Temp);
                if (uniqueReferences_Removed == null || uniqueReferences_Removed.Count == 0)
                {
                    continue;
                }

                result.Add(relation);

                if (!relation.Has(RelationSide.Undefined))
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

        /// <summary>Removes the specified unique reference from the relations.</summary>
        /// <param name="uniqueReference">The unique reference to remove.</param>
        /// <returns>True if the element is successfully removed; otherwise, false.</returns>
        public bool Remove(IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            List<XRelation>? relations = Remove([uniqueReference]);
            return relations != null && relations.Count > 0;
        }

        /// <summary>Gets the source type reference from a relation.</summary>
        protected override TypeReference? GetKey_1(XRelation? value)
        {
            return Create.TypeReference(value?.GetType(RelationSide.From));
        }

        /// <summary>Gets the target type reference from a relation.</summary>
        protected override TypeReference? GetKey_2(XRelation? value)
        {
            return Create.TypeReference(value?.GetType(RelationSide.To));
        }

        private List<RelationListClusterReference>? GetRelationListClusterReferences<URelation, XUniqueReference>(IEnumerable<XUniqueReference>? uniqueReferences, Func<URelation?, bool>? func = null) where URelation : XRelation where XUniqueReference : IUniqueReference
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            HashSet<XUniqueReference> uniqueReferences_Temp = [];
            HashSet<Type> types = [];
            foreach (XUniqueReference uniqueReference in uniqueReferences)
            {
                Type? type = uniqueReference?.TypeReference?.Type();
                if (type != null)
                {
                    types.Add(type);
                    uniqueReferences_Temp.Add(uniqueReference!);
                }
            }

            if (types.Count == 0)
            {
                return null;
            }

            List<TypeReference>? typeReferences_1 = GetKeys_1();
            if (typeReferences_1 == null)
            {
                return null;
            }

            List<RelationListClusterReference> result = [];
            foreach (TypeReference typeReference_1 in typeReferences_1)
            {
                Type? type_1 = typeReference_1?.Type();
                if (type_1 == null)
                {
                    continue;
                }

                List<TypeReference>? typeReferences = GetKeys_2(typeReference_1);
                if (typeReferences == null)
                {
                    continue;
                }

                foreach (TypeReference? typeReference_2 in typeReferences)
                {
                    Type? type_2 = typeReference_2?.Type();
                    if (type_2 == null)
                    {
                        continue;
                    }

                    bool @break = true;

                    foreach (Type type in types)
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

                    Func<URelation?, bool> func_Temp = new(x =>
                    {
                        if (x == null || func != null && !func.Invoke(x))
                        {
                            return false;
                        }

                        foreach (XUniqueReference uniqueReference_Temp in uniqueReferences_Temp)
                        {
                            if (x.Contains(RelationSide.Undefined, uniqueReference_Temp))
                            {
                                return true;
                            }
                        }

                        return false;
                    });

                    List<int>? indexes = GetIndexes(typeReference_1, typeReference_2, func_Temp);
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

        private List<RelationListClusterReference>? GetRelationListClusterReferences<U>(IUniqueReference? uniqueReference, Func<U?, bool>? func = null) where U : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return GetRelationListClusterReferences([uniqueReference], func);
        }
    }

    /// <summary>Represents a cluster that organizes all relations by their source type references.</summary>
    public class RelationListCluster : RelationListCluster<IRelation>
    {
        /// <summary>Initializes a new instance of the RelationListCluster class.</summary>
        public RelationListCluster()
            : base()
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class with the specified relations.</summary>
        /// <param name="relations">The collection of relations to initialize with.</param>
        public RelationListCluster(IEnumerable<IRelation>? relations)
            : base(relations)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class by copying another RelationListCluster.</summary>
        /// <param name="relationCluster">The RelationListCluster to copy from.</param>
        public RelationListCluster(RelationListCluster? relationCluster)
            : base(relationCluster)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public RelationListCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}