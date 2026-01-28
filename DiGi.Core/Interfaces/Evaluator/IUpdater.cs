namespace DiGi.Core.Interfaces
{
    public interface IUpdater : IEvaluator
    {
        bool Update();
    }

    public interface IUpdater<TValue> : IUpdater
    {
        TValue? Value { set; get; }
    }
}