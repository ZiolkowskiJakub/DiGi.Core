using System;
using System.Linq;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A type-safe container that allows a variable to hold one of several specified types.
    /// </summary>
    public class AnyOf
    {
        private object? value;

        /// <summary>
        /// Initializes a new instance of the AnyOf class with a value and an optional type.
        /// </summary>
        /// <param name="value">The value to store.</param>
        /// <param name="type">The expected type of the value.</param>
        public AnyOf(object? value, Type? type = null)
        {
            if (type == null)
            {
                if (IsValid(value))
                {
                    this.value = value;
                }

                return;
            }

            if (value == null || !value.GetType().IsAssignableFrom(type))
            {
                this.value = Query.IsNullable(type) ? null : Activator.CreateInstance(type);
                return;
            }

            this.value = value;
        }

        /// <summary>
        /// Gets the list of allowed types for this container.
        /// </summary>
        public virtual Type[] Types => [typeof(object)];

        /// <summary>
        /// Gets or sets the underlying value stored in the container.
        /// </summary>
        public object? Value
        {
            get
            {
                return value;
            }

            set
            {
                if (IsValid(value))
                {
                    this.value = value;
                }
            }
        }

        /// <summary>
        /// Implicitly converts an integer to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(int value) => new(value, typeof(int));

        /// <summary>
        /// Implicitly converts a string to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(string value) => new(value, typeof(string));

        /// <summary>
        /// Implicitly converts a double to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(double value) => new(value, typeof(double));

        /// <summary>
        /// Implicitly converts a Guid to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(Guid value) => new(value, typeof(Guid));

        /// <summary>
        /// Implicitly converts a DateTime to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(DateTime value) => new(value, typeof(DateTime));

        /// <summary>
        /// Implicitly converts a long to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(long value) => new(value, typeof(long));

        /// <summary>
        /// Implicitly converts a boolean to AnyOf.
        /// </summary>
        public static implicit operator AnyOf(bool value) => new(value, typeof(bool));

        /// <summary>
        /// Implicitly converts an AnyOf instance to its string representation.
        /// </summary>
        public static implicit operator string?(AnyOf value) => value?.ToString();

        /// <summary>
        /// Determines whether the specified AnyOf instance is not equal to the given object.
        /// </summary>
        public static bool operator !=(AnyOf anyOf, object @object)
        {
            return !(anyOf == @object);
        }

        /// <summary>
        /// Determines whether the specified AnyOf instance is equal to the given object.
        /// </summary>
        public static bool operator ==(AnyOf anyOf, object @object)
        {
            if (anyOf is null || anyOf.value is null)
            {
                if (@object is null)
                {
                    return true;
                }

                return false;
            }

            return anyOf.value.Equals(@object);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current AnyOf instance.
        /// </summary>
        /// <param name="object">The object to compare with.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (this is null)
            {
                if (@object is null)
                {
                    return true;
                }

                return false;
            }

            if (value is null)
            {
                return @object is null;
            }

            return value.Equals(@object);
        }

        /// <summary>
        /// Returns the hash code for the contained value.
        /// </summary>
        /// <returns>The hash code of the stored value.</returns>
        public override int GetHashCode()
        {
            if (value == null)
            {
                return 0;
            }

            return value.GetHashCode();
        }

        /// <summary>
        /// Retrieves the actual type of the stored value, or the first allowed type if null.
        /// </summary>
        /// <returns>The Type of the stored value.</returns>
        public new Type? GetType()
        {
            if (value == null)
            {
                return Types?.First();
            }

            return value.GetType();
        }

        /// <summary>
        /// Attempts to retrieve the stored value cast to the specified type T.
        /// </summary>
        /// <typeparam name="T">The target type.</typeparam>
        /// <returns>The value cast to T, or default if not possible.</returns>
        public T? GetValue<T>()
        {
            if (value is T result)
            {
                return result;
            }

            return default;
        }

        /// <summary>
        /// Checks if a given value is compatible with the allowed types of this container.
        /// </summary>
        /// <param name="value">The value to validate.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public bool IsValid(object? value)
        {
            if (Types == null || Types.Length == 0)
            {
                return false;
            }

            if (value == null)
            {
                foreach (Type type in Types)
                {
                    if (Query.IsNullable(type))
                    {
                        return true;
                    }
                }

                return false;
            }

            return Types.Contains(value?.GetType());
        }

        /// <summary>
        /// Returns a string representation of the contained value.
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string? ToString()
        {
            return value?.ToString();
        }
    }

    /// <summary>
    /// A type-safe container for a single specified type T.
    /// </summary>
    public class AnyOf<T>(T value) : AnyOf(value)
    {
        /// <summary>
        /// Gets the single allowed type T for this container.
        /// </summary>
        public override Type[] Types => [typeof(T)];

        /// <summary>
        /// Implicitly converts an AnyOf container to its contained value of type T.
        /// </summary>
        public static implicit operator T?(AnyOf<T> anyOf) => anyOf is null ? default : anyOf.GetValue<T>();
    }

    /// <summary>
    /// A type-safe container for one of two specified types T or K.
    /// </summary>
    public class AnyOf<T, K> : AnyOf
    {
        /// <summary>
        /// Initializes a new instance of AnyOf with a value of type T.
        /// </summary>
        /// <param name="value">The value to store.</param>
        public AnyOf(T value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of AnyOf with a value of type K.
        /// </summary>
        /// <param name="value">The value to store.</param>
        public AnyOf(K value)
            : base(value)
        {
        }

        /// <summary>
        /// Gets the two allowed types T and K for this container.
        /// </summary>
        public override Type[] Types => [typeof(T), typeof(K)];

        /// <summary>
        /// Implicitly converts a value of type T to an AnyOf container holding either T or K.
        /// </summary>
        public static implicit operator AnyOf<T, K>(T value) => new(value);

        /// <summary>
        /// Implicitly converts a value of type K to an AnyOf container holding either T or K.
        /// </summary>
        public static implicit operator AnyOf<T, K>(K value) => new(value);

        /// <summary>
        /// Implicitly converts the AnyOf container to its contained value of type K.
        /// </summary>
        public static implicit operator K?(AnyOf<T, K> anyOf) => anyOf is null ? default : anyOf.GetValue<K>();

        /// <summary>
        /// Implicitly converts the AnyOf container to its contained value of type T.
        /// </summary>
        public static implicit operator T?(AnyOf<T, K> anyOf) => anyOf is null ? default : anyOf.GetValue<T>();
    }
}