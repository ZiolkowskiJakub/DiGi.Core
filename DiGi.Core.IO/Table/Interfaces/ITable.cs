using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface ITable : ITableObject
    {

    }

    public interface ITable<UColumn, URow> : ITable, IEnumerable<URow> where UColumn : IColumn where URow : IRow<URow>
    {
        IEnumerable<UColumn> Columns { get; }

        IEnumerable<URow> Rows { get; }

        UColumn? AddColumn(UColumn? column);

        URow? AddRow(IEnumerable<object?>? values);
    }
}