using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    /// <summary>Defines the contract for a row in a table.</summary>
    public interface IRow : ITableObject
    {
        /// <summary>Gets the index of the row.</summary>
        int Index { get; }

        /// <summary>Gets the set of indexes associated with this row.</summary>
        HashSet<int> Indexes { get; }

        /// <summary>Gets or sets the value at the specified index.</summary>
        /// <param name="index">The index of the value.</param>
        object? this[int index] { get; set; }

        /// <summary>Removes the value at the specified index.</summary>
        /// <param name="index">The index of the value to remove.</param>
        /// <returns>True if the value was removed, false otherwise.</returns>
        bool RemoveValue(int index);

        /// <summary>Tries to get the value at the specified index as a specific type.</summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="index">The index of the value.</param>
        /// <param name="value">The retrieved value, or default if not found or wrong type.</param>
        /// <returns>True if the value was successfully retrieved, false otherwise.</returns>
        bool TryGetValue<T>(int index, out T? value);

        /// <summary>Gets all values in the row as an array.</summary>
        /// <returns>An array containing all values of the row.</returns>
        object?[] GetValues();
    }

    /// <summary>Defines a generic contract for a row that supports cloning.</summary>
    public interface IRow<out TRow> : IRow, ICloneableObject<TRow> where TRow : IRow<TRow>
    {
    }
}