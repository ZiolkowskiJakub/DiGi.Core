using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Table.Interfaces
{
    public interface IExtendedColumn : IColumn, IDescribableObject
    {
        string? Category { get; }
    }
}