namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an evaluator that validates data.</summary>
    public interface IValidator : IEvaluator
    {
    }
 
    /// <summary>Defines a generic contract for an evaluator that validates data of type T.</summary>
    /// <typeparam name="T">The type of the data to validate.</typeparam>
    public interface IValidator<T> : IValidator
    {
        /// <summary>Validates the provided input.</summary>
        /// <param name="t">The input to validate.</param>
        /// <returns>True if the input is valid, false otherwise.</returns>
        bool Validate(T t);
    }
}