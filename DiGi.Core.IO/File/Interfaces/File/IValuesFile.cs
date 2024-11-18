using System.Collections.Generic;

namespace DiGi.Core.IO.File.Interfaces
{
    internal interface IValuesFile : IFile
    { 

    }

    internal interface IValuesFile<T> : IValuesFile
    {
        IEnumerable<T> Values { get; set; }
    }
}
