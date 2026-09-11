using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes a unique hash for the specified JsonNode over its canonical form. Object keys are sorted ordinally, every segment (value, key, container) is tagged and length-prefixed so that distinct nodes never fold onto the same character stream, and value tags are derived from the JSON value kind rather than the CLR type, so a node built from CLR values and the same node parsed back from its JSON text hash identically.
        /// <para>Numbers hash over their JSON text, which is shortest round-trip on .NET Core 3.0+ and G15 on .NET Framework, so the same double can hash differently across those runtimes.</para>
        /// </summary>
        /// <param name="jsonNode">The JsonNode to hash.</param>
        /// <param name="hash">The initial hash value (offset basis).</param>
        /// <returns>The computed unique hash as a ulong.</returns>
        public static ulong UniqueHash(this JsonNode? jsonNode, ulong hash = Constants.FNV.OffsetBasis)
        {
            if (jsonNode is null)
            {
                return UniqueHash("z;", hash);
            }

            if (jsonNode is JsonValue jsonValue)
            {
                switch (jsonValue.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.String:
                        if (!jsonValue.TryGetValue(out string? @string))
                        {
                            @string = JsonSerializer.Deserialize<string>(jsonValue.ToJsonString());
                        }

                        return UniqueHashSegment("s", @string ?? string.Empty, hash);

                    case System.Text.Json.JsonValueKind.Number:
                        return UniqueHashSegment("n", jsonValue.ToJsonString(), hash);

                    case System.Text.Json.JsonValueKind.True:
                        return UniqueHashSegment("b", "1", hash);

                    case System.Text.Json.JsonValueKind.False:
                        return UniqueHashSegment("b", "0", hash);

                    case System.Text.Json.JsonValueKind.Null:
                        return UniqueHash("z;", hash);

                    default:
                        return UniqueHashSegment("r", jsonValue.ToJsonString(), hash);
                }
            }

            if (jsonNode is JsonObject jsonObject)
            {
                hash = UniqueHash("o" + jsonObject.Count.ToString(CultureInfo.InvariantCulture) + ";", hash);
                foreach (KeyValuePair<string, JsonNode?> keyValuePair in jsonObject.OrderBy(x => x.Key, StringComparer.Ordinal))
                {
                    hash = UniqueHashSegment("k", keyValuePair.Key, hash);
                    hash = UniqueHash(keyValuePair.Value, hash);
                }

                return hash;
            }

            if (jsonNode is JsonArray jsonArray)
            {
                hash = UniqueHash("a" + jsonArray.Count.ToString(CultureInfo.InvariantCulture) + ";", hash);
                foreach (JsonNode? item in jsonArray)
                {
                    hash = UniqueHash(item, hash);
                }

                return hash;
            }

            throw new NotImplementedException();

            static ulong UniqueHashSegment(string tag, string value, ulong hash)
            {
                hash = UniqueHash(tag + ":" + value.Length.ToString(CultureInfo.InvariantCulture) + ":", hash);
                return UniqueHash(value, hash);
            }
        }

        /// <summary>
        /// Computes a unique hash for the specified string.
        /// </summary>
        /// <param name="string">The string to hash.</param>
        /// <param name="hash">The initial hash value (offset basis).</param>
        /// <returns>The computed unique hash as a ulong.</returns>
        public static ulong UniqueHash(this string? @string, ulong hash = Constants.FNV.OffsetBasis)
        {
            if (@string == null)
            {
                return 0;
            }

            ulong result = hash;
            foreach (char @char in @string)
            {
                result = (result ^ @char) * Constants.FNV.Prime;
            }

            return result;
        }
    }
}
