using DiGi.Core.IO.DelimitedData.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Interfaces
{
    public interface IDelimitedDataWriter
    {
        char Separator { get; }

        void Write(DelimitedDataRow DelimitedDataRow);

        void Write(IEnumerable<DelimitedDataRow> DelimitedDataRows);
    }
}
