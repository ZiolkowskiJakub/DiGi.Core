﻿using DiGi.Core.IO.DelimitedData.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.DelimitedData.Interfaces
{
    public interface IDelimitedDataWriter
    {
        char Separator { get; }

        void WriteRow(DelimitedDataRow DelimitedDataRow);

        void WriteRows(IEnumerable<DelimitedDataRow> DelimitedDataRows);
    }
}
