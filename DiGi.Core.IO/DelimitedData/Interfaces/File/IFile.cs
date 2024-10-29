using System;

namespace DiGi.Core.IO.DelimitedData.Interfaces.File
{
    internal interface IFile<T> : IDisposable
    {
        T Value { get; set; }

        bool Open();

        bool Open(string path);

        bool Save();

        bool SaveAs(string path);
    }
}
