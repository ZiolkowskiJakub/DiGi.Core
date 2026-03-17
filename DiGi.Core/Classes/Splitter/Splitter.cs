using System;
using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    public abstract class Splitter<T, X> where X : struct, IComparable, IConvertible
    {
        private List<T>? items;

        public Splitter(IEnumerable<T> items)
        {
            this.items = items is null ? null : [.. items];
        }

        public List<T>? Items
        {
            get
            {
                return items;
            }

            set
            {
                items = value;
            }
        }

        public abstract X GetValue(T? item);

        public List<List<T>>? Split(X maxValue)
        {
            if (items is null)
            {
                return null;
            }

            List<List<T>> result = [];

            if (items.Count == 0)
            {
                return result;
            }

            List<T> currentValues = [];
            double currentSize = 0;

            double maxValue_Temp = System.Convert.ToDouble(maxValue);

            foreach (T @object in items)
            {
                double itemSize = System.Convert.ToDouble(GetValue(@object));

                // If a single item is larger than the limit, it will form its own chunk
                if (currentSize + itemSize > maxValue_Temp && currentValues.Count > 0)
                {
                    result.Add(currentValues);
                    currentValues = [];
                    currentSize = 0;
                }

                currentValues.Add(@object);
                currentSize += itemSize;
            }

            if (currentValues.Count > 0)
            {
                result.Add(currentValues);
            }

            return result;
        }
    }
}