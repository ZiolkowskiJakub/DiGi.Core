using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a range of date and time values.
    /// </summary>
    public class DateTimeRange : Range<DateTime>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class with specified start and end dates.
        /// </summary>
        /// <param name="value_1">The first date time value.</param>
        /// <param name="value_2">The second date time value.</param>
        public DateTimeRange(DateTime value_1, DateTime value_2)
            : base(value_1, value_2)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the range from.</param>
        public DateTimeRange(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class by copying an existing range.
        /// </summary>
        /// <param name="dateTimeRange">The date time range to copy from.</param>
        public DateTimeRange(DateTimeRange dateTimeRange)
            : base(dateTimeRange)
        {
        }

        /// <summary>
        /// Gets the duration or length of the date time range.
        /// </summary>
        public override DateTime Length
        {
            get
            {
                return new DateTime((Max - Min).Ticks);
            }
        }
    }
}