using DiGi.Core.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiGi.Core.Interfaces
{
    public interface IDelimitedFileReader
    {
        char Separator { get; }

        bool Read(DelimitedFileRow DelimitedFileRow);

        List<DelimitedFileRow> Read();
    }
}
