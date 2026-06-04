using DiGi.Core.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A serializable collection of objects implementing ISerializableObject.
    /// </summary>
    public class SerializableObjectCollection<T> : SerializableObject, ICollection<T> where T : ISerializableObject
    {
        [JsonInclude, JsonPropertyName("Values")]
        private readonly List<T> values = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class.
        /// </summary>
        public SerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class from an enumerable of serializable objects.
        /// </summary>
        public SerializableObjectCollection(IEnumerable<T>? serializableObjects)
        {
            if (serializableObjects != null)
            {
                values.AddRange(serializableObjects);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class from a JSON object.
        /// </summary>
        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection{T}"/> class by copying another collection.
        /// </summary>
        public SerializableObjectCollection(SerializableObjectCollection<T>? serializableObjectCollection)
            : base()
        {
            if (serializableObjectCollection?.values != null)
            {
                values = [.. serializableObjectCollection.values];
            }
        }

        /// <summary>
        /// Gets the number of elements contained in the collection.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return values == null ? 0 : values.Count;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the collection is read-only.
        /// </summary>
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

        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="serializableObject">The object to add to the collection.</param>
        public void Add(T serializableObject)
        {
            values.Add(serializableObject);
        }

        /// <summary>
        /// Removes all items from the collection.
        /// </summary>
        public void Clear()
        {
            values?.Clear();
        }

        /// <summary>
        /// Determines whether the collection contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the collection.</param>
        /// <returns>True if the item is found; otherwise, false.</returns>
        public bool Contains(T? item)
        {
            if (values == null || item == null)
            {
                return false;
            }

            return values.Contains(item);
        }

        /// <summary>
        /// Copies the elements of the collection to an Array, starting at a particular Array index.
        /// </summary>
        /// <param name="array">The one-dimensional Array that is the destination of the elements.</param>
        /// <param name="arrayIndex">The zero-based index in array at which copying begins.</param>
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

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the collection.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return values?.GetEnumerator() ?? Enumerable.Empty<T>().GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>An IEnumerator object that can be used to iterate through the collection.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Removes the first occurrence of a specific object from the collection.
        /// </summary>
        /// <param name="item">The object to remove from the collection.</param>
        /// <returns>True if item was successfully removed from the collection; otherwise, false.</returns>
        public bool Remove(T? item)
        {
            if (values == null || item == null)
            {
                return false;
            }

            return values.Remove(item);
        }

        /// <summary>
        /// Removes the element at the specified index of the collection.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        public void RemoveAt(int index)
        {
            values.RemoveAt(index);
        }
    }

    /// <summary>
    /// Non-generic version of SerializableObjectCollection for handling a collection of ISerializableObjects.
    /// </summary>
    public class SerializableObjectCollection : SerializableObjectCollection<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class.
        /// </summary>
        public SerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class from an enumerable of ISerializableObject instances.
        /// </summary>
        public SerializableObjectCollection(IEnumerable<ISerializableObject>? serializableObjects)
            : base(serializableObjects)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class from a JSON object.
        /// </summary>
        public SerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableObjectCollection"/> class by copying another collection.
        /// </summary>
        public SerializableObjectCollection(SerializableObjectCollection? serializableObjectCollection)
            : base(serializableObjectCollection)
        {
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new SerializableObjectCollection(this);
        }
    }
}