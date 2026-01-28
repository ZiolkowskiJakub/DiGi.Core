using System.Collections.Generic;

namespace DiGi.Core.Interfaces
{
    public interface IOneToManySolver<TInput, TOutput> : ISolver
    {
        TInput? Input { set; }

        List<TOutput>? Outputs { get; }
    }
}