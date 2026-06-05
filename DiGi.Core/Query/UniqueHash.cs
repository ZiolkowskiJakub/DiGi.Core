using System;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Computes a unique hash for the specified JsonNode.
        /// </summary>
        /// <param name="jsonNode">The JsonNode to hash.</param>
        /// <param name="hash">The initial hash value (offset basis).</param>
        /// <returns>The computed unique hash as a ulong.</returns>
        public static ulong UniqueHash(this JsonNode? jsonNode, ulong hash = Constants.FNV.OffsetBasis)
        {
            if (jsonNode is null)
            {
                return UniqueHash(Constants.UniqueId.Null, hash);
            }

            if (jsonNode is JsonValue jsonValue)
            {
                if (jsonValue.TryGetValue(out string? @string))
                {
                    return UniqueHash(@string ?? Constants.UniqueId.Null, hash);
                }

                if (jsonValue.TryGetValue(out int @int))
                {
                    return UniqueHash(@int.ToString(), hash);
                }

                if (jsonValue.TryGetValue(out long @long))
                {
                    return UniqueHash(@long.ToString(), hash);
                }

                if (jsonValue.TryGetValue(out double @double))
                {
                    return UniqueHash(@double.ToString(), hash);
                }

                if (jsonValue.TryGetValue(out bool @bool))
                {
                    return UniqueHash(@bool.ToString(), hash);
                }

                return UniqueHash(jsonValue.ToJsonString(), hash);
            }

            if (jsonNode is JsonObject jsonObject)
            {
                foreach (var kvp in jsonObject)
                {
                    hash = UniqueHash(kvp.Key, hash);
                    hash = UniqueHash(kvp.Value, hash);
                }

                return hash;
            }

            if (jsonNode is JsonArray jsonArray)
            {
                foreach (var item in jsonArray)
                {
                    hash = UniqueHash(item, hash);
                }

                return hash;
            }

            throw new NotImplementedException();
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