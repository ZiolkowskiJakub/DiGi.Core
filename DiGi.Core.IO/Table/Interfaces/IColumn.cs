using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.IO.Table.Interfaces
{
    /// <summary>Defines the contract for a column in a table.</summary>
    public interface IColumn : ITableSerializableObject, INamedObject
    {
        /// <summary>Gets or sets the index of the column.</summary>
        int Index { get; set; }
 
        /// <summary>Gets the data type of the column.</summary>
        public Type? Type { get; }
 
        /// <summary>Tries to get a valid value for this column from the input object.</summary>
        /// <param name="in">The input value to validate or convert.</param>
        /// <param name="out">The validated and potentially converted output value.</param>
        /// <param name="tryConvert">Whether to attempt conversion if the type doesn't match.</param>
        /// <returns>True if a valid value was obtained, false otherwise.</returns>
        bool TryGetValidValue(object? @in, out object? @out, bool tryConvert = true);
    }
}