using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static ulong UniqueHash(this JsonNode? jsonNode, ulong hash = Constans.FNV.OffsetBasis)
        {
            if (jsonNode is null)
            {
                return UniqueHash(Constans.UniqueId.Null, hash);
            }

            if (jsonNode is JsonValue jsonValue)
            {
                if (jsonValue.TryGetValue(out string? @string))
                {
                    return UniqueHash(@string ?? Constans.UniqueId.Null, hash);
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

        public static ulong UniqueHash(this string? @string, ulong hash = Constans.FNV.OffsetBasis)
        {
            if (@string == null)
            {
                return 0;
            }

            ulong result = hash;
            foreach (char @char in @string)
            {
                result = (result ^ @char) * Constans.FNV.Prime;
            }

            return result;
        }
    }

}
