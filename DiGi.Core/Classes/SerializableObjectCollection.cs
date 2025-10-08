using DiGi.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class SerializableObjectCollection<T> : SerializableObject, ICollection<T> where T : ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly List<T> values = [];

        public SerializableObjectCollection()
            :base()
        {

        }

        public SerializableObjectCollection(IEnumerable<T>? serializableObjects) 
        {
            if(serializableObjects != null)
            {
                values.AddRange(serializableObjects);
            }
        }

        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public SerializableObjectCollection(SerializableObjectCollection<T>? serializableObjectCollection)
            : base()
        {
            if(serializableObjectCollection?.values != null)
            {
                values = [.. serializableObjectCollection.values];
            }
        }

        [JsonIgnore]
        public int Count
        {
            get
            {
                return values == null ? 0 : values.Count;
            }
        }

        [JsonIgnore]
        public bool IsReadOnly => false;

        [JsonIgnore]
        public T this[int index]
        {
            get
            {
                return values[index];
            }

            set
            {
                values[index] = value;
            }
        }

        public static explicit operator List<T>?(SerializableObjectCollection<T>? serializableObjectCollection)
        {
            if (serializableObjectCollection == null)
            {
                return null;
            }

            return serializableObjectCollection.values == null ? [] : [.. serializableObjectCollection.values];
        }

        public static explicit operator SerializableObjectCollection<T>?(List<T>? serializableObjects)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            return [.. serializableObjects];
        }

        public static explicit operator SerializableObjectCollection<T>?(T[]? serializableObjects)
        {
            if (serializableObjects == null)
            {
                return null;
            }

            return [.. serializableObjects];
        }

        public static explicit operator T[]?(SerializableObjectCollection<T>? serializableObjectCollection)
        {
            if (serializableObjectCollection == null)
            {
                return null;
            }

            return serializableObjectCollection.values == null ? [] : [.. serializableObjectCollection.values];
        }

        public void Add(T serializableObject)
        {
            values.Add(serializableObject);
        }

        public void Clear()
        {
            values?.Clear();
        }

        public bool Contains(T? item)
        {
            if (values == null || item == null)
            {
                return false;
            }

            return values.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            if (values == null)
            {
                return;
            }

            if (array == null)
            {
                throw new System.ArgumentNullException("array");
            }

            if (values == null)
            {
                return;
            }

            if (arrayIndex < 0)
            {
                throw new System.ArgumentOutOfRangeException("arrayIndex");
            }

            if (array.Length - arrayIndex < values.Count)
            {
                throw new System.ArgumentException("The number of elements in collection is greater than the available space from arrayIndex to the end of the destination array");
            }

            for (int i = 0; i < values.Count; i++)
            {
                array[i + arrayIndex] = values[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return values?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
        public bool Remove(T? item)
        {
            if(values == null || item == null)
            {
                return false;
            }

            return values.Remove(item);
        }

        public void RemoveAt(int index)
        {
            values.RemoveAt(index);
        }
    }

    public class SerializableObjectCollection : SerializableObjectCollection<ISerializableObject>
    {
        public SerializableObjectCollection()
            : base()
        {

        }

        public SerializableObjectCollection(IEnumerable<ISerializableObject>? serializableObjects)
            : base(serializableObjects)
        {

        }

        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public SerializableObjectCollection(SerializableObjectCollection? serializableObjectCollection)
            : base(serializableObjectCollection)
        {

        }

        public override ISerializableObject? Clone()
        {
            return new SerializableObjectCollection(this);
        }
    }
}
