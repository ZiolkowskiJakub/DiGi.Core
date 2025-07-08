using System;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class DateTimeRange : Range<DateTime>
    {
        public DateTimeRange(DateTime value_1, DateTime value_2) 
            : base(value_1, value_2)
        {
        }

        public DateTimeRange(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DateTimeRange(DateTimeRange dateTimeRange)
            : base(dateTimeRange)
        {

        }

        public override DateTime Length
        {
            get
            {
                return new DateTime((Max - Min).Ticks);
            }
        }
    }
}
