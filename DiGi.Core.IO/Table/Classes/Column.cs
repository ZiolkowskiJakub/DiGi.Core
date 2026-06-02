using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    /// <summary>
    /// Represents a column in a table, defining its index, name, and data type.
    /// </summary>
    public class Column : SerializableObject, IColumn, INamedObject
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Type))]
        private readonly Type? type;

        [JsonInclude, JsonPropertyName(nameof(Index))]
        private int index = -1;

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class with a specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        public Column(int index)
        {
            this.index = index;
            name = null;
            type = typeof(object);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class with a specified index, name, and type.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="name">The name of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public Column(int index, string? name, Type? type)
        {
            this.index = index;
            this.name = name;
            this.type = type ?? typeof(object);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class with a specified index and type.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public Column(int index, Type? type)
        {
            name = null;

            this.index = index;
            this.type = type ?? typeof(object);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class with a specified name and type.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public Column(string? name, Type? type)
        {
            this.name = name;
            this.type = type ?? typeof(object);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class by copying another column.
        /// </summary>
        /// <param name="column">The source column to copy from.</param>
        public Column(Column? column)
        {
            if (column != null)
            {
                index = column.index;
                name = column.name;
                type = column.type ?? typeof(object);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing column data.</param>
        public Column(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Column"/> class with a specified index and values copied from another column.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="column">The source column to copy properties from.</param>
        public Column(int index, Column? column)
        {
            this.index = index;

            if (column != null)
            {
                name = column.name;
                type = column.type ?? typeof(object);
            }
        }

        /// <summary>
        /// Gets or sets the zero-based index of the column.
        /// </summary>
        [JsonIgnore]
        public int Index
        {
            get
            {
                return index;
            }

            set
            {
                index = value;
            }
        }

        /// <summary>
        /// Gets the name of the column.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets the data type of the column.
        /// </summary>
        [JsonIgnore]
        public Type? Type
        {
            get
            {
                return type;
            }
        }

        /// <summary>
        /// Attempts to get a valid value for the column from the provided input, optionally attempting conversion.
        /// </summary>
        /// <param name="in">The input object to validate or convert.</param>
        /// <param name="out">When this method returns, contains the validated or converted value if successful; otherwise, null.</param>
        /// <param name="tryConvert">Whether to attempt conversion if the type is not directly assignable. Defaults to true.</param>
        /// <returns>True if a valid value was obtained; otherwise, false.</returns>
        public bool TryGetValidValue(object? @in, out object? @out, bool tryConvert = true)
        {
            @out = null;

            if (type != null)
            {
                if (@in == null)
                {
                    if (!type.IsNullable())
                    {
                        return false;
                    }
                }
                else if (!type.IsAssignableFrom(@in.GetType()))
                {
                    if (!tryConvert)
                    {
                        return false;
                    }

                    if (!DiGi.Core.Query.TryConvert(@in, out @out, type))
                    {
                        return false;
                    }
                }
                else
                {
                    @out = @in;
                }
            }

            return true;
        }
    }
}