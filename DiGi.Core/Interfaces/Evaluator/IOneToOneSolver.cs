namespace DiGi.Core.Interfaces
{
    public interface IOneToOneSolver<TInput, TOutput> : ISolver
    {
        TInput? Input { set; }

        TOutput? Output { get; }
    }
}
