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
        public DateTimeRange(DateTime value_1, DateTime value_2)
            : base(value_1, value_2)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class from a JSON object.
        /// </summary>
        public DateTimeRange(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeRange"/> class by copying an existing range.
        /// </summary>
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