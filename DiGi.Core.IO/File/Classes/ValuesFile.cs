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
    /// <summary>
    /// Represents a file that stores a collection of values.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object stored in the file.</typeparam>
    public class ValuesFile<TSerializableObject> : File, IValuesFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("Values")]
        private List<TSerializableObject?>? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the values file.</param>
        public ValuesFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ValuesFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class from an existing generic values file.
        /// </summary>
        /// <param name="valuesFile">The existing generic values file to initialize from.</param>
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

        /// <summary>
        /// Gets or sets the collection of values stored within the file.
        /// </summary>
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

        /// <summary>
        /// Opens the file and loads its content into memory.
        /// </summary>
        /// <returns>True if the open operation was successful; otherwise, false.</returns>
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

            ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.Values);
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
                            values.Add(DiGi.Core.Create.SerializableObject<TSerializableObject>(jsonObject));
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Saves the current state of the object to the file.
        /// </summary>
        /// <returns>True if the save operation was successful; otherwise, false.</returns>
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
                ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.Values);
                zipArchiveEntry?.Delete();

                if (values != null)
                {
                    JsonNode? jsonNode = DiGi.Core.Create.JsonNode(values);
                    if (jsonNode != null)
                    {
                        zipArchiveEntry = zipArchive.CreateEntry(IO.Constants.EntryName.Values);

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

    /// <summary>
    /// Represents a file that stores a collection of values.
    /// </summary>
    public class ValuesFile : ValuesFile<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the values file.</param>
        public ValuesFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ValuesFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValuesFile"/> class from an existing non-generic values file.
        /// </summary>
        /// <param name="valuesFile">The existing non-generic values file to initialize from.</param>
        public ValuesFile(ValuesFile? valuesFile)
            : base(valuesFile)
        {
        }
    }
}