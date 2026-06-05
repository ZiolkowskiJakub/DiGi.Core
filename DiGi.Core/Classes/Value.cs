using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A serializable wrapper for values of various types, providing consistent serialization and type tracking.
    /// </summary>
    /// <typeparam name="TObject">The type of the object being wrapped.</typeparam>
    public class Value<TObject> : SerializableObject, IValue<TObject>
    {
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.Value)]
        protected TObject? value;

        /// <summary>
        /// Initializes a new instance of the Value class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object.</param>
        public Value(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a value of type TObject.
        /// </summary>
        /// <param name="value">The value to wrap.</param>
        protected Value(TObject? value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the Value class by copying another Value object.
        /// </summary>
        /// <param name="value">The source value to copy from.</param>
        protected Value(Value<TObject>? value)
        {
            if (value is not null)
            {
                this.value = value.value;
            }
        }

        /// <summary>
        /// Gets the wrapped value.
        /// </summary>
        TObject? IValue<TObject>.Value => value;

        /// <summary>
        /// Gets the runtime type of the wrapped value.
        /// </summary>
        [JsonInclude, JsonPropertyName(Constants.Serialization.PropertyName.ValueType)]
        public Type? ValueType
        {
            get
            {
                return value?.GetType();
            }
        }

        /// <summary>
        /// Attempts to retrieve the wrapped value cast to a specific type XObject.
        /// </summary>
        /// <typeparam name="XObject">The target type.</typeparam>
        /// <returns>The value cast to XObject if successful; otherwise, default.</returns>
        public XObject? GetValue<XObject>() where XObject : TObject
        {
            if (value is XObject @object)
            {
                return @object;
            }

            return default;
        }
    }

    /// <summary>
    /// A non-generic version of the Value class that wraps an object.
    /// </summary>
    public class Value : Value<object>
    {
        /// <summary>
        /// Initializes a new instance of the Value class by copying another Value object.
        /// </summary>
        /// <param name="value">The source value to copy from.</param>
        public Value(Value? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a double value.
        /// </summary>
        /// <param name="value">The double value.</param>
        public Value(double value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a DateTime value.
        /// </summary>
        /// <param name="value">The date and time value.</param>
        public Value(DateTime value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with an integer value.
        /// </summary>
        /// <param name="value">The integer value.</param>
        public Value(int value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a boolean value.
        /// </summary>
        /// <param name="value">The boolean value.</param>
        public Value(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a byte value.
        /// </summary>
        /// <param name="value">The byte value.</param>
        public Value(byte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a float value.
        /// </summary>
        /// <param name="value">The float value.</param>
        public Value(float value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a long value.
        /// </summary>
        /// <param name="value">The long value.</param>
        public Value(long value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a Guid value.
        /// </summary>
        /// <param name="value">The Guid value.</param>
        public Value(Guid value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a string value.
        /// </summary>
        /// <param name="value">The string value.</param>
        public Value(string? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a string array value.
        /// </summary>
        /// <param name="value">The string array.</param>
        public Value(string[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a double array value.
        /// </summary>
        /// <param name="value">The double array.</param>
        public Value(double[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a long array value.
        /// </summary>
        /// <param name="value">The long array.</param>
        public Value(long[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a Guid array value.
        /// </summary>
        /// <param name="value">The Guid array.</param>
        public Value(Guid[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with an integer array value.
        /// </summary>
        /// <param name="value">The integer array.</param>
        public Value(int[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a byte array value.
        /// </summary>
        /// <param name="value">The byte array.</param>
        public Value(byte[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a DateTime array value.
        /// </summary>
        /// <param name="value">The DateTime array.</param>
        public Value(DateTime[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a float array value.
        /// </summary>
        /// <param name="value">The float array.</param>
        public Value(float[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a boolean array value.
        /// </summary>
        /// <param name="value">The boolean array.</param>
        public Value(bool[]? value)
                : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a serializable object value.
        /// </summary>
        /// <param name="value">The serializable object.</param>
        public Value(ISerializableObject? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object.</param>
        public Value(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class with a Type value.
        /// </summary>
        /// <param name="value">The type to wrap.</param>
        public Value(Type? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Value class from a generic object value.
        /// </summary>
        /// <param name="value">The object to wrap.</param>
        protected Value(object? value)
                                                                                                                                                                    : base(value)
        {
        }

        /// <summary>
        /// Creates a deep copy of the Value object by creating a new instance with the current value.
        /// </summary>
        /// <returns>A cloned Value object.</returns>
        public override ISerializableObject? Clone()
        {
            return new Value(value);
        }
    }
}