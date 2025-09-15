namespace DiGi.Core.Interfaces
{
    public interface IValidator : IEvaluator
    {

    }

    public interface IValidator<T> : IValidator
    {
        bool Validate(T t);
    }

}
