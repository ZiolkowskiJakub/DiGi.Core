using DiGi.Core.Interfaces;
using DiGi.Core.IO.Table.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Table.Classes
{
    public class TableConverter<UTable, UColumn, URow> : JsonConverter<UTable>
        where UTable : ITable<UColumn, URow>, new()
        where UColumn : IColumn
        where URow : IRow<URow>
    {
        public override UTable? Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            if (utf8JsonReader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            UTable table = new();
            string columnsName = nameof(ITable<,>.Columns);
            string rowsName = nameof(ITable<,>.Rows);

            while (utf8JsonReader.Read())
            {
                if (utf8JsonReader.TokenType == JsonTokenType.EndObject)
                {
                    return table;
                }

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    if (propertyName == columnsName)
                    {
                        List<JsonObject>? jsonObjects = JsonSerializer.Deserialize<List<JsonObject>>(ref utf8JsonReader, jsonSerializerOptions);
                        if (jsonObjects != null)
                        {
                            foreach (JsonObject jsonObject in jsonObjects)
                            {
                                UColumn? column = DiGi.Core.Create.SerializableObject<UColumn>(jsonObject);
                                if (column is not null)
                                {
                                    table.AddColumn(column);
                                }
                            }
                        }
                    }
                    else if (propertyName == rowsName)
                    {
                        List<Type?> types = [.. table.Columns.Select(c => c.Type)];
                        if (utf8JsonReader.TokenType == JsonTokenType.StartArray)
                        {
                            while (utf8JsonReader.Read() && utf8JsonReader.TokenType != JsonTokenType.EndArray)
                            {
                                List<JsonElement>? jsonElements = JsonSerializer.Deserialize<List<JsonElement>>(ref utf8JsonReader, jsonSerializerOptions);
                                if (jsonElements is null)
                                {
                                    continue;
                                }

                                List<object?> values = [];
                                for (int i = 0; i < jsonElements.Count; i++)
                                {
                                    if (DiGi.Core.Query.TryConvert(jsonElements[i], out object? value, types[i] ?? typeof(object)))
                                    {
                                        values.Add(value);
                                    }
                                    else
                                    {
                                        values.Add(null);
                                    }
                                }
                                table.AddRow(values);
                            }
                        }
                    }
                }
            }
            return table;
        }

        public override void Write(Utf8JsonWriter utf8JsonWriter, UTable table, JsonSerializerOptions jsonSerializerOptions)
        {
            utf8JsonWriter.WriteStartObject();

            // Zapis kolumn przez ToJsonObject
            utf8JsonWriter.WritePropertyName(nameof(ITable<,>.Columns));
            utf8JsonWriter.WriteStartArray();
            foreach (UColumn column in table.Columns)
            {
                if (column is null)
                {
                    continue;
                }

                JsonSerializer.Serialize(utf8JsonWriter, column.ToJsonObject(), jsonSerializerOptions);
            }
            utf8JsonWriter.WriteEndArray();

            utf8JsonWriter.WritePropertyName(nameof(ITable<,>.Rows));
            utf8JsonWriter.WriteStartArray();
            foreach (URow row in table.Rows)
            {
                utf8JsonWriter.WriteStartArray();
                foreach (object? value in row.GetValues())
                {
                    if (value is ISerializableObject serializableObject)
                    {
                        JsonSerializer.Serialize(utf8JsonWriter, serializableObject.ToJsonObject(), jsonSerializerOptions);
                    }
                    else
                    {
                        JsonSerializer.Serialize(utf8JsonWriter, value, jsonSerializerOptions);
                    }
                }
                utf8JsonWriter.WriteEndArray();
            }
            utf8JsonWriter.WriteEndArray();

            utf8JsonWriter.WriteEndObject();
        }
    }
}