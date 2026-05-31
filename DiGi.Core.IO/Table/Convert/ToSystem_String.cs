using DiGi.Core.IO.Table.Classes;
using DiGi.Core.IO.Table.Interfaces;
using System.Text.Json;

namespace DiGi.Core.IO.Table
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts a serializable Table to its JSON string representation using default options (WARINNG! all table values have to be serializable objects otherwise converted data may be missing).
        /// </summary>
        public static string? ToSystem_String<UTable, UColumn, URow>(this UTable? table) where UTable : ITable<UColumn, URow>, new() where UColumn : IColumn where URow : IRow<URow>
        {
            JsonSerializerOptions jsonSerializerOptions = new();
            jsonSerializerOptions.Converters.Add(new TableConverter<UTable, UColumn, URow>());

            // Zero string allocations - pipes the bytes directly into the destination stream asynchronously
            return JsonSerializer.Serialize(table, jsonSerializerOptions);
        }

    }
}