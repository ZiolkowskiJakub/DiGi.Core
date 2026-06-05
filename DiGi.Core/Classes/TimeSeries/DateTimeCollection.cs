using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a collection of <see cref="DateTime"/> objects.
    /// </summary>
    public class DateTimeCollection : SerializableObject, ITimeSeries, ICollection<DateTime>
    {
        [JsonInclude, JsonPropertyName("DateTimes")]
        private readonly List<DateTime> dateTimes = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeCollection"/> class.
        /// </summary>
        public DateTimeCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeCollection"/> class with the specified collection of DateTimes.
        /// </summary>
        /// <param name="dateTimes">The collection of date times to initialize the collection with.</param>
        public DateTimeCollection(IEnumerable<DateTime>? dateTimes)
            : base()
        {
            if (dateTimes != null)
            {
                this.dateTimes = [.. dateTimes];
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize the collection from.</param>
        public DateTimeCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="dateTimeCollection">The DateTimeCollection to copy from.</param>
        public DateTimeCollection(DateTimeCollection? dateTimeCollection)
            : base(dateTimeCollection)
        {
            if (dateTimeCollection != null)
            {
                dateTimes = [.. dateTimeCollection.dateTimes];
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        public int Count
        {
            get
            {
                return dateTimes.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
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

        /// <summary>
        /// Adds the specified DateTime to the collection.
        /// </summary>
        /// <param name="dateTime">The DateTime to add to the collection.</param>
        public void Add(DateTime dateTime)
        {
            dateTimes.Add(dateTime);
        }

        /// <summary>
        /// Adds the specified nullable DateTime to the collection.
        /// </summary>
        /// <param name="dateTime">The nullable DateTime to add to the collection.</param>
        public void Add(DateTime? dateTime)
        {
            if (dateTime == null || !dateTime.HasValue)
            {
                return;
            }

            dateTimes.Add(dateTime.Value);
        }

        /// <summary>
        /// Removes all elements from the collection.
        /// </summary>
        public void Clear()
        {
            dateTimes.Clear();
        }

        /// <summary>
        /// Determines whether the collection contains a specific nullable DateTime.
        /// </summary>
        /// <param name="dateTime">The nullable DateTime to locate in the collection.</param>
        /// <returns>true if the collection contains the specified nullable DateTime; otherwise, false.</returns>
        public bool Contains(DateTime? dateTime)
        {
            if (dateTime is null || !dateTime.HasValue)
            {
                return false;
            }

            return dateTimes.Contains(dateTime.Value);
        }

        /// <summary>
        /// Determines whether the collection contains a specific DateTime.
        /// </summary>
        /// <param name="dateTime">The DateTime to locate in the collection.</param>
        /// <returns>true if the collection contains the specified DateTime; otherwise, false.</returns>
        public bool Contains(DateTime dateTime)
        {
            return dateTimes.Contains(dateTime);
        }

        /// <summary>
        /// Copies the elements of the collection to a specified array, starting at the specified index.
        /// </summary>
        /// <param name="array">The destination array to which the elements are copied.</param>
        /// <param name="arrayIndex">The zero-based index in the destination array at which the elements should be copied to.</param>
        public void CopyTo(DateTime[]? array, int arrayIndex)
        {
            if (array is null)
            {
                return;
            }

            dateTimes.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// Generates and returns an array of DateTimes within the series.
        /// </summary>
        /// <returns>An array of DateTime objects containing the series, or null if no date times are available.</returns>
        public DateTime[]? GetDateTimes()
        {
            return dateTimes?.ToArray();
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An IEnumerator&lt;DateTime&gt; that iterates through the collection.</returns>
        public IEnumerator<DateTime> GetEnumerator()
        {
            return dateTimes?.GetEnumerator() ?? Enumerable.Empty<DateTime>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurrence of a specific nullable DateTime from the collection.
        /// </summary>
        /// <param name="dateTime">The nullable DateTime to remove from the collection.</param>
        /// <returns>True if the item was successfully removed; otherwise, false.</returns>
        public bool Remove(DateTime? dateTime)
        {
            if (dateTimes is null || dateTime is null)
            {
                return false;
            }

            return dateTimes.Remove(dateTime.Value);
        }

        /// <summary>
        /// Removes the first occurrence of a specific DateTime from the collection.
        /// </summary>
        /// <param name="dateTime">The DateTime to remove from the collection.</param>
        /// <returns>True if the item was successfully removed; otherwise, false.</returns>
        public bool Remove(DateTime dateTime)
        {
            return dateTimes.Remove(dateTime);
        }
    }
}