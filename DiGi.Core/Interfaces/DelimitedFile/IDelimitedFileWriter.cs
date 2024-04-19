using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiGi.Core.Interfaces
{
    public interface IDelimitedFileWriter
    {
        char Separator { get; }

        void Write(DelimitedFileRow DelimitedFileRow);

        void Write(IEnumerable<DelimitedFileRow> DelimitedFileRows);
    }
}
