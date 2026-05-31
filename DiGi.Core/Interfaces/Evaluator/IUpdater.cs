namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an evaluator that updates data.</summary>
    public interface IUpdater : IEvaluator
    {
        /// <summary>Performs the update operation.</summary>
        /// <returns>True if the update was successful, false otherwise.</returns>
        bool Update();
    }

    /// <summary>Defines a generic contract for an updater that handles values of type TValue.</summary>
    /// <typeparam name="TValue">The type of value to be updated.</typeparam>
    public interface IUpdater<TValue> : IUpdater
    {
        /// <summary>Gets or sets the value to be used in the update operation.</summary>
        TValue? Value { set; get; }
    }
}