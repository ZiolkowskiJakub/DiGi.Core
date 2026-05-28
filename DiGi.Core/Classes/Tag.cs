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
        /// Initializes a new instance of the Tag class with a serializable object value.
        /// </summary>
        /// <param name="value">The serializable object for the tag.</param>
        public Tag(ISerializableObject? value)
            : base(value)
        {
        }

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