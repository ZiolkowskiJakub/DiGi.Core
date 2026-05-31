namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for a worker with determinate progress.</summary>
    public interface IDeterminateWorker : IWorker
    {
        /// <summary>Gets or sets the maximum value for progress reporting.</summary>
        double Maximum { get; set; }

        /// <summary>Reports progress with a numeric value and status text.</summary>
        /// <param name="value">The current progress value.</param>
        /// <param name="text">The status text to report.</param>
        void Report(double value, string text);

        /// <summary>Reports progress with a numeric value.</summary>
        /// <param name="value">The current progress value.</param>
        void Report(double value);
    }
}