using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class DateTimeCollection : SerializableObject, ITimeSeries, ICollection<DateTime>
    {
        [JsonInclude, JsonPropertyName("DateTimes")]
        private readonly List<DateTime> dateTimes = [];
        public DateTimeCollection()
            : base()
        {

        }

        public DateTimeCollection(IEnumerable<DateTime>? dateTimes)
            : base()
        {

            if (dateTimes != null)
            {
                this.dateTimes = [.. dateTimes];
            }
        }

        public DateTimeCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public DateTimeCollection(DateTimeCollection? dateTimeCollection)
            : base(dateTimeCollection)
        {
            if (dateTimeCollection != null)
            {
                dateTimes = [.. dateTimeCollection.dateTimes];
            }
        }

        public int Count
        {
            get
            {
                return dateTimes.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public static implicit operator DateTime[]?(DateTimeCollection? dateTimeCollection)
        {
            if (dateTimeCollection == null)
            {
                return null;
            }

            return dateTimeCollection.dateTimes?.ToArray();
        }

        public static implicit operator DateTimeCollection?(List<DateTime>? dateTimes)
        {
            if (dateTimes == null)
            {
                return null;
            }

            return [.. dateTimes];
        }

        public static implicit operator DateTimeCollection?(DateTime[]? dateTimes)
        {
            if (dateTimes == null)
            {
                return null;
            }

            return [.. dateTimes];
        }

        public static implicit operator DateTimeCollection?(DateTime? dateTime)
        {
            if (dateTime == null || !dateTime.HasValue)
            {
                return null;
            }

            return new([dateTime.Value]);
        }

        public static implicit operator List<DateTime>?(DateTimeCollection? dateTimeCollection)
        {
            if (dateTimeCollection == null)
            {
                return null;
            }

            return [.. dateTimeCollection.dateTimes];
        }

        public void Add(DateTime dateTime)
        {
            dateTimes.Add(dateTime);
        }

        public void Add(DateTime? dateTime)
        {
            if (dateTime == null || !dateTime.HasValue)
            {
                return;
            }

            dateTimes.Add(dateTime.Value);
        }

        public void Clear()
        {
            dateTimes.Clear();
        }

        public bool Contains(DateTime? dateTime)
        {
            if (dateTime is null || !dateTime.HasValue)
            {
                return false;
            }

            return dateTimes.Contains(dateTime.Value);
        }

        public bool Contains(DateTime dateTime)
        {
            return dateTimes.Contains(dateTime);
        }

        public void CopyTo(DateTime[]? array, int arrayIndex)
        {
            if (array is null)
            {
                return;
            }

            dateTimes.CopyTo(array, arrayIndex);
        }

        public DateTime[]? GetDateTimes()
        {
            return dateTimes?.ToArray();
        }

        public IEnumerator<DateTime> GetEnumerator()
        {
            return dateTimes?.GetEnumerator() ?? Enumerable.Empty<DateTime>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(DateTime? dateTime)
        {
            if (dateTimes is null || dateTime is null)
            {
                return false;
            }

            return dateTimes.Remove(dateTime.Value);
        }

        public bool Remove(DateTime dateTime)
        {
            return dateTimes.Remove(dateTime);
        }
    }
}
