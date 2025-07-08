using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class DateTimeCollection : SerializableObject, ITimeSeries, ICollection<DateTime>
    {
        [JsonInclude, JsonPropertyName("DateTimes")]
        private List<DateTime> dateTimes = new List<DateTime>();

        public DateTimeCollection() 
            :base()
        {

        }

        public DateTimeCollection(IEnumerable<DateTime> dateTimes)
            : base()
        {

            if(dateTimes != null)
            {
                this.dateTimes = new List<DateTime>(dateTimes);
            }
        }

        public DateTimeCollection(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DateTimeCollection(DateTimeCollection dateTimeCollection)
            : base(dateTimeCollection)
        {
            if(dateTimeCollection != null)
            {
                dateTimes = new List<DateTime>(dateTimeCollection.dateTimes);
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

        public static implicit operator DateTime[](DateTimeCollection dateTimeCollection)
        {
            if (dateTimeCollection == null)
            {
                return null;
            }

            return dateTimeCollection.dateTimes?.ToArray();
        }

        public static implicit operator DateTimeCollection(List<DateTime> dateTimes)
        {
            if (dateTimes == null)
            {
                return null;
            }

            return new DateTimeCollection(dateTimes);
        }

        public static implicit operator DateTimeCollection(DateTime[] dateTimes)
        {
            if (dateTimes == null)
            {
                return null;
            }

            return new DateTimeCollection(dateTimes);
        }

        public static implicit operator DateTimeCollection(DateTime dateTime)
        {
            return new DateTimeCollection([dateTime]);
        }

        public static implicit operator List<DateTime>(DateTimeCollection dateTimeCollection)
        {
            if (dateTimeCollection == null)
            {
                return null;
            }

            return new List<DateTime>(dateTimeCollection.dateTimes);
        }

        public void Add(DateTime item)
        {
            dateTimes.Add(item);
        }

        public void Clear()
        {
            dateTimes.Clear();
        }

        public bool Contains(DateTime item)
        {
            return dateTimes.Contains(item);
        }

        public void CopyTo(DateTime[] array, int arrayIndex)
        {
            dateTimes.CopyTo(array, arrayIndex);
        }

        public DateTime[] GetDateTimes()
        {
            return dateTimes?.ToArray();
        }

        public IEnumerator<DateTime> GetEnumerator()
        {
            return dateTimes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public bool Remove(DateTime item)
        {
            return dateTimes.Remove(item);
        }
    }
}
