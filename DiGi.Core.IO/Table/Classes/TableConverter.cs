using DiGi.Core.IO.Table.Interfaces;
using DiGi.Core.Interfaces; // Dla ISerializableObject
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
        public override UTable? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            UTable table = new();
            string columnsName = nameof(ITable<,>.Columns);
            string rowsName = nameof(ITable<,>.Rows);

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return table;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string? propertyName = reader.GetString();
                    reader.Read();

                    if (propertyName == columnsName)
                    {
                        List<JsonObject>? jsonObjects = JsonSerializer.Deserialize<List<JsonObject>>(ref reader, options);
                        if (jsonObjects != null)
                        {
                            foreach (JsonObject jsonObject in jsonObjects)
                            {
                                UColumn? column = DiGi.Core.Create.SerializableObject<UColumn>(jsonObject);
                                if(column is not null)
                                {
                                    table.AddColumn(column);
                                }
                            }
                        }
                    }
                    else if (propertyName == rowsName)
                    {
                        var columnTypes = table.Columns.Select(c => c.Type).ToList();
                        if (reader.TokenType == JsonTokenType.StartArray)
                        {
                            while (reader.Read() && reader.TokenType != JsonTokenType.EndArray)
                            {
                                var rawElements = JsonSerializer.Deserialize<List<JsonElement>>(ref reader, options);
                                if (rawElements != null)
                                {
                                    var typedValues = new List<object?>();
                                    for (int i = 0; i < rawElements.Count; i++)
                                    {
                                        typedValues.Add(ConvertToType(rawElements[i], columnTypes[i], options));
                                    }
                                    table.AddRow(typedValues);
                                }
                            }
                        }
                    }
                }
            }
            return table;
        }

        private object? ConvertToType(JsonElement element, Type targetType, JsonSerializerOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null) return null;

            // Sprawdzamy, czy targetType implementuje ISerializableObject
            if (typeof(ISerializableObject).IsAssignableFrom(targetType))
            {
                var instance = (ISerializableObject)Activator.CreateInstance(targetType)!;
                var jsonNode = JsonSerializer.Deserialize<JsonObject>(element.GetRawText(), options);
                instance.FromJsonObject(jsonNode);
                return instance;
            }

            // Standardowa konwersja dla typów prostych
            if (targetType == typeof(int)) return element.GetInt32();
            if (targetType == typeof(string)) return element.GetString();
            if (targetType == typeof(bool)) return element.GetBoolean();
            if (targetType == typeof(double)) return element.GetDouble();
            if (targetType == typeof(decimal)) return element.GetDecimal();

            return JsonSerializer.Deserialize(element.GetRawText(), targetType, options);
        }

        public override void Write(Utf8JsonWriter utf8JsonWriter, UTable table, JsonSerializerOptions jsonSerializerOptions)
        {
            utf8JsonWriter.WriteStartObject();

            // Zapis kolumn przez ToJsonObject
            utf8JsonWriter.WritePropertyName(nameof(ITable<,>.Columns));
            utf8JsonWriter.WriteStartArray();
            foreach (UColumn column in table.Columns)
            {
                if(column is null)
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