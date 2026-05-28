using System.Collections.Generic;
 
namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a solver that takes one input and produces multiple outputs.</summary>
    /// <typeparam name="TInput">The type of the input value.</typeparam>
    /// <typeparam name="TOutput">The type of the output values.</typeparam>
    public interface IOneToManySolver<TInput, TOutput> : ISolver
    {
        /// <summary>Gets or sets the input value for the solver.</summary>
        TInput? Input { set; }
 
        /// <summary>Gets the resulting list of output values from the solver.</summary>
        List<TOutput>? Outputs { get; }
    }
}