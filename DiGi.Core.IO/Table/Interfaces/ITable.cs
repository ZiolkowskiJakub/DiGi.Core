using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    /// <summary>Defines the contract for a table object.</summary>
    public interface ITable : ITableObject
    {
    }
 
    /// <summary>Defines the contract for a table with specified column and row types.</summary>
    public interface ITable<UColumn, URow> : ITable, IEnumerable<URow> where UColumn : IColumn where URow : IRow<URow>
    {
        /// <summary>Gets the columns of the table.</summary>
        IEnumerable<UColumn> Columns { get; }
 
        /// <summary>Gets the rows of the table.</summary>
        IEnumerable<URow> Rows { get; }
 
        /// <summary>Adds a column to the table.</summary>
        /// <param name="column">The column to add.</param>
        /// <returns>The added column, or null if it could not be added.</returns>
        UColumn? AddColumn(UColumn? column);
 
        /// <summary>Adds a row to the table using the specified values.</summary>
        /// <param name="values">The values for the new row.</param>
        /// <returns>The added row, or null if it could not be added.</returns>
        URow? AddRow(IEnumerable<object?>? values);
    }
}