using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Provides a base class for unique objects that manage relations through a UniqueObjectRelationCluster.</summary>
    /// <typeparam name="TUniqueObject">The type of the unique object.</typeparam>
    /// <typeparam name="XRelation">The type of the relation.</typeparam>
    public abstract class UniqueObjectRelationClusterModel<TUniqueObject, XRelation> : GuidModel where TUniqueObject : IUniqueObject where XRelation : IRelation
    {
        [JsonInclude, JsonPropertyName("UniqueObjectRelationCluster")]
        protected UniqueObjectRelationCluster<TUniqueObject, XRelation> uniqueObjectRelationCluster = [];

        /// <summary>Initializes a new instance of the UniqueObjectRelationClusterModel class.</summary>
        public UniqueObjectRelationClusterModel()
        {
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationClusterModel class by cloning another instance.</summary>
        /// <param name="uniqueObjectRelationClusterModel">The existing model instance to clone from.</param>
        public UniqueObjectRelationClusterModel(UniqueObjectRelationClusterModel<TUniqueObject, XRelation>? uniqueObjectRelationClusterModel)
            : base(uniqueObjectRelationClusterModel)
        {
            if (uniqueObjectRelationClusterModel != null)
            {
                UniqueObjectRelationCluster<TUniqueObject, XRelation>? uniqueObjectRelationCluster = uniqueObjectRelationClusterModel.uniqueObjectRelationCluster?.Clone<UniqueObjectRelationCluster<TUniqueObject, XRelation>>();
                if (uniqueObjectRelationCluster != null)
                {
                    this.uniqueObjectRelationCluster = uniqueObjectRelationCluster;
                }
            }
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationClusterModel class from a JsonObject.</summary>
        /// <param name="jsonObject">The JSON object to initialize the model from.</param>
        public UniqueObjectRelationClusterModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a new Guid for a unique object of the specified type.</summary>
        /// <param name="type">The type of the unique object.</param>
        /// <returns>A new unique identifier (Guid).</returns>
        public Guid GetNewGuid(Type? type)
        {
            return Create.Guid(uniqueObjectRelationCluster, type);
        }

        /// <summary>Creates a new Guid for a unique object of the specified generic type.</summary>
        /// <typeparam name="YUniqueObject">The type of unique object for which to create a new GUID.</typeparam>
        /// <returns>A new unique identifier (Guid).</returns>
        public Guid GetNewGuid<YUniqueObject>() where YUniqueObject : TUniqueObject
        {
            return Create.Guid(uniqueObjectRelationCluster, typeof(YUniqueObject));
        }

        /// <summary>Gets the first unique object of the specified type that optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of unique object to retrieve.</typeparam>
        /// <param name="func">An optional predicate to filter the unique objects.</param>
        /// <returns>The first unique object that matches the predicate, or null if no match is found.</returns>
        public YUniqueObject? GetObject<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObject(out YUniqueObject? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the unique object of the specified type identified by the given GUID reference.</summary>
        /// <typeparam name="YUniqueObject">The type of unique object to retrieve.</typeparam>
        /// <param name="guidReference">The GUID reference identifying the unique object.</param>
        /// <returns>The unique object associated with the provided GUID reference, or null if not found.</returns>
        public YUniqueObject? GetObject<YUniqueObject>(GuidReference? guidReference) where YUniqueObject : TUniqueObject
        {
            if (guidReference is null)
            {
                return default;
            }

            return uniqueObjectRelationCluster.GetValue<YUniqueObject>(guidReference);
        }

        /// <summary>Gets all unique objects of the specified type that optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of unique object to retrieve.</typeparam>
        /// <param name="func">An optional predicate to filter the unique objects.</param>
        /// <returns>A list of unique objects that match the predicate, or null if none are found.</returns>
        public List<YUniqueObject>? GetObjects<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(out List<YUniqueObject>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets all unique objects of the specified type related through the specified relation on the given side that optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique objects to retrieve.</typeparam>
        /// <param name="relation">The relation used to find the objects.</param>
        /// <param name="relationSide">The side of the relation to query.</param>
        /// <param name="func">An optional predicate to filter the retrieved objects.</param>
        /// <returns>A list of unique objects that match the criteria, or null if none are found.</returns>
        public List<YUniqueObject>? GetObjects<YUniqueObject>(XRelation? relation, RelationSide relationSide, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(relation, relationSide, out List<YUniqueObject>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the related object of the specified type for the given unique object that optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related object.</typeparam>
        /// <param name="uniqueObject">The unique object to find a relation for.</param>
        /// <param name="func">An optional predicate to filter the related object.</param>
        /// <returns>The related object that matches the criteria, or null if not found.</returns>
        public YUniqueObject? GetRelatedObject<YUniqueObject>(TUniqueObject? uniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return uniqueObjectRelationCluster.GetRelatedValue(uniqueObject, func);
        }

        /// <summary>Gets a dictionary mapping unique references to related objects of the specified type for the given unique objects.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <param name="uniqueObjects">The collection of unique objects to find relations for.</param>
        /// <param name="func">An optional predicate to filter the related objects.</param>
        /// <returns>A dictionary mapping unique references to their corresponding related objects, or null if none are found.</returns>
        public Dictionary<IUniqueReference, YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject>(IEnumerable<TUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return GetRelatedObjectDictionary<YUniqueObject, XRelation>(uniqueObjects, func);
        }

        /// <summary>Gets a dictionary mapping unique references to related objects of the specified type using the specified relation type.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <typeparam name="URelation">The type of the relation used for mapping.</typeparam>
        /// <param name="uniqueObjects">The collection of unique objects to find relations for.</param>
        /// <param name="func">An optional predicate to filter the related objects.</param>
        /// <returns>A dictionary mapping unique references to their corresponding related objects, or null if none are found.</returns>
        public virtual Dictionary<IUniqueReference, YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject, URelation>(IEnumerable<TUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            if (uniqueObjects is null)
            {
                return null;
            }

            return uniqueObjectRelationCluster.GetRelatedValueDictionary<YUniqueObject, URelation>(uniqueObjects, func);
        }

        /// <summary>Gets all related objects of the specified type for the given unique objects that optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <param name="uniqueObjects">The collection of unique objects to find relations for.</param>
        /// <param name="func">An optional predicate to filter the related objects.</param>
        /// <returns>A list of related objects that match the criteria, or null if none are found.</returns>
        public List<YUniqueObject>? GetRelatedObjects<YUniqueObject>(IEnumerable<TUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            Dictionary<IUniqueReference, YUniqueObject>? dictionary = GetRelatedObjectDictionary(uniqueObjects, func);
            if (dictionary is null)
            {
                return null;
            }

            List<YUniqueObject> result = [];
            foreach (YUniqueObject uniqueObject in dictionary.Values)
            {
                result.Add(uniqueObject);
            }

            return result;
        }

        /// <summary>Gets all related objects of the specified type for the given unique object that optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <param name="uniqueObject">The unique object to find relations for.</param>
        /// <param name="func">An optional predicate to filter the related objects.</param>
        /// <returns>A list of related objects that match the predicate, or null if none are found.</returns>
        public List<YUniqueObject>? GetRelatedObjects<YUniqueObject>(TUniqueObject? uniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (uniqueObject == null)
            {
                return null;
            }

            if (!TryGetRelatedObjects(uniqueObject, out List<YUniqueObject>? result, func))
            {
                return null;
            }

            return result;
        }

        /// <summary>Gets the first relation of the specified type that optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique object.</typeparam>
        /// <param name="func">An optional predicate to filter the result.</param>
        /// <returns>The first matching unique object, or null if not found.</returns>
        public YUniqueObject? GetRelation<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : XRelation
        {
            if (TryGetRelation(out YUniqueObject? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the relation of the specified type for the given unique object that optionally matches the predicate.</summary>
        /// <typeparam name="URelation">The type of the relation.</typeparam>
        /// <param name="uniqueObject">The unique object for which to get the relation.</param>
        /// <param name="func">An optional predicate to filter the relation.</param>
        /// <returns>The relation that matches the predicate, or null if not found.</returns>
        public URelation? GetRelation<URelation>(TUniqueObject? uniqueObject, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            if (uniqueObject == null)
            {
                return default;
            }

            URelation? relation = uniqueObjectRelationCluster.GetRelation(Create.UniqueReference(uniqueObject), func);
            if (relation == null)
            {
                return default;
            }

            return relation.Clone<URelation>();
        }

        /// <summary>Gets all relations of the specified type that optionally match the predicate.</summary>
        /// <typeparam name="URelation">The type of the relation.</typeparam>
        /// <param name="func">An optional predicate to filter the relations.</param>
        /// <returns>A list of relations that match the predicate, or null if none are found.</returns>
        public List<URelation>? GetRelations<URelation>(Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            if (TryGetRelations(out List<URelation>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Determines whether a unique object of the specified type exists and optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique object.</typeparam>
        /// <param name="uniqueObject">When this method returns, contains the unique object if found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the unique object.</param>
        /// <returns>True if the unique object was found and matches the predicate; otherwise, false.</returns>
        public virtual bool TryGetObject<YUniqueObject>(out YUniqueObject? uniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValue(out YUniqueObject? uniqueObject_Temp, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            uniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return uniqueObject != null;
        }

        /// <summary>Determines whether a unique object of the specified type exists for the given GUID reference.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique object to retrieve.</typeparam>
        /// <param name="guidReference">The GUID reference of the unique object.</param>
        /// <param name="uniqueObject">When this method returns, contains the unique object if found; otherwise, null.</param>
        /// <returns>True if a unique object was found for the given GUID reference; otherwise, false.</returns>
        public bool TryGetObject<YUniqueObject>(GuidReference? guidReference, out YUniqueObject? uniqueObject) where YUniqueObject : TUniqueObject
        {
            uniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValue(guidReference, out YUniqueObject? uniqueObject_Temp) || uniqueObject_Temp == null)
            {
                return false;
            }

            uniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return uniqueObject != null;
        }

        /// <summary>Determines whether any unique objects of the specified type exist and optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique objects to retrieve.</typeparam>
        /// <param name="uniqueObjects">When this method returns, contains a list of found unique objects if any exist; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the unique objects.</param>
        /// <returns>True if one or more unique objects were found that match the predicate; otherwise, false.</returns>
        public virtual bool TryGetObjects<YUniqueObject>(out List<YUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObjects = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetValues(out List<YUniqueObject>? uniqueObjects_Temp, func) || uniqueObjects_Temp == null)
            {
                return false;
            }

            uniqueObjects = [];
            foreach (YUniqueObject uniqeObject in uniqueObjects_Temp)
            {
                if (uniqeObject == null)
                {
                    continue;
                }

                YUniqueObject? uniqeObject_Temp = uniqeObject.Clone<YUniqueObject>();
                if (uniqeObject_Temp == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqeObject_Temp);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        /// <summary>Determines whether any unique objects of the specified type exist that are related through the specified relation on the given side and optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the unique objects to retrieve.</typeparam>
        /// <param name="relation">The relation used to find the unique objects.</param>
        /// <param name="relationSide">The side of the relation to search on.</param>
        /// <param name="uniqueObjects">When this method returns, contains a list of found unique objects if any exist; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the unique objects.</param>
        /// <returns>True if one or more unique objects were found that match the predicate; otherwise, false.</returns>
        public virtual bool TryGetObjects<YUniqueObject>(XRelation? relation, RelationSide relationSide, out List<YUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            uniqueObjects = null;

            HashSet<IUniqueReference>? uniqueReferences = Query.UniqueReferences(relation, relationSide);
            if (uniqueReferences == null || uniqueReferences.Count == 0)
            {
                return false;
            }

            uniqueObjects = [];
            foreach (IUniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference is not GuidReference guidReference)
                {
                    continue;
                }

                YUniqueObject? uniqueObject = GetObject<YUniqueObject>(guidReference);
                if (uniqueObject == null)
                {
                    continue;
                }

                if (func != null && !func(uniqueObject))
                {
                    continue;
                }

                uniqueObject = uniqueObject.Clone<YUniqueObject>();
                if (uniqueObject == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqueObject);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        /// <summary>Determines whether a related object of the specified type exists for the given unique object and optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related unique object.</typeparam>
        /// <param name="uniqueObject">The unique object for which to find a related object.</param>
        /// <param name="relatedUniqueObject">When this method returns, contains the related unique object if found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the related object.</param>
        /// <returns>True if a related object was found that matches the predicate; otherwise, false.</returns>
        public virtual bool TryGetRelatedObject<YUniqueObject>(TUniqueObject? uniqueObject, out YUniqueObject? relatedUniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            relatedUniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValue(out YUniqueObject? uniqueObject_Temp, uniqueObject, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            relatedUniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return relatedUniqueObject != null;
        }

        /// <summary>Determines whether a related object of the specified type exists for the given unique object using the specified relation type and optionally matches the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related unique object.</typeparam>
        /// <typeparam name="URelation">The type of the relation used to find the related object.</typeparam>
        /// <param name="uniqueObject">The unique object for which to find a related object.</param>
        /// <param name="relatedUniqueObject">When this method returns, contains the related unique object if found; otherwise, null.</param>
        /// <param name="func">An optional predicate to filter the related object.</param>
        /// <returns>True if a related object was found that matches the predicate; otherwise, false.</returns>
        public virtual bool TryGetRelatedObject<YUniqueObject, URelation>(TUniqueObject? uniqueObject, out YUniqueObject? relatedUniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            relatedUniqueObject = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValue<YUniqueObject, URelation>(out YUniqueObject? uniqueObject_Temp, uniqueObject, func) || uniqueObject_Temp == null)
            {
                return false;
            }

            relatedUniqueObject = uniqueObject_Temp.Clone<YUniqueObject>();
            return relatedUniqueObject != null;
        }

        /// <summary>Determines whether any related objects of the specified type exist for the given unique object and optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <param name="uniqueObject">The unique object to evaluate.</param>
        /// <param name="uniqueObjects">When this method returns, contains a list of related objects found; otherwise, null.</param>
        /// <param name="func">An optional predicate used to filter the related objects.</param>
        /// <returns>True if one or more related objects were found; otherwise, false.</returns>
        public virtual bool TryGetRelatedObjects<YUniqueObject>(TUniqueObject? uniqueObject, out List<YUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return TryGetRelatedObjects<YUniqueObject, XRelation>(uniqueObject, out uniqueObjects, func);
        }

        /// <summary>Determines whether any related objects of the specified type exist for the given unique object using the specified relation type and optionally match the predicate.</summary>
        /// <typeparam name="YUniqueObject">The type of the related objects.</typeparam>
        /// <typeparam name="URelation">The type of the relation used to identify related objects.</typeparam>
        /// <param name="uniqueObject">The unique object to evaluate.</param>
        /// <param name="uniqueObjects">When this method returns, contains a list of related objects found; otherwise, null.</param>
        /// <param name="func">An optional predicate used to filter the related objects.</param>
        /// <returns>True if one or more related objects were found; otherwise, false.</returns>
        public virtual bool TryGetRelatedObjects<YUniqueObject, URelation>(TUniqueObject? uniqueObject, out List<YUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            uniqueObjects = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelatedValues<YUniqueObject, URelation>(out List<YUniqueObject>? uniqueObjects_Temp, uniqueObject, func) || uniqueObjects_Temp == null)
            {
                return false;
            }

            uniqueObjects = [];
            foreach (YUniqueObject uniqeObject in uniqueObjects_Temp)
            {
                if (uniqeObject == null)
                {
                    continue;
                }

                YUniqueObject? uniqeObject_Temp = uniqeObject.Clone<YUniqueObject>();
                if (uniqeObject_Temp == null)
                {
                    continue;
                }

                uniqueObjects.Add(uniqeObject_Temp);
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        /// <summary>Determines whether a relation of the specified type exists for the given unique object and optionally matches the predicate.</summary>
        /// <typeparam name="URelation">The type of relation to search for.</typeparam>
        /// <param name="uniqueObject">The unique object to evaluate.</param>
        /// <param name="relation">When this method returns, contains the relation found; otherwise, null.</param>
        /// <param name="func">An optional predicate used to filter the relation.</param>
        /// <returns>True if a relation was found for the specified object; otherwise, false.</returns>
        public bool TryGetRelation<URelation>(TUniqueObject uniqueObject, out URelation? relation, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            relation = default;
            if (uniqueObject == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelation(Create.UniqueReference(uniqueObject), out relation, func) || relation == null)
            {
                return false;
            }

            relation = relation.Clone<URelation>();
            return relation != null;
        }

        /// <summary>Determines whether a relation of the specified type exists and optionally matches the predicate.</summary>
        /// <typeparam name="URelation">The type of relation to search for.</typeparam>
        /// <param name="relation">When this method returns, contains the relation found; otherwise, null.</param>
        /// <param name="func">An optional predicate used to filter the relation.</param>
        /// <returns>True if a relation was found; otherwise, false.</returns>
        public virtual bool TryGetRelation<URelation>(out URelation? relation, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            relation = default;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelation(out URelation? relation_Temp, func) || relation_Temp == null)
            {
                return false;
            }

            relation = relation_Temp.Clone<URelation>();
            return relation != null;
        }

        /// <summary>Determines whether any relations of the specified type exist and optionally match the predicate.</summary>
        /// <typeparam name="URelation">The type of relation to search for.</typeparam>
        /// <param name="relations">When this method returns, contains a list of relations found; otherwise, null.</param>
        /// <param name="func">An optional predicate used to filter the relations.</param>
        /// <returns>True if one or more relations were found; otherwise, false.</returns>
        public virtual bool TryGetRelations<URelation>(out List<URelation>? relations, Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            relations = null;

            if (uniqueObjectRelationCluster == null)
            {
                return false;
            }

            if (!uniqueObjectRelationCluster.TryGetRelations(out List<URelation>? relations_Temp, func) || relations_Temp == null)
            {
                return false;
            }

            relations = [];
            foreach (URelation relation in relations_Temp)
            {
                if (relation == null)
                {
                    continue;
                }

                URelation? relation_Temp = relation.Clone<URelation>();
                if (relation_Temp == null)
                {
                    continue;
                }

                relations.Add(relation_Temp);
            }

            return relations != null && relations.Count != 0;
        }
    }
}