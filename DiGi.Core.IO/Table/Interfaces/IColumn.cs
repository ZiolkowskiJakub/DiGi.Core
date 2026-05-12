using DiGi.Core.Interfaces;
using DiGi.Core.IO.Table.Classes;
using System;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface IColumn : ITableSerializableObject, INamedObject
    {
        int Index { get; set; }

        public Type? Type { get; }

        bool TryGetValidValue(object? @in, out object? @out, bool tryConvert = true);
    }
}