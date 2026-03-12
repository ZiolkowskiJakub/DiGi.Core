using System;

namespace DiGi.Core.IO.File.Interfaces
{
    public interface IFile : IDisposable
    {
        bool Open();

        bool Open(string path);

        bool Save();

        bool SaveAs(string path);
    }

    public interface IFile<T> : IFile
    {
        T Value { get; set; }
    }
}