using DiGi.Core.IO.DelimitedData.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Interfaces
{
    /// <summary>
    /// Interface for writing delimited data files.
    /// </summary>
    public interface IDelimitedDataWriter
    {
        char Separator { get; }

        void WriteRow(DelimitedDataRow DelimitedDataRow);

        void WriteRows(IEnumerable<DelimitedDataRow> DelimitedDataRows);
    }
}