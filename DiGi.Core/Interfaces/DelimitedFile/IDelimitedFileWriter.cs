using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface IDelimitedFileWriter
    {
        char Separator { get; }

        void Write(DelimitedFileRow DelimitedFileRow);

        void Write(IEnumerable<DelimitedFileRow> DelimitedFileRows);
    }
}
