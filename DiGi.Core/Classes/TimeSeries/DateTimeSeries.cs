using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class DateTimeSeries : SerializableObject, ITimeSeries
    {
        [JsonInclude, JsonPropertyName("Range")]
        private DateTimeRange range;

        [JsonInclude, JsonPropertyName("Step")]
        private long step;

        public DateTimeSeries(DateTime dateTime_1, DateTime dateTime_2, long step)
        {
            range = new DateTimeRange(dateTime_1, dateTime_2);
            this.step = step;
        }

        public DateTimeSeries(DateTime dateTime)
        {
            range = new DateTimeRange(dateTime, dateTime);
            step = -1;
        }

        public DateTimeSeries(DateTimeRange range, long step)
            : base()
        {
            this.range = Query.Clone(range);
            this.step = step;
        }

        public DateTimeSeries(DateTimeSeries dateTimeSeries)
            : base(dateTimeSeries)
        {
            if(dateTimeSeries != null)
            {
                range = Query.Clone(dateTimeSeries.range);
                step = dateTimeSeries.step;
            }
        }

        public DateTimeSeries(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        [JsonIgnore]
        public DateTimeRange Range
        {
            get
            {
                return Query.Clone(range);
            }
        }

        [JsonIgnore]
        public long Step
        {
            get
            {
                return step;
            }
        }

        public DateTime[] GetDateTimes()
        {
            if(range == null)
            {
                return null;
            }

            if(range.Min == range.Max)
            {
                return [range.Min];
            }

            if(step <= 0)
            {
                return [range.Min, range.Max];
            }

            List<DateTime> dateTimes = new List<DateTime>() { range.Min };
            int index = dateTimes.Count - 1;

            while (dateTimes[index] < range.Max)
            {
                dateTimes.Add(dateTimes[index].AddTicks(step));
                index++;
            }

            return dateTimes.ToArray();
        }
    }
}
