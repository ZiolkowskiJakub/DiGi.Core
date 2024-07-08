using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class RelationCluster : SerializableObject, ICluster<IRelation>
    {
        [JsonIgnore]
        Dictionary<TypeReference, RelationCollection> dictionary = new Dictionary<TypeReference, RelationCollection>();

        public RelationCluster() 
            :base()
        { 

        }

        public RelationCluster(IEnumerable<IRelation> relations)
        {

        }

        public RelationCluster(RelationCluster relationCluster)
        {

        }

        public RelationCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonInclude, JsonPropertyName("Objects"), System.ComponentModel.Description("Objects")]
        public List<IRelation> Objects
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<IRelation> result = new List<IRelation>();
                foreach (List<IRelation> relations in dictionary.Values)
                {
                    if (relations == null)
                    {
                        continue;
                    }

                    foreach (IRelation relation in relations)
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
                    dictionary = new Dictionary<TypeReference, RelationCollection>();
                }

                foreach (IRelation relation in value)
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

        public bool Add(IRelation relation)
        {
            if (relation == null)
            {
                return false;
            }

            TypeReference typeReference = new TypeReference(relation);

            if (!dictionary.TryGetValue(typeReference, out RelationCollection relationCollection) || relationCollection == null)
            {
                relationCollection = new RelationCollection();
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
            foreach(KeyValuePair<TypeReference, RelationCollection> keyValuePair in dictionary)
            {
                if(keyValuePair.Value == null || keyValuePair.Value.Count == 0)
                {
                    typeReferences.Add(keyValuePair.Key);
                    continue;
                }

                int count = keyValuePair.Value.Count;

                for (int i = count - 1; i >= 0; i--)
                {
                    IRelation relation = keyValuePair.Value[i];
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

        public List<T> FindAll<T>(UniqueReference uniqueReference, bool exactMatch = false) where T: IRelation
        {
            if(uniqueReference == null || dictionary == null)
            {
                return null;
            }

            TypeReference typeReference = uniqueReference.TypeReference;

            if (exactMatch)
            {
                if (!dictionary.TryGetValue(typeReference, out RelationCollection relationCollection))
                {
                    return null;
                }

                return relationCollection.FindAll<T>(uniqueReference);
            }

            System.Type type = typeReference;

            List<T> result = new List<T>();
            foreach(KeyValuePair<TypeReference, RelationCollection> keyValuePair in dictionary)
            {
                System.Type type_Temp = keyValuePair.Key;

                if(!type_Temp.IsAssignableFrom(type))
                {
                    continue;
                }

                List<T> relations = keyValuePair.Value.FindAll<T>(uniqueReference);
                if(relations == null)
                {
                    continue;
                }

                result.AddRange(relations);
            }

            return result;
        }
    }
}
