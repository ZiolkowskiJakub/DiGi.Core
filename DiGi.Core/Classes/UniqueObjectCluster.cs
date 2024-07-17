using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class UniqueObjectCluster<T> : SerializableObject, ICluster where T : IUniqueObject
    {
        [JsonIgnore]
        private Dictionary<TypeReference, Dictionary<UniqueReference, T>> dictionary = new Dictionary<TypeReference, Dictionary<UniqueReference, T>>();

        public UniqueObjectCluster()
        {

        }

        public UniqueObjectCluster(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public UniqueObjectCluster(IEnumerable<T> uniqueObjects)
        {
            Update(uniqueObjects);
        }

        public UniqueObjectCluster(UniqueObjectCluster<T> uniqueObjectCluster)
        {
            Update(uniqueObjectCluster?.Objects);
        }

        [JsonInclude, JsonPropertyName("Objects")]
        public List<T> Objects
        {
            get
            {
                List<T> result = new List<T>();
                foreach (KeyValuePair<TypeReference, Dictionary<UniqueReference, T>> keyValuePair in dictionary)
                {
                    foreach(T uniqueObject in keyValuePair.Value.Values)
                    {
                        result.Add(uniqueObject);
                    }
                }
                return result;
            }

            set
            {
                dictionary.Clear();
                if(value == null)
                {
                    return;
                }

                foreach(T uniqueObject in value)
                {
                    Update(uniqueObject);
                }
            }
        }

        [JsonIgnore]
        public List<TypeReference> TypeReferences
        {
            get
            {
                return dictionary?.Keys?.ToList();
            }
        }

        public bool Contains(UniqueReference uniqueReference)
        {
            TypeReference typeReference = uniqueReference?.TypeReference;
            if (typeReference == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(typeReference, out Dictionary<UniqueReference, T> dictionary_UniqueObject))
            {
                return false;
            }

            return dictionary_UniqueObject.ContainsKey(uniqueReference);
        }

        public bool Contains(T uniqueObject)
        {
            if (uniqueObject == null)
            {
                return false;
            }

            return Contains(new UniqueReference(uniqueObject));
        }

        public virtual bool IsValid(T uniqueObject)
        {
            return uniqueObject != null;
        }

        public virtual bool Remove(UniqueReference uniqueReference)
        {
            TypeReference typeReference = uniqueReference?.TypeReference;
            if (typeReference == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(typeReference, out Dictionary<UniqueReference, T> dictionary_UniqueObject))
            {
                return false;
            }

            if (!dictionary_UniqueObject.Remove(uniqueReference))
            {
                return false;
            }

            if (dictionary_UniqueObject.Count == 0)
            {
                dictionary.Remove(typeReference);
            }

            return true;
        }

        public virtual bool Remove(T uniqueObject)
        {
            if (uniqueObject == null)
            {
                return false;
            }

            return Remove(new UniqueReference(uniqueObject));
        }

        public bool TryGetObject<U>(UniqueReference uniqueReference, out U uniqueObject) where U : T
        {
            uniqueObject = default(U);

            TypeReference typeReference = uniqueReference?.TypeReference;
            if (typeReference == null)
            {
                return false;
            }

            if (!dictionary.TryGetValue(typeReference, out Dictionary<UniqueReference, T> dictionary_UniqueObject))
            {
                return false;
            }

            if (!dictionary_UniqueObject.TryGetValue(uniqueReference, out T uniqueObject_Temp))
            {
                return false;
            }

            if (uniqueObject_Temp is U)
            {
                uniqueObject = (U)uniqueObject_Temp;
                return true;
            }

            return false;
        }

        public bool TryGetObjects<U>(System.Type type, out List<U> uniqueObjects, bool exactMatch = false) where U : T
        {
            uniqueObjects = null;

            if (type == null)
            {
                return false;
            }

            if (!typeof(U).IsAssignableFrom(type))
            {
                return false;
            }

            TypeReference typeReference = Create.TypeReference(type);
            if (typeReference == null)
            {
                return false;
            }

            if (exactMatch)
            {
                if (!dictionary.TryGetValue(typeReference, out Dictionary<UniqueReference, T> dictionary_UniqueObject) || dictionary_UniqueObject == null || dictionary_UniqueObject.Count == 0)
                {
                    return false;
                }

                uniqueObjects = dictionary_UniqueObject.Values.Cast<U>().ToList();

                return true;
            }

            uniqueObjects = new List<U>();
            foreach (KeyValuePair<TypeReference, Dictionary<UniqueReference, T>> keyValuePair in dictionary)
            {
                System.Type type_TypeReference = keyValuePair.Key?.Type();
                if (type_TypeReference == null)
                {
                    continue;
                }

                if (!type.IsAssignableFrom(type_TypeReference))
                {
                    continue;
                }
            }

            return uniqueObjects != null && uniqueObjects.Count != 0;
        }

        public bool TryGetObjects<U>(IEnumerable<UniqueReference> uniqueReferences, out List<U> uniqueObjects) where U : T
        {
            uniqueObjects = null;

            if(uniqueReferences == null)
            {
                return false;
            }

            bool result = false;

            uniqueObjects = new List<U>();
            foreach(UniqueReference uniqueReference in uniqueReferences)
            {
                if(TryGetObject(uniqueReference, out U uniqueObject))
                {
                    uniqueObjects.Add(uniqueObject);
                    result = true;
                }
            }

            return result;
        }

        public bool TryGetObjects<U>(out List<U> uniqueObjects, bool exactMath = false) where U : T
        {
            return TryGetObjects(typeof(U), out uniqueObjects, exactMath);
        }

        public List<X> GetObjects<X>(Func<X, bool> func = null) where X : T
        {
            if(dictionary == null)
            {
                return null;
            }

            Type type = typeof(T);

            List<X> result = new List<X>();
            foreach (KeyValuePair<TypeReference, Dictionary<UniqueReference, T>> keyValuePair in dictionary)
            {
                Type type_Temp = keyValuePair.Key;

                if(!type_Temp.IsAssignableFrom(type))
                {
                    continue;
                }

                foreach(T t in keyValuePair.Value.Values)
                {
                    if(!(t is X))
                    {
                        continue;
                    }

                    X x = (X)t;

                    if (func != null && !func.Invoke(x))
                    {
                        continue;
                    }

                    result.Add(x);
                }
            }

            return result;
        }

        public bool Update(T uniqueObject)
        {
            if(uniqueObject == null)
            {
                return false;
            }

            if(!IsValid(uniqueObject))
            {
                return false;
            }

            UniqueReference uniqueReference = new UniqueReference(uniqueObject);
            if(uniqueReference == null)
            {
                return false;
            }

            TypeReference typeReference = uniqueReference.TypeReference;
            if(typeReference == null)
            {
                return false;
            }

            if(!dictionary.TryGetValue(typeReference, out Dictionary<UniqueReference, T> dictionary_UniqueObject))
            {
                dictionary_UniqueObject = new Dictionary<UniqueReference, T>();
                dictionary[typeReference] = dictionary_UniqueObject;
            }

            dictionary_UniqueObject[uniqueReference] = uniqueObject;
            return true;
        }

        public HashSet<UniqueReference> Update<U>(IEnumerable<U> uniqueObjects) where U : T
        {
            if(uniqueObjects == null)
            {
                return null;
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();
            foreach(U uniqueObject in uniqueObjects)
            {
                if(Update(uniqueObject))
                {
                    result.Add(new UniqueReference(uniqueObject));
                }
            }

            return result;
        }
    }
}
