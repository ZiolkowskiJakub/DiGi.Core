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
    /// <summary>Represents a cluster that associates unique objects with their related relations.</summary>
    /// <typeparam name="TUniqueObject">The type of the unique objects in the cluster.</typeparam>
    /// <typeparam name="XRelation">The type of the relations associated with the unique objects.</typeparam>
    public class UniqueObjectRelationCluster<TUniqueObject, XRelation> : UniqueObjectValueCluster<TUniqueObject> where TUniqueObject : IUniqueObject where XRelation : IRelation
    {
        [JsonInclude, JsonPropertyName("RelationListCluster"), System.ComponentModel.Description("RelationListCluster")]
        private RelationListCluster<XRelation> relationListCluster = [];

        /// <summary>Initializes a new instance of the UniqueObjectRelationCluster class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to deserialize into a cluster.</param>
        public UniqueObjectRelationCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationCluster class.</summary>
        public UniqueObjectRelationCluster()
            : base()
        {
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationCluster class by copying another UniqueObjectRelationCluster.</summary>
        /// <param name="uniqueObjectRelationCluster">The existing cluster to copy from.</param>
        public UniqueObjectRelationCluster(UniqueObjectRelationCluster<TUniqueObject, XRelation>? uniqueObjectRelationCluster)
            : base(uniqueObjectRelationCluster)
        {
            if (uniqueObjectRelationCluster != null)
            {
                relationListCluster = uniqueObjectRelationCluster.relationListCluster == null ? [] : [.. uniqueObjectRelationCluster.relationListCluster];
            }
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationCluster class with the specified unique objects.</summary>
        /// <param name="uniqueObjects">The collection of unique objects to initialize the cluster with.</param>
        public UniqueObjectRelationCluster(IEnumerable<TUniqueObject>? uniqueObjects)
            : base(uniqueObjects)
        {
        }

        /// <summary>Adds a relation to the cluster and returns it if successfully added.</summary>
        /// <typeparam name="ZRelation">The type of the relation.</typeparam>
        /// <param name="relation">The relation to add to the cluster.</param>
        /// <returns>The added relation if successful; otherwise, null.</returns>
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

        /// <summary>Gets a related value of the specified type for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the related unique object.</typeparam>
        /// <param name="value">The unique object to get a related value for.</param>
        /// <param name="func">An optional filter function to apply to the related value.</param>
        /// <returns>The related value, or null if not found.</returns>
        public UUniqueObject? GetRelatedValue<UUniqueObject>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            return GetRelatedValue<UUniqueObject, XRelation>(value, func);
        }

        /// <summary>Gets a related value of the specified relation type for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the related unique object.</typeparam>
        /// <typeparam name="ZRelation">The type of the relation.</typeparam>
        /// <param name="value">The unique object to get a related value for.</param>
        /// <param name="func">An optional filter function to apply to the related value.</param>
        /// <returns>The related value, or null if not found.</returns>
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

        /// <summary>Gets a dictionary mapping unique references to their related values of the specified relation type.</summary>
        /// <typeparam name="UUniqueObject">The type of the related unique objects.</typeparam>
        /// <typeparam name="ZRelation">The type of the relation.</typeparam>
        /// <param name="values">The collection of unique objects to get related values for.</param>
        /// <param name="func">An optional filter function to apply to the related values.</param>
        /// <returns>A dictionary mapping unique references to their related values, or null if none are found.</returns>
        public Dictionary<IUniqueReference, UUniqueObject>? GetRelatedValueDictionary<UUniqueObject, ZRelation>(IEnumerable<TUniqueObject>? values, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            if (values is null)
            {
                return null;
            }

            HashSet<IUniqueReference> uniqueReferences = [];
            foreach (TUniqueObject value in values)
            {
                if (Create.UniqueReference(value) is IUniqueReference uniqueReference)
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            if (uniqueReferences.Count == 0)
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

                if (!isValid_From && !isValid_To)
                {
                    continue;
                }

                UUniqueObject? uniqueObject = default;
                IUniqueReference? uniqueReference = default;

                if (uniqueReference is null && isValid_From)
                {
                    foreach (IUniqueReference uniqueReference_Temp in uniqueReferences)
                    {
                        if (find.Invoke(relation, uniqueReference_Temp, RelationSide.From) is UUniqueObject uniqueObject_Temp)
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

        /// <summary>Gets all related values of the specified relation type for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the related unique objects.</typeparam>
        /// <typeparam name="ZRelation">The type of the relation.</typeparam>
        /// <param name="value">The unique object to get related values for.</param>
        /// <param name="func">An optional filter function to apply to the related values.</param>
        /// <returns>A list of related values, or null if none are found.</returns>
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

        /// <summary>Gets all related values for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the related unique objects.</typeparam>
        /// <param name="value">The unique object to get related values for.</param>
        /// <param name="func">An optional filter function to apply to the related values.</param>
        /// <returns>A list of related values, or null if none are found.</returns>
        public List<UUniqueObject>? GetRelatedValues<UUniqueObject>(TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            return GetRelatedValues<UUniqueObject, XRelation>(value, func);
        }

        /// <summary>Gets the first relation of the specified type that contains the given unique reference and optionally matches the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>The first relation containing the unique reference and matching the predicate, or null.</returns>
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

        /// <summary>Gets the first relation of the specified type that contains the given unique object and optionally matches the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="value">The unique object to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>The first relation containing the unique object and matching the predicate, or null.</returns>
        public ZRelation? GetRelation<ZRelation>(TUniqueObject? value, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            List<ZRelation>? relations = GetRelations(value, func);
            if (relations == null || relations.Count == 0)
            {
                return default;
            }

            return relations[0];
        }

        /// <summary>Gets all relations of the specified type that contain the given unique object and optionally match the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueObject">The unique object to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>A list of relations containing the unique object and matching the predicate, or null.</returns>
        public List<ZRelation>? GetRelations<ZRelation>(TUniqueObject? uniqueObject, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueObject == null)
            {
                return null;
            }

            return GetRelations(Create.UniqueReference(uniqueObject), func);
        }

        /// <summary>Gets all relations of the specified type that contain any of the given unique objects and optionally match the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueObjects">A collection of unique objects to search for.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>A list of relations containing any of the specified unique objects and matching the predicate, or null.</returns>
        public List<ZRelation>? GetRelations<ZRelation>(IEnumerable<TUniqueObject>? uniqueObjects, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueObjects == null)
            {
                return null;
            }

            HashSet<IUniqueReference> uniqueReferences = [];
            foreach (TUniqueObject uniqueObject in uniqueObjects)
            {
                if (Create.UniqueReference(uniqueObject) is IUniqueReference uniqueReference)
                {
                    uniqueReferences.Add(uniqueReference);
                }
            }

            return GetRelations(uniqueReferences, func);
        }

        /// <summary>Gets all relations of the specified type that contain the given unique reference.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference to search for.</param>
        /// <returns>A list of relations containing the unique reference, or null.</returns>
        public List<ZRelation>? GetRelations<ZRelation>(IUniqueReference? uniqueReference) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues<ZRelation>(uniqueReference);
        }

        /// <summary>Gets all relations of the specified type that contain any of the given unique references and optionally match the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReferences">The collection of unique references used to filter the relations.</param>
        /// <param name="func">An optional predicate to further filter the resulting relations.</param>
        /// <returns>A list of matching relations, or null if no matches were found.</returns>
        public List<ZRelation>? GetRelations<ZRelation>(IEnumerable<IUniqueReference>? uniqueReferences, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReferences, func);
        }

        /// <summary>Gets all relations of the specified type that contain the given unique reference and optionally match the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference used to filter the relations.</param>
        /// <param name="func">An optional predicate to further filter the resulting relations.</param>
        /// <returns>A list of matching relations, or null if no matches were found.</returns>
        public List<ZRelation>? GetRelations<ZRelation>(IUniqueReference? uniqueReference, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            return relationListCluster.GetValues(uniqueReference, func);
        }

        /// <summary>Gets the unique object of the specified type from the relation on the given side.</summary>
        /// <typeparam name="UUniqueObject">The type of unique object to retrieve.</typeparam>
        /// <param name="relation">The relation to query.</param>
        /// <param name="relationSide">The side of the relation to retrieve the value from.</param>
        /// <returns>The unique object found, or null if no such object exists.</returns>
        public UUniqueObject? GetValue<UUniqueObject>(XRelation? relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<IUniqueReference>? uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return default;
            }

            return GetValue<UUniqueObject>(uniqueReferences.First());
        }

        /// <summary>Gets all unique objects of the specified type from the relation on the given side.</summary>
        /// <typeparam name="UUniqueObject">The type of unique object to retrieve.</typeparam>
        /// <param name="relation">The relation to query.</param>
        /// <param name="relationSide">The side of the relation to retrieve values from.</param>
        /// <returns>A list of unique objects found, or null if no objects were found.</returns>
        public List<UUniqueObject>? GetValues<UUniqueObject>(XRelation? relation, RelationSide relationSide) where UUniqueObject : TUniqueObject
        {
            HashSet<IUniqueReference>? uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null)
            {
                return null;
            }

            return GetValues<UUniqueObject>(uniqueReferences);
        }

        /// <summary>Removes the specified unique references and returns the affected references.</summary>
        /// <param name="keys_2">The collection of unique references to remove.</param>
        /// <returns>A list of the removed unique references, or null if no references were removed.</returns>
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

        /// <summary>Removes the specified unique object and its associated relations.</summary>
        /// <param name="uniqueObject">The unique object to remove.</param>
        /// <returns>True if the unique object was successfully removed; otherwise, false.</returns>
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

        /// <summary>Removes the specified unique objects and returns those that were successfully removed.</summary>
        /// <typeparam name="UUniqueObject">The type of the unique objects.</typeparam>
        /// <param name="uniqueObjects">The collection of unique objects to remove.</param>
        /// <returns>A list of unique objects that were successfully removed, or null if none were removed.</returns>
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

        /// <summary>Removes the specified relation from the cluster.</summary>
        /// <param name="relation">The relation to remove.</param>
        /// <returns>True if the relation was successfully removed; otherwise, false.</returns>
        public virtual bool Remove(XRelation? relation)
        {
            if (relation == null)
            {
                return false;
            }

            return relationListCluster.Remove(relation);
        }

        /// <summary>Tries to get a related value of the specified type for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the unique object.</typeparam>
        /// <param name="uniqueObject">When this method returns, contains the related value if found; otherwise, null.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="func">An optional function to filter the results.</param>
        /// <returns>True if a related value was found; otherwise, false.</returns>
        public bool TryGetRelatedValue<UUniqueObject>(out UUniqueObject? uniqueObject, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObject = GetRelatedValue(value, func);

            return uniqueObject != null;
        }

        /// <summary>Tries to get a related value of the specified type for the given unique object using the specified relation type.</summary>
        /// <typeparam name="UUniqueObject">The type of the unique object.</typeparam>
        /// <typeparam name="ZRelation">The type of the relation.</typeparam>
        /// <param name="uniqueObject">When this method returns, contains the related value if found; otherwise, null.</param>
        /// <param name="value">The value to search for.</param>
        /// <param name="func">An optional function to filter the results.</param>
        /// <returns>True if a related value was found; otherwise, false.</returns>
        public bool TryGetRelatedValue<UUniqueObject, ZRelation>(out UUniqueObject? uniqueObject, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObject = GetRelatedValue<UUniqueObject, ZRelation>(value, func);

            return uniqueObject != null;
        }

        /// <summary>Tries to get all related values of the specified type for the given unique object.</summary>
        /// <typeparam name="UUniqueObject">The type of the unique objects to retrieve.</typeparam>
        /// <param name="uniqueObjects">When this method returns, contains the list of related unique objects found; otherwise, null.</param>
        /// <param name="value">The unique object for which to retrieve related values.</param>
        /// <param name="func">An optional predicate to filter the related values.</param>
        /// <returns>True if one or more related values were found; otherwise, false.</returns>
        public bool TryGetRelatedValues<UUniqueObject>(out List<UUniqueObject>? uniqueObjects, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject
        {
            uniqueObjects = GetRelatedValues(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        /// <summary>Tries to get all related values of the specified type for the given unique object using the specified relation type.</summary>
        /// <typeparam name="UUniqueObject">The type of the unique objects to retrieve.</typeparam>
        /// <typeparam name="ZRelation">The type of the relation used to find the values.</typeparam>
        /// <param name="uniqueObjects">When this method returns, contains the list of related unique objects found; otherwise, null.</param>
        /// <param name="value">The unique object for which to retrieve related values.</param>
        /// <param name="func">An optional predicate to filter the related values.</param>
        /// <returns>True if one or more related values were found; otherwise, false.</returns>
        public bool TryGetRelatedValues<UUniqueObject, ZRelation>(out List<UUniqueObject>? uniqueObjects, TUniqueObject? value, Func<UUniqueObject?, bool>? func = null) where UUniqueObject : TUniqueObject where ZRelation : XRelation
        {
            uniqueObjects = GetRelatedValues<UUniqueObject, ZRelation>(value, func);

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        /// <summary>Tries to get a relation of the specified type that optionally matches the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="relation">When this method returns, contains the relation found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the relation.</param>
        /// <returns>True if a matching relation was found; otherwise, false.</returns>
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

        /// <summary>Tries to get a relation of the specified type that contains the given unique reference and optionally matches the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference used to identify the relation.</param>
        /// <param name="relation">When this method returns, contains the relation found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the relation.</param>
        /// <returns>True if a matching relation was found; otherwise, false.</returns>
        public bool TryGetRelation<ZRelation>(IUniqueReference? uniqueReference, out ZRelation? relation, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            relation = GetRelation(uniqueReference, func);

            return relation != null;
        }

        /// <summary>Tries to get all relations of the specified type that optionally match the predicate.</summary>
        /// <typeparam name="ZRelation">The type of relation to retrieve.</typeparam>
        /// <param name="relations">When this method returns, contains the list of relations found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>True if one or more relations were found; otherwise, false.</returns>
        public bool TryGetRelations<ZRelation>(out List<ZRelation>? relations, Func<ZRelation?, bool>? func = null) where ZRelation : XRelation
        {
            relations = relationListCluster?.GetValues(func);

            return relations != null && relations.Count > 0;
        }
    }
}