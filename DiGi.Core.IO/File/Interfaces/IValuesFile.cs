using System.Collections.Generic;

namespace DiGi.Core.IO.File.Interfaces
{
    public interface IValuesFile : IFile
    {
    }

    public interface IValuesFile<T> : IValuesFile
    {
        IEnumerable<T?>? Values { get; set; }
    }
}