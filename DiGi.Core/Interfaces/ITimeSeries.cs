using System;
 
namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that contains time-series data.</summary>
    public interface ITimeSeries : ISerializableObject
    {
        /// <summary>Retrieves the date-time stamps associated with the time series.</summary>
        /// <returns>An array of DateTimes, or null if none exist.</returns>
        DateTime[]? GetDateTimes();
    }
}