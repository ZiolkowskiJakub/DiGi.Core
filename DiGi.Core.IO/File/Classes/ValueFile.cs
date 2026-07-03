using DiGi.Core.Interfaces;
using DiGi.Core.IO.File.Interfaces;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    /// <summary>
    /// Represents a file that stores a single value.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object stored in the file.</typeparam>
    public class ValueFile<TSerializableObject> : File, IValueFile<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        [JsonIgnore]
        private bool disposed = false;

        [JsonInclude, JsonPropertyName(nameof(Value))]
        private TSerializableObject? value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the value file.</param>
        public ValueFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class from an existing generic value file.
        /// </summary>
        /// <param name="valueFile">The existing generic value file to initialize from.</param>
        public ValueFile(ValueFile<TSerializableObject>? valueFile)
            : base(valueFile)
        {
            if (valueFile != null)
            {
                value = valueFile.value == null ? default : valueFile.value.Clone<TSerializableObject>();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ValueFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the value stored within the file.
        /// </summary>
        [JsonIgnore]
        public TSerializableObject? Value
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

        /// <summary>
        /// Explicitly converts a <see cref="ValueFile{TSerializableObject}"/> to its contained value of type <typeparamref name="TSerializableObject"/>.
        /// </summary>
        /// <param name="valueFile">The value file to convert.</param>
        /// <returns>The contained value, or the default value if the file is null.</returns>
        public static explicit operator TSerializableObject?(ValueFile<TSerializableObject>? valueFile)
        {
            if (valueFile == null)
            {
                return default;
            }

            return valueFile.value;
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

            using ZipArchive zipArchive = ZipFile.OpenRead(path);

            ZipArchiveEntry? zipArchiveEntry = null;

            zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.Value);
            if (zipArchiveEntry != null)
            {
                using StreamReader streamReader = new(zipArchiveEntry.Open());

                List<TSerializableObject>? ts = Convert.ToDiGi<TSerializableObject>(streamReader.ReadToEnd());
                if (ts != null && ts.Count != 0)
                {
                    Value = ts[0];
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
                ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(IO.Constants.EntryName.Value);
                zipArchiveEntry?.Delete();

                string? json = Convert.ToSystem_String(Value);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    zipArchiveEntry = zipArchive.CreateEntry(IO.Constants.EntryName.Value);

                    using Stream stream = zipArchiveEntry.Open();
                    using StreamWriter streamWriter = new(stream);

                    streamWriter.Write(json);
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

                //Value = default;

                disposed = true;
            }
        }
    }

    /// <summary>
    /// Represents a file that stores a single value.
    /// </summary>
    public class ValueFile : ValueFile<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class using the specified file path.
        /// </summary>
        /// <param name="path">The path to the value file.</param>
        public ValueFile(string? path)
            : base(path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class from the provided JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the value file from.</param>
        public ValueFile(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueFile"/> class from an existing non-generic value file.
        /// </summary>
        /// <param name="valueFile">The existing non-generic value file to initialize from.</param>
        public ValueFile(ValueFile? valueFile)
            : base(valueFile)
        {
        }
    }
}