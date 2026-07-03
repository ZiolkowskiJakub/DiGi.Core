using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a series of DateTimes generated based on a range and step interval.
    /// </summary>
    public class DateTimeSeries : SerializableObject, ITimeSeries
    {
        [JsonInclude, JsonPropertyName(nameof(Range))]
        private readonly DateTimeRange? range;

        [JsonInclude, JsonPropertyName(nameof(Step))]
        private readonly long step;

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeSeries"/> class with start date, end date, and step.
        /// </summary>
        /// <param name="dateTime_1">The starting date and time of the series.</param>
        /// <param name="dateTime_2">The ending date and time of the series.</param>
        /// <param name="step">The step interval for the series.</param>
        public DateTimeSeries(DateTime dateTime_1, DateTime dateTime_2, long step)
        {
            range = new DateTimeRange(dateTime_1, dateTime_2);
            this.step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeSeries"/> class starting at the specified date.
        /// </summary>
        /// <param name="dateTime">The start date and time for the series.</param>
        public DateTimeSeries(DateTime dateTime)
        {
            range = new DateTimeRange(dateTime, dateTime);
            step = -1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeSeries"/> class with a specified range and step.
        /// </summary>
        /// <param name="range">The date time range for the series.</param>
        /// <param name="step">The step interval between dates in the series.</param>
        public DateTimeSeries(DateTimeRange? range, long step)
            : base()
        {
            this.range = Query.Clone(range);
            this.step = step;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeSeries"/> class by copying another series.
        /// </summary>
        /// <param name="dateTimeSeries">The source <see cref="DateTimeSeries"/> to copy from.</param>
        public DateTimeSeries(DateTimeSeries? dateTimeSeries)
            : base(dateTimeSeries)
        {
            if (dateTimeSeries != null)
            {
                range = Query.Clone(dateTimeSeries.range);
                step = dateTimeSeries.step;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeSeries"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the series.</param>
        public DateTimeSeries(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the date range for the series.
        /// </summary>
        [JsonIgnore]
        public DateTimeRange? Range
        {
            get
            {
                return Query.Clone(range);
            }
        }

        /// <summary>
        /// Gets or sets the step interval for the series.
        /// </summary>
        [JsonIgnore]
        public long Step
        {
            get
            {
                return step;
            }
        }

        /// <summary>
        /// Generates and returns an array of DateTimes within the series.
        /// </summary>
        /// <returns>An array of <see cref="DateTime"/> objects representing the series, or null.</returns>
        public DateTime[]? GetDateTimes()
        {
            if (range is null)
            {
                return null;
            }

            if (range.Min == range.Max)
            {
                return [range.Min];
            }

            if (step <= 0)
            {
                return [range.Min, range.Max];
            }

            List<DateTime> dateTimes = [range.Min];
            int index = dateTimes.Count - 1;

            while (dateTimes[index] < range.Max)
            {
                dateTimes.Add(dateTimes[index].AddTicks(step));
                index++;
            }

            return [.. dateTimes];
        }
    }
}