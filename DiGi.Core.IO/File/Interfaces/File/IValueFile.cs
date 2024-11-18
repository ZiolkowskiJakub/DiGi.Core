using System;

namespace DiGi.Core.IO.File.Interfaces
{
    internal interface IValueFile : IFile
    { 

    }

    internal interface IValueFile<T> : IValueFile
    {
        T Value { get; set; }
    }
}
