using DiGi.Core.Interfaces;
using DiGi.Core.IO.File.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    public class ValuesFile<TSerializableObject> : File, IValuesFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("Values")]
        private List<TSerializableObject?>? values;

        public ValuesFile(string? path)
            : base(path)
        {

        }

        public ValuesFile(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ValuesFile(ValuesFile<TSerializableObject>? valuesFile)
            : base(valuesFile)
        {
            if (valuesFile != null)
            {
                if (valuesFile.values != null)
                {
                    values = [];
                    foreach (TSerializableObject? serializableObject in valuesFile.values)
                    {
                        if (serializableObject is null)
                        {
                            values.Add(default);
                            continue;
                        }
                        else
                        {
                            values.Add(serializableObject.Clone<TSerializableObject>());
                        }
                    }
                }
            }
        }

        [JsonIgnore]
        public IEnumerable<TSerializableObject?>? Values
        {
            get
            {
                return values;
            }

            set
            {
                this.values = value == null ? null : [.. value];
            }
        }

        public override bool Open()
        {
            bool result = base.Open();
            if (!result)
            {
                return false;
            }

            string? path = Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!System.IO.File.Exists(path))
            {
                return false;
            }

            values = [];
            using ZipArchive zipArchive = ZipFile.OpenRead(path);

            ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.Values);
            if (zipArchiveEntry != null)
            {
                using StreamReader streamReader = new(zipArchiveEntry.Open());

                JsonNode? jsonNode = JsonNode.Parse(streamReader.ReadToEnd());
                if (jsonNode != null)
                {
                    if (jsonNode is JsonArray jsonArray)
                    {
                        values = [];
                        foreach (JsonObject? jsonObject in jsonArray.Cast<JsonObject?>())
                        {
                            values.Add(Core.Create.SerializableObject<TSerializableObject>(jsonObject));
                        }
                    }
                }
            }

            return true;
        }

        public override bool Save()
        {
            bool result = base.Save();
            if (!result)
            {
                return false;
            }

            string? path = Path;

            using (ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update))
            {
                ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.Values);
                zipArchiveEntry?.Delete();

                if (values != null)
                {
                    JsonNode? jsonNode = Core.Create.JsonNode(values);
                    if (jsonNode != null)
                    {
                        zipArchiveEntry = zipArchive.CreateEntry(Constans.EntryName.Values);

                        using Stream stream = zipArchiveEntry.Open();
                        using StreamWriter streamWriter = new(stream);

                        streamWriter.Write(jsonNode.ToString());
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

                //Values = null;

                disposed = true;
            }
        }
    }

    public class ValuesFile : ValuesFile<ISerializableObject>
    {
        public ValuesFile(string? path)
            : base(path)
        {

        }

        public ValuesFile(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ValuesFile(ValuesFile? valuesFile)
            : base(valuesFile)
        {

        }
    }
}
