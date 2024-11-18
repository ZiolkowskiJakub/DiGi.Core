using System;

namespace DiGi.Core.IO.File.Interfaces
{
    internal interface IFile : IDisposable
    { 
        bool Open();

        bool Open(string path);

        bool Save();

        bool SaveAs(string path);
    }

    internal interface IFile<T> : IFile
    {
        T Value { get; set; }
    }
}
