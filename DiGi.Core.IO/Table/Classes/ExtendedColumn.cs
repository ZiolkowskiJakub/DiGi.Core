using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    /// <summary>
    /// Represents an extended column in a table with additional metadata such as category and description.
    /// </summary>
    public class ExtendedColumn : Column, IExtendedColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with a specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        public ExtendedColumn(int index)
            : base(index)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with a specified index, name, and type.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="name">The name of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public ExtendedColumn(int index, string? name, Type? type)
            : base(index, name, type)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with a specified index and type.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public ExtendedColumn(int index, Type? type)
            : base(index, type)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with a specified name and type.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="type">The data type of the column.</param>
        public ExtendedColumn(string? name, Type? type)
            : base(name, type)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with specified metadata.
        /// </summary>
        /// <param name="name">The name of the column.</param>
        /// <param name="type">The data type of the column.</param>
        /// <param name="category">The category of the column.</param>
        /// <param name="description">A description of the column's purpose.</param>
        public ExtendedColumn(string? name, Type? type, string? category, string? description)
            : base(name, type)
        {
            Category = category;
            Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class by copying another extended column.
        /// </summary>
        /// <param name="extendedColumn">The source extended column to copy from.</param>
        public ExtendedColumn(ExtendedColumn? extendedColumn)
            : base(extendedColumn)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing column data.</param>
        public ExtendedColumn(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedColumn"/> class with a specified index and values copied from another extended column.
        /// </summary>
        /// <param name="index">The zero-based index of the column.</param>
        /// <param name="extendedColumn">The source extended column to copy properties from.</param>
        public ExtendedColumn(int index, ExtendedColumn? extendedColumn)
            : base(index, extendedColumn)
        {
        }

        /// <summary>
        /// Gets or sets the category of the column.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Category))]
        public string? Category { get; set; }

        /// <summary>
        /// Gets or sets a description for the column.
        /// </summary>
        [JsonInclude, JsonPropertyName(nameof(Description))]
        public string? Description { get; set; }
    }
}