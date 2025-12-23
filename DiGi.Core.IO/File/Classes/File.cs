using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Classes;
using DiGi.Core.IO.File.Interfaces;
using DiGi.Core.IO.Interfaces;
using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.File.Classes
{
    public abstract class File : SerializableObject, IFile
    {
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("MetadataStorage"), Description("MetadataStorage")]
        private MetadataStorage metadataStorage = new();

        public File(string? path)
            : base()
        {
            metadataStorage.SetMetadata(new FileMetadata(GetType(), path));
        }

        public File(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public File(File? file)
            : base()
        {
            if (file != null)
            {
                this.metadataStorage = file.metadataStorage.Clone<MetadataStorage>() ?? new();
            }
        }

        public string? Path
        {
            get
            {
                return GetMetadata<FileMetadata>()?.Path;
            }

            set
            {
                FileMetadata? fileMetadata = GetMetadata<FileMetadata>();
                fileMetadata ??= new FileMetadata(GetType());

                fileMetadata.Path = value;
                metadataStorage.SetMetadata(fileMetadata);
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public TMetadata? GetMetadata<TMetadata>() where TMetadata : IMetadata
        {
            if (metadataStorage == null)
            {
                return default;
            }

            return metadataStorage.GetMetadata<TMetadata>();
        }

        public virtual bool Open()
        {
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

            ZipArchiveEntry zipArchiveEntry;

            zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.MetadataStorage);
            if (zipArchiveEntry != null)
            {
                using StreamReader streamReader = new(zipArchiveEntry.Open());
                MetadataStorage? metadataStorage = Convert.ToDiGi<MetadataStorage>(streamReader.ReadToEnd())?.FirstOrDefault();

                this.metadataStorage = metadataStorage ?? new();
                Path = path;
            }

            return true;
        }

        public bool Open(string? path)
        {
            Path = path;

            return Open();
        }

        public virtual bool Save()
        {
            FileMetadata? fileMetadata = GetMetadata<FileMetadata>();
            fileMetadata ??= new FileMetadata(GetType());

            string? path = fileMetadata.Path;
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            fileMetadata.Modified = DateTime.Now;

            metadataStorage.SetMetadata(fileMetadata);

            string? json = Convert.ToSystem_String((ISerializableObject)metadataStorage);
            if (string.IsNullOrWhiteSpace(json))
            {
                return false;
            }

            using ZipArchive zipArchive = ZipFile.Open(path, ZipArchiveMode.Update);

            ZipArchiveEntry zipArchiveEntry = zipArchive.GetEntry(Constans.EntryName.MetadataStorage);
            zipArchiveEntry?.Delete();

            zipArchiveEntry = zipArchive.CreateEntry(Constans.EntryName.MetadataStorage);

            using Stream stream = zipArchiveEntry.Open();
            using StreamWriter streamWriter = new(stream);
            streamWriter.Write(json);

            return true;
        }

        public bool SaveAs(string? path)
        {
            Path = path;
            return Save();
        }

        public void SetMetadata(IMetadata? metadata)
        {
            if (metadata == null || metadata is FileMetadata)
            {
                return;
            }

            metadataStorage.SetMetadata(metadata);
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

                //metadataStorage = null;

                disposed = true;
            }
        }
    }
}
