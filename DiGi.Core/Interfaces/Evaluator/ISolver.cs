namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an evaluator that solves a problem or calculates a result.</summary>
    public interface ISolver : IEvaluator
    {
        /// <summary>Executes the solving operation.</summary>
        /// <returns>True if the solver successfully found a solution, false otherwise.</returns>
        bool Solve();
    }
}