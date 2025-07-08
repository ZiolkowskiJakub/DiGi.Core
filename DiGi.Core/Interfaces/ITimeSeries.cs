using System;

namespace DiGi.Core.Interfaces
{
    public interface ITimeSeries : ISerializableObject
    {
        DateTime[] GetDateTimes();
    }
}
