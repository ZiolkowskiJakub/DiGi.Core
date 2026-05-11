using DiGi.Core.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    public class ExtendedColumn : Column, IDescribableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Description))]
        public string Description { get; set; }

        [JsonInclude, JsonPropertyName(nameof(Category))]
        public string Category { get; set; }

        public ExtendedColumn(int index)
            : base(index)
        {

        }

        public ExtendedColumn(int index, string? name, Type? type)
            :base(index, name, type)
        {
        }

        public ExtendedColumn(int index, Type? type)
            : base(index, type)
        {

        }

        public ExtendedColumn(string? name, Type? type)
            : base(name, type)
        {

        }

        public ExtendedColumn(ExtendedColumn? extendedColumn)
            : base(extendedColumn)
        {

        }

        public ExtendedColumn(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExtendedColumn(int index, ExtendedColumn? extendedColumn)
            : base(index, extendedColumn)
        {

        }
    }
}