namespace DiGi.Core.Interfaces
{
    public interface IValue : IObject
    {
    }

    public interface IValue<TValue> : IValue
    {
        XValue? GetValue<XValue>() where XValue : TValue;

        TValue? Value { get; }
    }
}