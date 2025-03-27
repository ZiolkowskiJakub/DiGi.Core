using DiGi.Core.IO.DelimitedData.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Interfaces
{
    public interface IDelimitedDataReader
    {
        char Separator { get; }

        DelimitedDataRow ReadRow();

        List<DelimitedDataRow> ReadRows();
    }
}
