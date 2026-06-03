using DiGi.Core.IO.DelimitedData.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Interfaces
{
    /// <summary>
    /// Interface for reading delimited data files.
    /// </summary>
    public interface IDelimitedDataReader
    {
        char Separator { get; }

        DelimitedDataRow? ReadRow();

        List<DelimitedDataRow>? ReadRows();
    }
}