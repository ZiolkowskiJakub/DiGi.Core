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
    public abstract class UniqueObjectRelationClusterModel<TUniqueObject, XRelation> : GuidModel where TUniqueObject : IUniqueObject where XRelation : IRelation
    {
        [JsonInclude, JsonPropertyName("UniqueObjectRelationCluster")]
        protected UniqueObjectRelationCluster<TUniqueObject, XRelation> uniqueObjectRelationCluster = [];

        /// <summary>Initializes a new instance of the UniqueObjectRelationClusterModel class.</summary>
        public UniqueObjectRelationClusterModel()
        {
        }

        /// <summary>Initializes a new instance of the UniqueObjectRelationClusterModel class by cloning another instance.</summary>
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
        public UniqueObjectRelationClusterModel(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Creates a new Guid for a unique object of the specified type.</summary>
        public Guid GetNewGuid(Type? type)
        {
            return Create.Guid(uniqueObjectRelationCluster, type);
        }

        /// <summary>Creates a new Guid for a unique object of the specified generic type.</summary>
        public Guid GetNewGuid<YUniqueObject>() where YUniqueObject : TUniqueObject
        {
            return Create.Guid(uniqueObjectRelationCluster, typeof(YUniqueObject));
        }

        /// <summary>Gets the first unique object of the specified type that optionally matches the predicate.</summary>
        public YUniqueObject? GetObject<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObject(out YUniqueObject? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the unique object of the specified type identified by the given GUID reference.</summary>
        public YUniqueObject? GetObject<YUniqueObject>(GuidReference? guidReference) where YUniqueObject : TUniqueObject
        {
            if (guidReference is null)
            {
                return default;
            }

            return uniqueObjectRelationCluster.GetValue<YUniqueObject>(guidReference);
        }

        /// <summary>Gets all unique objects of the specified type that optionally match the predicate.</summary>
        public List<YUniqueObject>? GetObjects<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(out List<YUniqueObject>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets all unique objects of the specified type related through the specified relation on the given side that optionally match the predicate.</summary>
        public List<YUniqueObject>? GetObjects<YUniqueObject>(XRelation? relation, RelationSide relationSide, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            if (TryGetObjects(relation, relationSide, out List<YUniqueObject>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the related object of the specified type for the given unique object that optionally matches the predicate.</summary>
        public YUniqueObject? GetRelatedObject<YUniqueObject>(TUniqueObject? uniqueObject, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return uniqueObjectRelationCluster.GetRelatedValue(uniqueObject, func);
        }

        /// <summary>Gets a dictionary mapping unique references to related objects of the specified type for the given unique objects.</summary>
        public Dictionary<IUniqueReference, YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject>(IEnumerable<TUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return GetRelatedObjectDictionary<YUniqueObject, XRelation>(uniqueObjects, func);
        }

        /// <summary>Gets a dictionary mapping unique references to related objects of the specified type using the specified relation type.</summary>
        public virtual Dictionary<IUniqueReference, YUniqueObject>? GetRelatedObjectDictionary<YUniqueObject, URelation>(IEnumerable<TUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject where URelation : XRelation
        {
            if (uniqueObjects is null)
            {
                return null;
            }

            return uniqueObjectRelationCluster.GetRelatedValueDictionary<YUniqueObject, URelation>(uniqueObjects, func);
        }

        /// <summary>Gets all related objects of the specified type for the given unique objects that optionally match the predicate.</summary>
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
        public YUniqueObject? GetRelation<YUniqueObject>(Func<YUniqueObject?, bool>? func = null) where YUniqueObject : XRelation
        {
            if (TryGetRelation(out YUniqueObject? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Gets the relation of the specified type for the given unique object that optionally matches the predicate.</summary>
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
        public List<URelation>? GetRelations<URelation>(Func<URelation?, bool>? func = null) where URelation : XRelation
        {
            if (TryGetRelations(out List<URelation>? result, func))
            {
                return result;
            }

            return default;
        }

        /// <summary>Determines whether a unique object of the specified type exists and optionally matches the predicate.</summary>
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
        public virtual bool TryGetRelatedObjects<YUniqueObject>(TUniqueObject? uniqueObject, out List<YUniqueObject>? uniqueObjects, Func<YUniqueObject?, bool>? func = null) where YUniqueObject : TUniqueObject
        {
            return TryGetRelatedObjects<YUniqueObject, XRelation>(uniqueObject, out uniqueObjects, func);
        }

        /// <summary>Determines whether any related objects of the specified type exist for the given unique object using the specified relation type and optionally match the predicate.</summary>
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