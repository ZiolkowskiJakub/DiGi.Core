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
    public class RelationListCluster<XRelation> : SerializableObjectListCluster<TypeReference, TypeReference, XRelation> where XRelation : IRelation
    {
        /// <summary>Initializes a new instance of the RelationListCluster class.</summary>
        public RelationListCluster()
            : base()
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class with the specified relations.</summary>
        public RelationListCluster(IEnumerable<XRelation>? relations)
            : base(relations)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class by copying another RelationListCluster.</summary>
        public RelationListCluster(RelationListCluster<XRelation>? relationListCluster)
            : base(relationListCluster)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class from a JSON object.</summary>
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
        public RelationListCluster(IEnumerable<IRelation>? relations)
            : base(relations)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class by copying another RelationListCluster.</summary>
        public RelationListCluster(RelationListCluster? relationCluster)
            : base(relationCluster)
        {
        }

        /// <summary>Initializes a new instance of the RelationListCluster class from a JSON object.</summary>
        public RelationListCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}