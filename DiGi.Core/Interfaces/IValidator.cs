namespace DiGi.Core.Interfaces
{
    public interface IValidator : ICalculator
    {

    }

    public interface IValidator<T> : ICalculator
    {
        bool IsValid(T t);
    }

}
