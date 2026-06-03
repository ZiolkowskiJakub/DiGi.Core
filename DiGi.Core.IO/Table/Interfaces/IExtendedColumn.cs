using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Table.Interfaces
{
    /// <summary>
    /// Defines an extended column in a table with additional metadata such as category and description.
    /// </summary>
    public interface IExtendedColumn : IColumn, IDescribableObject
    {
        /// <summary>
        /// Gets the category of the column.
        /// </summary>
        string? Category { get; }
    }
}