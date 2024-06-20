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

namespace DiGi.Core.File.Classes
{
    public class File<T> : SerializableObject, IDisposable where T : ISerializableObject
    {
        private bool disposed = false;

        [JsonInclude, JsonPropertyName("FileInfo"), Description("FileInfo")]
        private FileInfo fileInfo;

        [JsonInclude, JsonPropertyName("Value"), Description("Value")]
        private T Value { get; set; }

        public File(string path)
            : base()
        {
            FileInfo fileInfo = new FileInfo(path);
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
                fileInfo = file.fileInfo == null ? null : fileInfo.Clone<FileInfo>();
                Value = file.Value == null ? default : file.Value.Clone<T>();
            }
        }

        public bool Open()
        {
            if(string.IsNullOrWhiteSpace(fileInfo?.Path))
            {
                return false;
            }

            string path = fileInfo.Path;

            if(!System.IO.File.Exists(path))
            {
                return false;
            }

            using (ZipArchive zipArchive = ZipFile.OpenRead(path))
            {
                ZipArchiveEntry zipArchiveEntry = null;

                zipArchiveEntry = zipArchive.GetEntry("FileInfo");
                if(zipArchiveEntry != null)
                {
                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        fileInfo = Convert.ToDiGi<FileInfo>(streamReader.ReadToEnd())?.FirstOrDefault();
                        fileInfo.Path = path;
                    }
                }

                zipArchiveEntry = zipArchive.GetEntry("Value");
                if (zipArchiveEntry != null)
                {
                    using (StreamReader streamReader = new StreamReader(zipArchiveEntry.Open()))
                    {
                        List<T> ts = Convert.ToDiGi<T>(streamReader.ReadToEnd());
                        if(ts != null && ts.Count != 0)
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
            FileInfo fileInfo = new FileInfo(path);

            return Open();
        }

        public bool Save()
        {
            if(fileInfo == null)
            {
                return false;
            }

            string path = fileInfo.Path;
            if(string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            fileInfo.Modified = DateTime.Now;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (ZipArchive zipArchive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true))
                {
                    string json = null;

                    json = Convert.ToString(fileInfo);
                    if (json != null)
                    {
                        ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry("FileInfo"); 
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
            fileInfo.Path = path;
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

                fileInfo = null;
                Value = default;

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
    }
}
