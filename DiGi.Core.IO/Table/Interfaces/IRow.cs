using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface IRow : ITableObject
    {
        int Index { get; }

        HashSet<int> Indexes { get; }

        object? this[int index] { get; set; }

        bool RemoveValue(int index);

        bool TryGetValue<T>(int index, out T? value);

        object?[] GetValues();
    }

    public interface IRow<out TRow> : IRow, ICloneableObject<TRow> where TRow : IRow<TRow>
    {
    }
}