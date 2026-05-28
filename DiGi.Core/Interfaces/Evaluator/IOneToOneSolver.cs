namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a solver that takes one input and produces one output.</summary>
    /// <typeparam name="TInput">The type of the input value.</typeparam>
    /// <typeparam name="TOutput">The type of the output value.</typeparam>
    public interface IOneToOneSolver<TInput, TOutput> : ISolver
    {
        /// <summary>Gets or sets the input value for the solver.</summary>
        TInput? Input { set; }
 
        /// <summary>Gets the resulting output value from the solver.</summary>
        TOutput? Output { get; }
    }
}