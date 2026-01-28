namespace DiGi.Core.Interfaces
{
    public interface IDeterminateWorker : IWorker
    {
        double Maximum { get; set; }

        void Report(double value, string text);

        void Report(double value);
    }
}