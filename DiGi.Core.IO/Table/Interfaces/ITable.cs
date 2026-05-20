using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface ITable : ITableObject
    {

    }

    public interface ITable<UColumn, URow> : ITable, IEnumerable<URow> where UColumn : IColumn where URow : IRow<URow>
    {

    }
}