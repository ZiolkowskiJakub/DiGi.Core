using DiGi.Core.IO.Table.Classes;
using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface ITable : ITableObject, IEnumerable<Row>
    {

    }

    public interface ITable<UColumn> : ITable where UColumn : IColumn
    {

    }
}