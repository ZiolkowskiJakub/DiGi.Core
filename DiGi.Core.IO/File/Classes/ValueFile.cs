using DiGi.Core.Interfaces;
using System.IO.Compression;
using System.IO;
using System.Text.Json.Nodes;
using DiGi.Core.IO.File.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    public class ValueFile<TSerializableObject> : File, IValueFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("Value")]
        private TSerializableObject value;

        public ValueFile(string path)
            : base(path)
        {

        }

        public ValueFile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ValueFile(ValueFile<TSerializableObject> valueFile)
            : base(valueFile)
        {
            if(valueFile != null)
            {
                value = valueFile.value == null ? default : valueFile.value.Clone<TSerializableObject>();
            }
        }

        [JsonIgnore]
        public TSerializableObject Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public override bool Open()
        {
            bool result = base.Open();
            if(!result)
            {
                return false;
            }

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

                zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.Value);
                if (zipArchiveEntry != null)
                {
                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        List<TSerializableObject> ts = Convert.ToDiGi<TSerializableObject>(streamReader.ReadToEnd());
                        if (ts != null && ts.Count != 0)
                        {
                            Value = ts[0];
                        }
                    }
                }
            }

            return true;
        }

        public override bool Save()
        {
            bool result = base.Save();
            if(!result)
            {
                return false;
            }

            string path = Path;

            using (ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.Value);
                if (zipArchiveEntry != null)
                {
                    zipArchiveEntry.Delete();
                }

                string json = Convert.ToSystem_String(Value);
                if(!string.IsNullOrWhiteSpace(json))
                {
                    zipArchiveEntry = zipArchive.CreateEntry(Constans.EntryName.Value);

                    using (Stream stream = zipArchiveEntry.Open())
                    {
                        using (StreamWriter streamWriter = new StreamWriter(stream))
                        {
                            streamWriter.Write(json);
                        }
                    }
                }
            }

            return result;
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

                Value = default;

                disposed = true;
            }
        }
    }

    public class ValueFile : ValueFile<ISerializableObject>
    {
        public ValueFile(string path)
            :base(path) 
        { 

        }

        public ValueFile(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ValueFile(ValueFile valueFile)
            :base(valueFile)
        {

        }
    }
}
