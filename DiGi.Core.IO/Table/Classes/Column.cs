using DiGi.Core.Classes;
using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    public class Column : SerializableObject, IColumn
    {
        [JsonInclude, JsonPropertyName(nameof(Name))]
        private readonly string? name;

        [JsonInclude, JsonPropertyName(nameof(Type))]
        private readonly Type? type;

        [JsonInclude, JsonPropertyName(nameof(Index))]
        private int index = -1;
        public Column(int index)
        {
            this.index = index;
            name = null;
            type = typeof(object);
        }

        public Column(int index, string? name, Type? type)
        {
            this.index = index;
            this.name = name;
            this.type = type ?? typeof(object);
        }

        public Column(int index, Type? type)
        {
            name = null;

            this.index = index;
            this.type = type ?? typeof(object);
        }

        public Column(string? name, Type? type)
        {
            this.name = name;
            this.type = type ?? typeof(object);
        }

        public Column(Column? column)
        {
            if (column != null)
            {
                index = column.index;
                name = column.name;
                type = column.type ?? typeof(object);
            }
        }

        public Column(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Column(int index, Column? column)
        {
            this.index = index;

            if (column != null)
            {
                name = column.name;
                type = column.type ?? typeof(object);
            }
        }

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

        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public Type? Type
        {
            get
            {
                return type;
            }
        }

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