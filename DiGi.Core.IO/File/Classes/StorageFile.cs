using DiGi.Core.Interfaces;
using System.IO.Compression;
using System.IO;
using System.Text.Json.Nodes;
using DiGi.Core.IO.File.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using System.Linq;
using System;

namespace DiGi.Core.IO.File.Classes
{
    public class StorageFile<TSerializableObject> : File, IValuesFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private Dictionary<UniqueReference, TSerializableObject> dictionary = null;

        [JsonIgnore]
        private bool disposed = false;
        
        public StorageFile(string path)
            : base(path)
        {

        }

        public StorageFile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public StorageFile(StorageFile<TSerializableObject> storageFile)
            : base(storageFile)
        {
            
            if (storageFile != null)
            {
                Values = storageFile.Values;
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                HashSet<UniqueReference> uniqueReferences = GetUniqueReferences();
                if (uniqueReferences == null)
                {
                    return -1;
                }

                return uniqueReferences.Count;
            }
        }

        [JsonInclude]
        public IEnumerable<TSerializableObject> Values
        {
            get
            {
                return GetValues();
            }

            set
            {
                SetValues(value);
            }
        }

        public UniqueReference AddValue(TSerializableObject serializableObject)
        {
            UniqueReference uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
            if(uniqueReference == null)
            {
                return null;
            }

            if(dictionary == null)
            {
                Open();
            }

            if(dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            dictionary[uniqueReference] = serializableObject;
            return uniqueReference;
        }

        public bool Contains(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            if (dictionary != null && dictionary.ContainsKey(uniqueReference))
            {
                return true;
            }

            return GetValue(uniqueReference) != null;
        }

        public virtual UniqueReference GetUniqueReference(TSerializableObject serializableObject)
        {
            return Core.Create.UniqueReference(serializableObject);
        }

        public HashSet<UniqueReference> GetUniqueReferences()
        {
            if (dictionary == null)
            {
                Open();
            }

            string path = Path;
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                IEnumerable<ZipArchiveEntry> zipArchiveEntries = zipArchive.Entries;

                foreach (ZipArchiveEntry zipArchiveEntry in zipArchiveEntries)
                {
                    if (zipArchiveEntry == null || !zipArchiveEntry.FullName.StartsWith(Constans.EntryName.Values))
                    {
                        continue;
                    }

                    result.Add(Query.Decode(zipArchiveEntry.Name));
                }

            }

            if (dictionary != null)
            {
                foreach (UniqueReference uniqueReference in dictionary.Keys)
                {
                    if (!result.Contains(uniqueReference))
                    {
                        result.Add(uniqueReference);
                    }
                }
            }

            return result;
        }

        public TSerializableObject GetValue(UniqueReference uniqueReference)
        {
            if (!TryGetValue(uniqueReference, out TSerializableObject result))
            {
                return default;
            }

            return result;
        }

        public USerializableObject GetValue<USerializableObject>(UniqueReference uniqueReference) where USerializableObject : TSerializableObject
        {
            if (!TryGetValue(uniqueReference, out USerializableObject result))
            {
                return default;
            }

            return result;
        }

        public T GetValue<T>(int index) where T : TSerializableObject
        {
            TSerializableObject serializableObject = GetValue(index);
            if (serializableObject is T)
            {
                return (T)serializableObject;
            }

            return default;
        }

        public TSerializableObject GetValue(int index)
        {
            if (!TryGetValue(index, out TSerializableObject result))
            {
                return default;
            }

            return result;
        }

        public IEnumerable<USerializableObject> GetValues<USerializableObject>(IEnumerable<UniqueReference> uniqueReferences) where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject> serializableObjects = GetValues(uniqueReferences);
            if (serializableObjects == null)
            {
                return null;
            }

            List<USerializableObject> result = new List<USerializableObject>();
            foreach (TSerializableObject serializableObject in serializableObjects)
            {
                if (serializableObject == null || !(serializableObject is USerializableObject))
                {
                    result.Add(default);
                }
                else
                {
                    result.Add((USerializableObject)serializableObject);
                }
            }

            return result;
        }

        public IEnumerable<TSerializableObject> GetValues(IEnumerable<UniqueReference> uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            if (this.dictionary == null)
            {
                Open();
            }

            if (this.dictionary == null)
            {
                this.dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            HashSet<UniqueReference> uniqueReferences_Pull = new HashSet<UniqueReference>();

            Dictionary<UniqueReference, TSerializableObject> dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference == null)
                {
                    continue;
                }

                if (dictionary.TryGetValue(uniqueReference, out TSerializableObject serializableObject))
                {
                    dictionary[uniqueReference] = serializableObject;
                }
                else
                {
                    uniqueReferences_Pull.Add(uniqueReference);
                }
            }

            List<TSerializableObject> serializableObjects = Pull(uniqueReferences_Pull);
            if (serializableObjects != null)
            {
                foreach (TSerializableObject serializableObject in serializableObjects)
                {
                    UniqueReference uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                    if (uniqueReference == null)
                    {
                        continue;
                    }

                    dictionary[uniqueReference] = serializableObject;
                    this.dictionary[uniqueReference] = serializableObject;
                }
            }

            List<TSerializableObject> result = new List<TSerializableObject>();
            foreach (UniqueReference uniqueReference in uniqueReferences)
            {
                if (uniqueReference != null && dictionary.TryGetValue(uniqueReference, out TSerializableObject serializableObject))
                {
                    result.Add(serializableObject);
                }
                else
                {
                    result.Add(default);
                }
            }

            return result;
        }

        public IEnumerable<TSerializableObject> GetValues(IEnumerable<int> indexes)
        {
            if (indexes == null)
            {
                return null;
            }

            HashSet<UniqueReference> uniqueReferences = GetUniqueReferences();
            if (uniqueReferences == null)
            {
                return null;
            }

            int count = uniqueReferences.Count;

            Dictionary<int, UniqueReference> dictionary_UniqueReference = new Dictionary<int, UniqueReference>();
            foreach (int index in indexes)
            {
                if (index < 0 || index >= count)
                {
                    continue;
                }

                dictionary_UniqueReference[index] = uniqueReferences.ElementAt(index);
            }

            IEnumerable<TSerializableObject> serializableObjects = GetValues(dictionary_UniqueReference.Values);

            Dictionary<UniqueReference, TSerializableObject> dictionary_SerializableObject = new Dictionary<UniqueReference, TSerializableObject>();
            foreach (TSerializableObject serializableObject in serializableObjects)
            {
                if (serializableObject == null)
                {
                    continue;
                }

                //dictionary_SerializableObject[Create.UniqueReference(serializableObject)] = serializableObject;

                UniqueReference uniqueReference = GetUniqueReference(serializableObject);
                if (uniqueReference == null)
                {
                    continue;
                }

                dictionary_SerializableObject[uniqueReference] = serializableObject;
            }

            List<TSerializableObject> result = new List<TSerializableObject>();
            foreach (int index in indexes)
            {
                if (!dictionary_UniqueReference.TryGetValue(index, out UniqueReference uniqueReference) || uniqueReference == null)
                {
                    result.Add(default);
                    continue;
                }

                if (!dictionary_SerializableObject.TryGetValue(uniqueReference, out TSerializableObject serializableObject))
                {
                    serializableObject = default;
                }

                result.Add(serializableObject);
            }

            return result;
        }

        public IEnumerable<USerializableObject> GetValues<USerializableObject>(IEnumerable<int> indexes) where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject> serializableObjects = GetValues(indexes);
            if (serializableObjects == null)
            {
                return null;
            }

            List<USerializableObject> result = new List<USerializableObject>();
            foreach (TSerializableObject serializableObject in serializableObjects)
            {
                if (serializableObject is USerializableObject)
                {
                    result.Add((USerializableObject)serializableObject);
                }
                else
                {
                    result.Add(default);
                }
            }

            return result;
        }

        public IEnumerable<USerializableObject> GetValues<USerializableObject>() where USerializableObject : TSerializableObject
        {
            IEnumerable<TSerializableObject> values = GetValues();
            if (values == null)
            {
                return null;
            }

            List<USerializableObject> result = new List<USerializableObject>();

            foreach (TSerializableObject value in values)
            {
                if (value is USerializableObject)
                {
                    result.Add((USerializableObject)value);
                }
            }

            return result;
        }

        public override bool Open()
        {
            bool result = base.Open();
            if (!result)
            {
                return result;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            return result;
        }

        public HashSet<UniqueReference> Remove(IEnumerable<UniqueReference> uniqueReferences)
        {
            if (uniqueReferences == null)
            {
                return null;
            }

            if (this.dictionary == null)
            {
                Open();
            }

            HashSet<UniqueReference> uniqueReferences_Temp = new HashSet<UniqueReference>(uniqueReferences);

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();

            if (dictionary != null)
            {
                for (int i = uniqueReferences_Temp.Count - 1; i >= 0; i--)
                {
                    UniqueReference uniqueReference = uniqueReferences_Temp.ElementAt(0);

                    if (dictionary.ContainsKey(uniqueReference))
                    {
                        uniqueReferences_Temp.Remove(uniqueReference);
                        dictionary[uniqueReference] = default;
                        result.Add(uniqueReference);
                    }
                }
            }

            if (uniqueReferences_Temp.Count == 0)
            {
                return result;
            }

            using (ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update))
            {
                for (int i = uniqueReferences_Temp.Count - 1; i >= 0; i--)
                {
                    UniqueReference uniqueReference = uniqueReferences_Temp.ElementAt(0);

                    string entryName = System.IO.Path.Combine(Constans.EntryName.Values, Query.Encode(uniqueReference));

                    ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                    if (zipArchiveEntry == null)
                    {
                        continue;
                    }

                    zipArchiveEntry.Delete();
                    uniqueReferences_Temp.Remove(uniqueReference);
                    result.Add(uniqueReference);
                }
            }

            return result;
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            if (this.dictionary == null)
            {
                Open();
            }

            if (dictionary != null && dictionary.ContainsKey(uniqueReference))
            {
                dictionary[uniqueReference] = default;
                return true;
            }

            using (ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update))
            {
                string entryName = System.IO.Path.Combine(Constans.EntryName.Values, Query.Encode(uniqueReference));

                ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                if (zipArchiveEntry == null)
                {
                    return false;
                }

                zipArchiveEntry.Delete();
                return true;
            }
        }

        public HashSet<UniqueReference> RemoveAll<USerializableObject>(Func<USerializableObject, bool> func) where USerializableObject : TSerializableObject
        {
            return Remove(func);
        }

        public UniqueReference RemoveFirst<USerializableObject>(Func<USerializableObject, bool> func) where USerializableObject : TSerializableObject
        {
            return Remove(func, 1)?.FirstOrDefault();
        }

        public override bool Save()
        {
            bool result = base.Save();
            if (!result)
            {
                return false;
            }

            HashSet<UniqueReference> uniqueReferences = Push();

            return uniqueReferences != null && uniqueReferences.Count > 0;
        }

        public bool TryGetValue(UniqueReference uniqueReference, out TSerializableObject serializableObject)
        {
            serializableObject = default;

            if(uniqueReference == null)
            {
                return false;
            }

            if (uniqueReference == null)
            {
                return default;
            }

            IEnumerable<TSerializableObject> serializableObjects = GetValues(new UniqueReference[] { uniqueReference });
            if (serializableObjects == null || serializableObjects.Count() == 0)
            {
                return default;
            }

            serializableObject = serializableObjects.ElementAt(0);

            return serializableObject != null;
        }

        public bool TryGetValue<USerializableObject>(UniqueReference uniqueReference, out USerializableObject serializableObject) where USerializableObject : TSerializableObject
        {
            serializableObject = default;

            if(!TryGetValue(uniqueReference, out TSerializableObject serializableObject_Temp))
            {
                return false;
            }

            if (serializableObject_Temp is USerializableObject)
            {
                serializableObject = (USerializableObject)serializableObject_Temp;
                return true;
            }

            return false;
        }
        
        public bool TryGetValue(int index, out TSerializableObject serializableObject)
        {
            serializableObject = default;

            if(index < 0)
            {
                return false;
            }

            IEnumerable<TSerializableObject> serializableObjects = GetValues(new int[] { index });
            if (serializableObjects == null || serializableObjects.Count() == 0)
            {
                return default;
            }

            serializableObject = serializableObjects.ElementAt(0);

            return serializableObject != null;
        }

        public bool TryGetValue<USerializableObject>(int index, out USerializableObject serializableObject) where USerializableObject : TSerializableObject
        {
            serializableObject = default;

            if (!TryGetValue(index, out TSerializableObject serializableObject_Temp))
            {
                return false;
            }

            if (serializableObject_Temp is USerializableObject)
            {
                serializableObject = (USerializableObject)serializableObject_Temp;
                return true;
            }

            return false;
        }
        
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (!disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                dictionary = null;
                disposed = true;
            }
        }

        private IEnumerable<TSerializableObject> GetValues()
        {
            List<TSerializableObject> result = Pull();
            if (dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            if (result == null)
            {
                result = new List<TSerializableObject>();
            }

            List<UniqueReference> uniqueReferences = result.ConvertAll(x => GetUniqueReference(x)); //result.ConvertAll(x => Create.UniqueReference(x));

            foreach (KeyValuePair<UniqueReference, TSerializableObject> keyValuePair in dictionary)
            {
                int index = uniqueReferences.FindIndex(x => keyValuePair.Key.Equals(x));
                if (index == -1)
                {
                    result.Add(keyValuePair.Value);
                    continue;
                }

                result[index] = keyValuePair.Value;
            }

            foreach (TSerializableObject serializableObject in result)
            {
                UniqueReference uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                if (uniqueReference == null)
                {
                    continue;
                }

                if (!dictionary.ContainsKey(uniqueReference))
                {
                    dictionary[uniqueReference] = serializableObject;
                }
            }

            return result;
        }

        private List<TSerializableObject> Pull(IEnumerable<UniqueReference> uniqueReferences = null)
        {
            if (dictionary == null)
            {
                Open();
            }

            string path = Path;
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            List<string> jsons = new List<string>();
            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                IEnumerable<ZipArchiveEntry> zipArchiveEntries = null;
                if (uniqueReferences != null)
                {
                    List<ZipArchiveEntry> zipArchiveEntries_Temp = new List<ZipArchiveEntry>();

                    foreach (UniqueReference uniqueReference in uniqueReferences)
                    {
                        if (uniqueReference == null)
                        {
                            continue;
                        }

                        string entryName = System.IO.Path.Combine(Constans.EntryName.Values, Query.Encode(uniqueReference));

                        ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                        if (zipArchiveEntry != null)
                        {
                            zipArchiveEntries_Temp.Add(zipArchiveEntry);
                        }
                    }

                    zipArchiveEntries = zipArchiveEntries_Temp;
                }
                else
                {
                    List<ZipArchiveEntry> zipArchiveEntries_Temp = zipArchive.Entries?.ToList();
                    if (zipArchiveEntries_Temp != null)
                    {
                        for (int i = zipArchiveEntries_Temp.Count - 1; i >= 0; i--)
                        {
                            ZipArchiveEntry ZipArchiveEntry = zipArchiveEntries_Temp[i];

                            if (ZipArchiveEntry == null || !ZipArchiveEntry.FullName.StartsWith(Constans.EntryName.Values))
                            {
                                zipArchiveEntries_Temp.RemoveAt(i);
                            }
                        }
                    }

                    zipArchiveEntries = zipArchiveEntries_Temp;
                }

                if (zipArchiveEntries != null)
                {
                    foreach (ZipArchiveEntry zipArchiveEntry in zipArchiveEntries)
                    {
                        using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                        {
                            jsons.Add(streamReader.ReadToEnd());
                        }
                    }
                }
            }

            List<TSerializableObject> result = new List<TSerializableObject>();
            foreach (string json in jsons)
            {
                List<TSerializableObject> serializableObjects = Convert.ToDiGi<TSerializableObject>(json);
                if (serializableObjects != null && serializableObjects.Count != 0)
                {
                    TSerializableObject serializableObject = serializableObjects[0];
                    if (serializableObject != null)
                    {
                        result.Add(serializableObject);
                    }
                }
            }

            return result;
        }

        private HashSet<UniqueReference> Push(IEnumerable<UniqueReference> uniqueReferences = null)
        {
            if (this.dictionary == null)
            {
                Open();
            }

            string path = Path;
            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return null;
            }

            Dictionary<UniqueReference, string> dictionary = new Dictionary<UniqueReference, string>();
            if (uniqueReferences == null)
            {
                foreach (KeyValuePair<UniqueReference, TSerializableObject> keyValuePair in this.dictionary)
                {
                    dictionary[keyValuePair.Key] = Convert.ToSystem_String(keyValuePair.Value);
                }
            }
            else
            {
                foreach (UniqueReference uniqueReference in uniqueReferences)
                {
                    if (!this.dictionary.TryGetValue(uniqueReference, out TSerializableObject serializableObject))
                    {
                        continue;
                    }

                    dictionary[uniqueReference] = Convert.ToSystem_String(serializableObject);
                }
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();
            using (ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                foreach (KeyValuePair<UniqueReference, string> keyValuePair in dictionary)
                {
                    string entryName = System.IO.Path.Combine(Constans.EntryName.Values, Query.Encode(keyValuePair.Key));

                    ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(entryName);
                    if (zipArchiveEntry != null)
                    {
                        zipArchiveEntry.Delete();
                    }

                    if (string.IsNullOrWhiteSpace(keyValuePair.Value))
                    {
                        continue;
                    }

                    zipArchiveEntry = zipArchive.CreateEntry(entryName);

                    using (Stream stream = zipArchiveEntry.Open())
                    {
                        using (StreamWriter streamWriter = new StreamWriter(stream))
                        {
                            streamWriter.Write(keyValuePair.Value);
                        }
                    }

                    result.Add(keyValuePair.Key);
                }
            }

            return result;
        }
        
        private HashSet<UniqueReference> Remove<USerializableObject>(Func<USerializableObject, bool> func, uint maxCount = uint.MaxValue) where USerializableObject : TSerializableObject
        {
            if (func == null || maxCount < 1)
            {
                return null;
            }

            if (this.dictionary == null)
            {
                Open();
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();

            foreach (KeyValuePair<UniqueReference, TSerializableObject> keyValuePair in this.dictionary)
            {
                USerializableObject uSerializableObject = keyValuePair.Value is USerializableObject ? (USerializableObject)keyValuePair.Value : default;
                if (uSerializableObject == null || !func.Invoke(uSerializableObject))
                {
                    continue;
                }

                dictionary[keyValuePair.Key] = default;

                result.Add(keyValuePair.Key);
                if (result.Count >= maxCount)
                {
                    return result;
                }
            }

            using (ZipArchive zipArchive = ZipFile.Open(Path, ZipArchiveMode.Update))
            {
                List<ZipArchiveEntry> zipArchiveEntries = zipArchive.Entries?.ToList();
                if (zipArchiveEntries == null || zipArchiveEntries.Count == 0)
                {
                    return result;
                }

                for (int i = zipArchiveEntries.Count - 1; i >= 0; i--)
                {
                    ZipArchiveEntry zipArchiveEntry = zipArchiveEntries[i];

                    if (zipArchiveEntry == null || !zipArchiveEntry.FullName.StartsWith(Constans.EntryName.Values))
                    {
                        continue;
                    }

                    USerializableObject serializableObject = default;

                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        string json = streamReader.ReadToEnd();

                        List<USerializableObject> serializableObjects = Convert.ToDiGi<USerializableObject>(json);
                        if (serializableObjects == null || serializableObjects.Count == 0)
                        {
                            continue;
                        }

                        serializableObject = serializableObjects[0];
                    }

                    if (serializableObject == null)
                    {
                        continue;
                    }

                    UniqueReference uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                    if (result.Contains(uniqueReference))
                    {
                        zipArchiveEntry.Delete();
                        continue;
                    }

                    if (!func.Invoke(serializableObject))
                    {
                        if (!dictionary.ContainsKey(uniqueReference))
                        {
                            this.dictionary[uniqueReference] = serializableObject;
                        }

                        continue;
                    }

                    zipArchiveEntry.Delete();

                    result.Add(uniqueReference);

                    if (result.Count >= maxCount)
                    {
                        return result;
                    }

                }
            }

            return result;
        }
        
        private void SetValues(IEnumerable<TSerializableObject> values)
        {
            if(values == null)
            {
                return;
            }

            if(dictionary == null)
            {
                Open();
            }

            if(dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            foreach (TSerializableObject serializableObject in values) 
            { 
                UniqueReference uniqueReference = GetUniqueReference(serializableObject); //Create.UniqueReference(serializableObject);
                if (uniqueReference == null)
                {
                    continue;
                }

                dictionary[uniqueReference] = serializableObject;
            }
        }
    }

    public class StorageFile : StorageFile<ISerializableObject>
    {
        public StorageFile(string path)
            : base(path)
        {

        }

        public StorageFile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public StorageFile(StorageFile storageFile)
            : base(storageFile)
        {

        }
    }
}

