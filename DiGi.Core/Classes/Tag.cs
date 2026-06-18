using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// A specialized Value class used to associate metadata tags with objects.
    /// </summary>
    public class Tag : Value
    {
        /// <summary>
        /// Initializes a new instance of the Tag class with a string value.
        /// </summary>
        /// <param name="value">The string value for the tag.</param>
        public Tag(string? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a double value.
        /// </summary>
        /// <param name="value">The double value for the tag.</param>
        public Tag(double value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a DateTime value.
        /// </summary>
        /// <param name="value">The date and time value for the tag.</param>
        public Tag(DateTime value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a boolean value.
        /// </summary>
        /// <param name="value">The boolean value for the tag.</param>
        public Tag(bool value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an integer value.
        /// </summary>
        /// <param name="value">The integer value for the tag.</param>
        public Tag(int value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned integer value.
        /// </summary>
        /// <param name="value">The unsigned integer value for the tag.</param>
        public Tag(uint value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a signed byte value.
        /// </summary>
        /// <param name="value">The signed byte value for the tag.</param>
        public Tag(sbyte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a short integer value.
        /// </summary>
        /// <param name="value">The short integer value for the tag.</param>
        public Tag(short value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned short integer value.
        /// </summary>
        /// <param name="value">The unsigned short integer value for the tag.</param>
        public Tag(ushort value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a long integer value.
        /// </summary>
        /// <param name="value">The long integer value for the tag.</param>
        public Tag(long value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned long integer value.
        /// </summary>
        /// <param name="value">The unsigned long integer value for the tag.</param>
        public Tag(ulong value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a decimal value.
        /// </summary>
        /// <param name="value">The decimal value for the tag.</param>
        public Tag(decimal value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a character value.
        /// </summary>
        /// <param name="value">The character value for the tag.</param>
        public Tag(char value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a DateTimeOffset value.
        /// </summary>
        /// <param name="value">The date, time, and offset value for the tag.</param>
        public Tag(DateTimeOffset value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a TimeSpan value.
        /// </summary>
        /// <param name="value">The time span value for the tag.</param>
        public Tag(TimeSpan value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a byte value.
        /// </summary>
        /// <param name="value">The byte value for the tag.</param>
        public Tag(byte value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a float value.
        /// </summary>
        /// <param name="value">The float value for the tag.</param>
        public Tag(float value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a Guid value.
        /// </summary>
        /// <param name="value">The Guid value for the tag.</param>
        public Tag(Guid value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a Type value.
        /// </summary>
        /// <param name="value">The type to wrap for the tag.</param>
        public Tag(Type? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a string array value.
        /// </summary>
        /// <param name="value">The string array for the tag.</param>
        public Tag(string[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a double array value.
        /// </summary>
        /// <param name="value">The double array for the tag.</param>
        public Tag(double[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a long array value.
        /// </summary>
        /// <param name="value">The long array for the tag.</param>
        public Tag(long[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a Guid array value.
        /// </summary>
        /// <param name="value">The Guid array for the tag.</param>
        public Tag(Guid[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an integer array value.
        /// </summary>
        /// <param name="value">The integer array for the tag.</param>
        public Tag(int[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned integer array value.
        /// </summary>
        /// <param name="value">The unsigned integer array for the tag.</param>
        public Tag(uint[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a signed byte array value.
        /// </summary>
        /// <param name="value">The signed byte array for the tag.</param>
        public Tag(sbyte[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a short integer array value.
        /// </summary>
        /// <param name="value">The short integer array for the tag.</param>
        public Tag(short[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned short integer array value.
        /// </summary>
        /// <param name="value">The unsigned short integer array for the tag.</param>
        public Tag(ushort[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with an unsigned long integer array value.
        /// </summary>
        /// <param name="value">The unsigned long integer array for the tag.</param>
        public Tag(ulong[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a decimal array value.
        /// </summary>
        /// <param name="value">The decimal array for the tag.</param>
        public Tag(decimal[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a character array value.
        /// </summary>
        /// <param name="value">The character array for the tag.</param>
        public Tag(char[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a DateTimeOffset array value.
        /// </summary>
        /// <param name="value">The DateTimeOffset array for the tag.</param>
        public Tag(DateTimeOffset[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a TimeSpan array value.
        /// </summary>
        /// <param name="value">The TimeSpan array for the tag.</param>
        public Tag(TimeSpan[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a byte array value.
        /// </summary>
        /// <param name="value">The byte array for the tag.</param>
        public Tag(byte[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a DateTime array value.
        /// </summary>
        /// <param name="value">The DateTime array for the tag.</param>
        public Tag(DateTime[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a float array value.
        /// </summary>
        /// <param name="value">The float array for the tag.</param>
        public Tag(float[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a boolean array value.
        /// </summary>
        /// <param name="value">The boolean array for the tag.</param>
        public Tag(bool[]? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class with a serializable object value.
        /// </summary>
        /// <param name="value">The serializable object for the tag.</param>
        public Tag(ISerializableObject? value)
            : base(value)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing tag data.</param>
        private Tag(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class by copying another Tag object.
        /// </summary>
        /// <param name="tag">The source tag to copy from.</param>
        private Tag(Tag? tag)
            : base(tag)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Tag class from a generic object value.
        /// </summary>
        /// <param name="tag">The value to associate with the tag.</param>
        private Tag(object? tag)
            : base(tag)
        {
        }
        #region Implicit Operators

        /// <summary>
        /// Implicitly converts a string value to a Tag.
        /// </summary>
        public static implicit operator Tag(string? value) => new (value);

        /// <summary>
        /// Implicitly converts a double value to a Tag.
        /// </summary>
        public static implicit operator Tag(double value) => new (value);

        /// <summary>
        /// Implicitly converts a DateTime value to a Tag.
        /// </summary>
        public static implicit operator Tag(DateTime value) => new (value);

        /// <summary>
        /// Implicitly converts a boolean value to a Tag.
        /// </summary>
        public static implicit operator Tag(bool value) => new (value);

        /// <summary>
        /// Implicitly converts an integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(int value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(uint value) => new (value);

        /// <summary>
        /// Implicitly converts a signed byte value to a Tag.
        /// </summary>
        public static implicit operator Tag(sbyte value) => new (value);

        /// <summary>
        /// Implicitly converts a short integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(short value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned short integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(ushort value) => new (value);

        /// <summary>
        /// Implicitly converts a long integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(long value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned long integer value to a Tag.
        /// </summary>
        public static implicit operator Tag(ulong value) => new (value);

        /// <summary>
        /// Implicitly converts a decimal value to a Tag.
        /// </summary>
        public static implicit operator Tag(decimal value) => new (value);

        /// <summary>
        /// Implicitly converts a character value to a Tag.
        /// </summary>
        public static implicit operator Tag(char value) => new (value);

        /// <summary>
        /// Implicitly converts a DateTimeOffset value to a Tag.
        /// </summary>
        public static implicit operator Tag(DateTimeOffset value) => new (value);

        /// <summary>
        /// Implicitly converts a TimeSpan value to a Tag.
        /// </summary>
        public static implicit operator Tag(TimeSpan value) => new (value);

        /// <summary>
        /// Implicitly converts a byte value to a Tag.
        /// </summary>
        public static implicit operator Tag(byte value) => new (value);

        /// <summary>
        /// Implicitly converts a float value to a Tag.
        /// </summary>
        public static implicit operator Tag(float value) => new (value);

        /// <summary>
        /// Implicitly converts a Guid value to a Tag.
        /// </summary>
        public static implicit operator Tag(Guid value) => new (value);

        /// <summary>
        /// Implicitly converts a Type value to a Tag.
        /// </summary>
        public static implicit operator Tag(Type? value) => new (value);

        /// <summary>
        /// Implicitly converts a string array to a Tag.
        /// </summary>
        public static implicit operator Tag(string[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a double array to a Tag.
        /// </summary>
        public static implicit operator Tag(double[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a long array to a Tag.
        /// </summary>
        public static implicit operator Tag(long[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a Guid array to a Tag.
        /// </summary>
        public static implicit operator Tag(Guid[]? value) => new (value);

        /// <summary>
        /// Implicitly converts an integer array to a Tag.
        /// </summary>
        public static implicit operator Tag(int[]? value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned integer array to a Tag.
        /// </summary>
        public static implicit operator Tag(uint[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a signed byte array to a Tag.
        /// </summary>
        public static implicit operator Tag(sbyte[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a short integer array to a Tag.
        /// </summary>
        public static implicit operator Tag(short[]? value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned short integer array to a Tag.
        /// </summary>
        public static implicit operator Tag(ushort[]? value) => new (value);

        /// <summary>
        /// Implicitly converts an unsigned long integer array to a Tag.
        /// </summary>
        public static implicit operator Tag(ulong[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a decimal array to a Tag.
        /// </summary>
        public static implicit operator Tag(decimal[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a character array to a Tag.
        /// </summary>
        public static implicit operator Tag(char[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a DateTimeOffset array to a Tag.
        /// </summary>
        public static implicit operator Tag(DateTimeOffset[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a TimeSpan array to a Tag.
        /// </summary>
        public static implicit operator Tag(TimeSpan[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a byte array to a Tag.
        /// </summary>
        public static implicit operator Tag(byte[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a DateTime array to a Tag.
        /// </summary>
        public static implicit operator Tag(DateTime[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a float array to a Tag.
        /// </summary>
        public static implicit operator Tag(float[]? value) => new (value);

        /// <summary>
        /// Implicitly converts a boolean array to a Tag.
        /// </summary>
        public static implicit operator Tag(bool[]? value) => new (value);

        #endregion

        /// <summary>
        /// Gets or sets the underlying value of the tag.
        /// </summary>
        [JsonIgnore]
        public object? Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        /// <summary>
        /// Creates a deep copy of the tag by creating a new Tag instance with the current value.
        /// </summary>
        /// <returns>A cloned Tag object.</returns>
        public override ISerializableObject? Clone()
        {
            return new Tag(Value);
        }
    }
}