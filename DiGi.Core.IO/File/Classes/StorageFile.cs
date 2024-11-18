using DiGi.Core.Interfaces;
using System.IO.Compression;
using System.IO;
using System.Text.Json.Nodes;
using DiGi.Core.IO.File.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using DiGi.Core.Classes;
using System.Linq;

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
            UniqueReference uniqueReference = Create.UniqueReference(serializableObject);
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

        public TSerializableObject GetValue(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return default;
            }

            IEnumerable<TSerializableObject> serializableObjects = GetValues(new UniqueReference[] { uniqueReference });
            if(serializableObjects == null || serializableObjects.Count() == 0)
            {
                return default;
            }

            return serializableObjects.ElementAt(0);
        }

        public USerializableObject GetValue<USerializableObject>(UniqueReference uniqueReference) where USerializableObject : TSerializableObject
        {
            TSerializableObject serializableObject = GetValue(uniqueReference);
            if(serializableObject is USerializableObject)
            {
                return (USerializableObject)serializableObject;
            }

            return default;
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
                    UniqueReference uniqueReference = Create.UniqueReference(serializableObject);
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
            if(dictionary == null)
            {
                dictionary = new Dictionary<UniqueReference, TSerializableObject>();
            }

            if(result == null)
            {
                result = new List<TSerializableObject>();
            }

            List<UniqueReference> uniqueReferences = result.ConvertAll(x => Create.UniqueReference(x));

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

            foreach(TSerializableObject serializableObject in result)
            {
                UniqueReference uniqueReference = Create.UniqueReference(serializableObject);
                if(uniqueReference == null)
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
            if (this.dictionary == null)
            {
                Open();
            }

            string path = Path;
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path))
            {
                return null;
            }

            if (this.dictionary == null)
            {
                this.dictionary = new Dictionary<UniqueReference, TSerializableObject>();
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

                        string entryName = System.IO.Path.Combine(Constans.EntryName.Values, uniqueReference.GetHashCode().ToString());

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
                    zipArchiveEntries = zipArchive.Entries;
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
                    dictionary[keyValuePair.Key] = Convert.ToString(keyValuePair.Value);
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

                    dictionary[uniqueReference] = Convert.ToString(serializableObject);
                }
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();
            using (ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                foreach (KeyValuePair<UniqueReference, string> keyValuePair in dictionary)
                {
                    int hashCode = keyValuePair.Key.GetHashCode();

                    string entryName = System.IO.Path.Combine(Constans.EntryName.Values, hashCode.ToString());

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
                UniqueReference uniqueReference = Create.UniqueReference(serializableObject);
                if(uniqueReference == null)
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

