using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.ComponentModel;
using System.IO.Compression;
using System.IO;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Linq;
using System.Collections.Generic;
using DiGi.Core.IO.DelimitedData.Interfaces.File;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.Interfaces;

namespace DiGi.Core.IO.File.Classes
{
    public class File<T> : SerializableObject, IFile<T> where T : ISerializableObject
    {
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("MetadataStorage"), Description("MetadataStorage")]
        private MetadataStorage metadataStorage = new MetadataStorage();

        [JsonInclude, JsonPropertyName("Value"), Description("Value")]
        public T Value { get; set; }

        public File(string path)
            : base()
        {
            metadataStorage.SetMetadata(new FileMetadata(GetType(), path));
        }

        public File(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public File(File<T> file)
            : base()
        {
            if (file != null)
            {
                metadataStorage = metadataStorage.Clone<MetadataStorage>();
                Value = file.Value == null ? default : file.Value.Clone<T>();
            }
        }

        public TMetadata GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            return metadataStorage.GetMetadata<TMetadata>();
        }

        public void SetMetadata(IMetadata metadata)
        {
            if(metadata == null || metadata is FileMetadata)
            {
                return;
            }

            metadataStorage.SetMetadata(metadata);
        }

        public string Path
        {
            get
            {
                return GetMetadata<FileMetadata>()?.Path;
            }

            set
            {
                FileMetadata fileMetadata = GetMetadata<FileMetadata>();
                if(fileMetadata == null)
                {
                    fileMetadata = new FileMetadata(GetType());
                }

                fileMetadata.Path = value;
                metadataStorage.SetMetadata(fileMetadata);
            }
        }

        public bool Open()
        {
            string path = Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!System.IO.File.Exists(path))
            {
                return false;
            }

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                ZipArchiveEntry zipArchiveEntry = null;

                zipArchiveEntry = zipArchive.GetEntry("MetadataStorage");
                if (zipArchiveEntry != null)
                {
                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        metadataStorage = Convert.ToDiGi<MetadataStorage>(streamReader.ReadToEnd())?.FirstOrDefault();
                        Path = path;
                    }
                }

                zipArchiveEntry = zipArchive.GetEntry("Value");
                if (zipArchiveEntry != null)
                {
                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        List<T> ts = Convert.ToDiGi<T>(streamReader.ReadToEnd());
                        if (ts != null && ts.Count != 0)
                        {
                            Value = ts[0];
                        }
                    }
                }
            }

            return true;
        }

        public bool Open(string path)
        {
            Path = path;

            return Open();
        }

        public bool Save()
        {
            FileMetadata fileMetadata = GetMetadata<FileMetadata>();
            
            if (fileMetadata == null)
            {
                fileMetadata = new FileMetadata(GetType());
            }

            string path = fileMetadata.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            fileMetadata.Modified = DateTime.Now;

            metadataStorage.SetMetadata(fileMetadata);

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    string json = null;

                    json = Convert.ToString((ISerializableObject)metadataStorage);
                    if (json != null)
                    {
                        ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("MetadataStorage");
                        using (Stream stream = zipArchiveEntry.Open())
                        {
                            using (StreamWriter streamWriter = new StreamWriter(stream))
                            {
                                streamWriter.Write(json);
                            }
                        }
                    }

                    json = Convert.ToString(Value);
                    if (json != null)
                    {
                        ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("Value");

                        using (Stream stream = zipArchiveEntry.Open())
                        {
                            using (StreamWriter streamWriter = new StreamWriter(stream))
                            {
                                streamWriter.Write(json);
                            }
                        }
                    }
                }

                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    memoryStream.CopyTo(fileStream);
                }
            }

            return true;

        }

        public bool SaveAs(string path)
        {
            Path = path;
            return Save();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // dispose managed state (managed objects).
                }

                // free unmanaged resources (unmanaged objects) and override a finalizer below.
                // set large fields to null.

                metadataStorage = null;
                Value = default;

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }

    public class File : File<SerializableObjectCollection>
    {
        public File(string path)
            : base(path)
        {

        }

        public File(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public File(File file)
            : base(file)
        {

        }

        public bool Remove(ISerializableObject serializableObject)
        {
            if (Value == null)
            {
                return false;
            }

            return Value.Remove(serializableObject);
        }

        public void Add(ISerializableObject serializableObject)
        {
            if (Value == null)
            {
                Value = new SerializableObjectCollection();
            }

            Value.Add(serializableObject);
        }

        public void AddRange<T>(IEnumerable<T> values) where T : ISerializableObject
        {
            if (values == null)
            {
                return;
            }

            if (Value == null)
            {
                Value = new SerializableObjectCollection();
            }

            foreach (T value in values)
            {
                Value.Add(value);
            }
        }

        public void RemoveAt(int index)
        {
            if (Value == null)
            {
                return;
            }

            Value.RemoveAt(index);
        }

        public void Clear()
        {
            Value?.Clear();
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return Value == null ? 0 : Value.Count;
            }
        }

    }
}
