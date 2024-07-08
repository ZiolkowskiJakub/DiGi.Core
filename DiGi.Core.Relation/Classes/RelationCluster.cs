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
    public class RelationCluster<T> : SerializableObject, ICluster<T> where T : IRelation
    {
        [JsonIgnore]
        Dictionary<TypeReference, RelationCollection<T>> dictionary = new Dictionary<TypeReference, RelationCollection<T>>();

        public RelationCluster() 
            :base()
        { 

        }

        public RelationCluster(IEnumerable<T> relations)
        {
            if(relations != null)
            {
                foreach(T relation in relations)
                {
                    Add(relation);
                }
            }
        }

        public RelationCluster(RelationCluster<T> relationCluster)
        {
            if(relationCluster != null)
            {
                dictionary = new Dictionary<TypeReference, RelationCollection<T>>();
                foreach (KeyValuePair<TypeReference, RelationCollection<T>> keyValuePair in relationCluster.dictionary)
                {
                    dictionary[keyValuePair.Key] = keyValuePair.Value == null ? null : new RelationCollection<T>(keyValuePair.Value);
                }
            }
        }

        public RelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Objects"), System.ComponentModel.Description("Objects")]
        public List<T> Objects
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<T> result = new List<T>();
                foreach (List<T> relations in dictionary.Values)
                {
                    if (relations == null)
                    {
                        continue;
                    }

                    foreach (T relation in relations)
                    {
                        result.Add(relation);
                    }
                }
                return result;
            }

            set
            {
                Clear();

                if (value == null)
                {
                    return;
                }

                if (dictionary == null)
                {
                    dictionary = new Dictionary<TypeReference, RelationCollection<T>>();
                }

                foreach (T relation in value)
                {
                    Add(relation);
                }
            }
        }

        public List<TypeReference> TypeReferences
        {
            get
            {
                return dictionary?.Keys.ToList();
            }
        }

        public bool Add<X>(X relation) where X : T
        {
            if (relation == null)
            {
                return false;
            }

            TypeReference typeReference = new TypeReference(relation);

            if (!dictionary.TryGetValue(typeReference, out RelationCollection<T> relationCollection) || relationCollection == null)
            {
                relationCollection = new RelationCollection<T>();
                dictionary[typeReference] = relationCollection;
            }

            relationCollection.Add(relation);
            return true;
        }

        public void Clear()
        {
            dictionary?.Clear();
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            bool result = false;

            List<TypeReference> typeReferences = new List<TypeReference>();
            foreach(KeyValuePair<TypeReference, RelationCollection<T>> keyValuePair in dictionary)
            {
                if(keyValuePair.Value == null || keyValuePair.Value.Count == 0)
                {
                    typeReferences.Add(keyValuePair.Key);
                    continue;
                }

                int count = keyValuePair.Value.Count;

                for (int i = count - 1; i >= 0; i--)
                {
                    T relation = keyValuePair.Value[i];
                    if (relation == null || !relation.Contains(uniqueReference))
                    {
                        continue;
                    }

                    if (relation is IOneToOneRelation)
                    {
                        keyValuePair.Value.RemoveAt(i);
                        result = true;
                        continue;
                    }

                    if(keyValuePair.Value.Count == 0)
                    {
                        typeReferences.Add(keyValuePair.Key);
                    }

                    throw new System.NotImplementedException();
                }
            }

            foreach(TypeReference typeReference in typeReferences)
            {
                dictionary.Remove(typeReference);
            }

            return result;
        }

        public bool Remove(T relation)
        {
            if(relation == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(new TypeReference(relation), out RelationCollection<T> relationCollection))
            {
                return false;
            }

            return relationCollection.Remove(relation);
        }

        public List<X> FindAll<X>(UniqueReference uniqueReference, bool exactMatch = false) where X: T
        {
            if(uniqueReference == null || dictionary == null)
            {
                return null;
            }

            TypeReference typeReference = uniqueReference.TypeReference;

            if (exactMatch)
            {
                if (!dictionary.TryGetValue(typeReference, out RelationCollection<T> relationCollection))
                {
                    return null;
                }

                return relationCollection.FindAll<X>(uniqueReference);
            }

            System.Type type = typeReference;

            List<X> result = new List<X>();
            foreach(KeyValuePair<TypeReference, RelationCollection<T>> keyValuePair in dictionary)
            {
                System.Type type_Temp = keyValuePair.Key;

                if(!type_Temp.IsAssignableFrom(type))
                {
                    continue;
                }

                List<X> relations = keyValuePair.Value.FindAll<X>(uniqueReference);
                if(relations == null)
                {
                    continue;
                }

                result.AddRange(relations);
            }

            return result;
        }

        public X Find<X>(UniqueReference uniqueReference, Func<X, bool> func = null, bool exactMatch = false) where X : T
        {
            if (uniqueReference == null || dictionary == null)
            {
                return default;
            }

            TypeReference typeReference = uniqueReference.TypeReference;

            if (exactMatch)
            {
                if (!dictionary.TryGetValue(typeReference, out RelationCollection<T> relationCollection))
                {
                    return default;
                }

                return relationCollection.Find<X>(uniqueReference, func);
            }

            Type type = typeReference;

            foreach (KeyValuePair<TypeReference, RelationCollection<T>> keyValuePair in dictionary)
            {
                Type type_Temp = keyValuePair.Key;

                if (!type_Temp.IsAssignableFrom(type))
                {
                    continue;
                }

                X result = keyValuePair.Value.Find<X>(uniqueReference, func);
                if (result != null)
                {
                    return result;
                }
            }

            return default;
        }
    }

    public class RelationCluster : RelationCluster<IRelation>
    {
        public RelationCluster()
            : base()
        {

        }

        public RelationCluster(IEnumerable<IRelation> relations)
            : base(relations)
        {

        }

        public RelationCluster(RelationCluster relationCluster)
            : base(relationCluster)
        {

        }

        public RelationCluster(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
