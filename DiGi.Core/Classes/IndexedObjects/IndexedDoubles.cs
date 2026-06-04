using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a collection of double-precision floating-point values mapped to integer indices.
    /// </summary>
    public class IndexedDoubles : IndexedObjects<double>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class.
        /// </summary>
        public IndexedDoubles()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class from a JSON object.
        /// </summary>
        public IndexedDoubles(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class by copying another instance.
        /// </summary>
        public IndexedDoubles(IndexedDoubles indexedDoubles)
            : base(indexedDoubles)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class from a collection of double values.
        /// </summary>
        public IndexedDoubles(IEnumerable<double> values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class from a collection of double values starting at a specified index.
        /// </summary>
        public IndexedDoubles(IEnumerable<double> values, int startIndex)
            : base(values, startIndex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexedDoubles"/> class with a range of indices set to the same value.
        /// </summary>
        public IndexedDoubles(int startIndex, int count, double value)
            : base(startIndex, count, value)
        {
        }

        /// <summary>
        /// Calculates and returns the average of all stored values.
        /// </summary>
        public double GetAverage()
        {
            return GetSum() / Count;
        }

        /// <summary>
        /// Returns the maximum value present in the collection.
        /// </summary>
        public double GetMaxValue()
        {
            int index = GetMaxValueIndex();
            if (index == -1)
            {
                return double.NaN;
            }

            return this[index];
        }

        /// <summary>
        /// Returns the index of the maximum value in the collection.
        /// </summary>
        public int GetMaxValueIndex()
        {
            int result = -1;

            IEnumerable<int>? keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return result;
            }

            double max = double.MinValue;
            foreach (int key in keys)
            {
                double value = this[key];
                if (double.IsNaN(value))
                {
                    continue;
                }

                if (value > max)
                {
                    max = value;
                    result = key;
                }
            }

            return result;
        }

        /// <summary>
        /// Returns the minimum value present in the collection.
        /// </summary>
        public double GetMinValue()
        {
            int index = GetMinValueIndex();
            if (index == -1)
            {
                return double.NaN;
            }

            return this[index];
        }

        /// <summary>
        /// Returns the index of the minimum value in the collection.
        /// </summary>
        public int GetMinValueIndex()
        {
            int result = -1;

            IEnumerable<int>? keys = Keys;
            if (keys == null || keys.Count() == 0)
            {
                return result;
            }

            double min = double.MaxValue;
            foreach (int key in keys)
            {
                double value = this[key];
                if (double.IsNaN(value))
                {
                    continue;
                }

                if (value < min)
                {
                    min = value;
                    result = key;
                }
            }

            return result;
        }

        /// <summary>
        /// Calculates and returns the sum of all stored values.
        /// </summary>
        public double GetSum()
        {
            IEnumerable<int>? keys = Keys;
            if (keys == null)
            {
                return double.NaN;
            }

            double result = 0;
            foreach (int key in keys)
            {
                double value = this[key];
                if (double.IsNaN(value))
                {
                    continue;
                }

                result += value;
            }

            return result;
        }

        /// <summary>
        /// Adds the values from another <see cref="IndexedDoubles"/> instance to the current collection.
        /// </summary>
        public void Sum(IndexedDoubles indexedDoubles)
        {
            IEnumerable<int>? keys = indexedDoubles?.Keys;
            if (keys == null)
            {
                return;
            }

            foreach (int index in keys)
            {
                double value = indexedDoubles![index];
                if (double.IsNaN(value) || value == 0)
                {
                    continue;
                }

                this[index] = !TryGetValue(index, out double value_Temp) || double.IsNaN(value_Temp) ? value : value + value_Temp;
            }
        }
    }
}