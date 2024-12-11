﻿using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Range<T> : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Min")]
        private T min;
        
        [JsonInclude, JsonPropertyName("Max")]
        private T max;

        public Range(T value_1, T value_2)
        {
            min = System.Math.Min(value_1 as dynamic, value_2 as dynamic);
            max = System.Math.Max(value_1 as dynamic, value_2 as dynamic);
        }

        public Range(Range<T> range)
        {
            min = range.min;
            max = range.max;
        }

        public Range(IEnumerable<T> values)
        {
            if(values != null)
            {
                dynamic min = null;
                dynamic max = null;
                foreach(T value in values)
                {
                    if(value == null)
                    {
                        continue;
                    }

                    if(min == null)
                    {
                        min = value;
                        max = value;
                    }
                    else
                    {
                        min = System.Math.Min(value as dynamic, min);
                        max = System.Math.Max(value as dynamic, max);
                    }
                }

                if(min != null)
                {
                    this.min = min;
                }

                if (max != null)
                {
                    this.max = max;
                }
            }
        }

        public Range(JsonObject jsonObject)
            :base(jsonObject)
        {
            
        }

        public T Max
        {
            get
            {
                return max;
            }
        }

        public T Min
        {
            get
            {
                return min;
            }
        }

        public bool Add(T value)
        {
            bool result = false;

            if ((value as dynamic) > (max as dynamic))
            {
                max = value;
                result = true;
            }

            if ((value as dynamic) < (min as dynamic))
            {
                min = value;
                result = true;
            }

            return result;
        }

        public bool Add(Range<T> value)
        {
            bool result = false;
            if (value == null)
            {
                return false;
            }

            if ((value.max as dynamic) > (max as dynamic))
            {
                max = value.max;
                result = true;
            }

            if ((value.min as dynamic) < (min as dynamic))
            {
                min = value.min;
                result = true;
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("[{0}, {1}]", min, max);
        }

        public bool In(T value)
        {
            return (value as dynamic) <= (max as dynamic) && (value as dynamic) >= (min as dynamic);
        }

        public bool In(T value, T tolerance)
        {
            return (value as dynamic) <= (max as dynamic + tolerance as dynamic) && (value as dynamic) >= (min as dynamic - tolerance as dynamic);
        }

        public bool Out(T value)
        {
            return !In(value);
        }

        public bool Out(T value, T tolerance)
        {
            return !In(value, tolerance);
        }

        public bool In(Range<T> range)
        {
            if (range == null)
            {
                return false;
            }

            return (range.min as dynamic) <= (min as dynamic) && (range.max as dynamic) >= (max as dynamic);
        }

        public bool In(Range<T> range, T tolerance)
        {
            if (range == null)
            {
                return false;
            }

            return (range.min as dynamic) <= (min as dynamic - tolerance as dynamic) && (range.max as dynamic) >= (max as dynamic + tolerance as dynamic);
        }

        public bool Out(Range<T> range)
        {
            if (range == null)
            {
                return false;
            }

            return (range.min as dynamic) >= (max as dynamic) || (range.max as dynamic) <= (min as dynamic);
        }

        public bool Out(Range<T> range, T tolerance)
        {
            if (range == null)
            {
                return false;
            }

            return (range.min as dynamic) >= (max as dynamic - tolerance as dynamic) || (range.max as dynamic) <= (min as dynamic + tolerance as dynamic);
        }

        public bool Intersect(Range<T> range)
        {
            return !Out(range);
        }

        public bool Intersect(Range<T> range, T tolerance)
        {
            return !Out(range, tolerance);
        }

        public T Length
        {
            get
            {
                return (Max as dynamic) - (Min as dynamic);
            }
        }

        public override bool Equals(object @object)
        {
            if (ReferenceEquals(this, null))
                return ReferenceEquals(@object, null) ? true : false;

            return @object is Range<T> range && range.max.Equals(max) && range.min.Equals(min);
        }

        public override int GetHashCode()
        {
            int hash = 13;
            hash = (hash * 7) + min.GetHashCode();
            hash = (hash * 7) + max.GetHashCode();
            return hash;
        }

        public static bool operator ==(Range<T> range, object @object)
        {
            if (ReferenceEquals(range, null))
                return ReferenceEquals(@object, null) ? true : false;

            return range.Equals(@object);
        }

        public static bool operator !=(Range<T> range, object @object)
        {
            return !(range == @object);
        }
    }
}
