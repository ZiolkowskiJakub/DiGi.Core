using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface IDelimitedFileReader
    {
        char Separator { get; }

        bool Read(DelimitedFileRow DelimitedFileRow);

        List<DelimitedFileRow> Read();
    }
}
