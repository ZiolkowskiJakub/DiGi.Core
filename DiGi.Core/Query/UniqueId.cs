using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string UniqueId(this string value)
        {
            if (value == null)
            {
                return Constans.UniqueId.Null;
            }

            ulong result = 0;
            int index = 0;
            foreach (char c in value)
            {
                ulong temp = (result * 31) + c;
                if (temp < result)
                {
                    index++;
                }

                result = temp;
            }

            return index.ToString() + result.ToString();
        }

        public static string UniqueId(this double value)
        {
            return value.ToString();
        }

        public static string UniqueId(this double? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this float value)
        {
            return value.ToString();
        }

        public static string UniqueId(this float? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this decimal value)
        {
            return value.ToString();
        }

        public static string UniqueId(this decimal? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this int value)
        {
            return value.ToString();
        }

        public static string UniqueId(this int? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this uint value)
        {
            return value.ToString();
        }

        public static string UniqueId(this uint? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this short value)
        {
            return value.ToString();
        }

        public static string UniqueId(this short? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return value.ToString();
        }

        public static string UniqueId(this bool value)
        {
            return value.ToString();
        }

        public static string UniqueId(this bool? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return UniqueId(value.Value);
        }

        public static string UniqueId(this DateTime value)
        {
            return value.Ticks.ToString();
        }

        public static string UniqueId(this DateTime? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return UniqueId(value.Value);
        }

        public static string UniqueId(JsonNode value)
        {
            if (value == null)
            {
                return Constans.UniqueId.Null;
            }

            switch(value.GetValueKind())
            {
                case System.Text.Json.JsonValueKind.Number:
                    return UniqueId(value.AsValue());

                case System.Text.Json.JsonValueKind.String:
                    return UniqueId(value.AsValue());

                case System.Text.Json.JsonValueKind.True:
                    return UniqueId(true);

                case System.Text.Json.JsonValueKind.False:
                    return UniqueId(false);

                case System.Text.Json.JsonValueKind.Object:
                    return UniqueId(value.AsObject());

                case System.Text.Json.JsonValueKind.Null:
                    return Constans.UniqueId.Null;

                case System.Text.Json.JsonValueKind.Array:
                    return UniqueId(value.AsArray());
            }

            return null;
        }

        public static string UniqueId(JsonArray value)
        {
            if (value == null)
            {
                return Constans.UniqueId.Null;
            }

            List<string> uniqueIds = new List<string>();
            foreach(JsonNode jsonNode in value)
            {
                uniqueIds.Add(UniqueId(jsonNode));
            }

            return UniqueId(string.Join(string.Empty, uniqueIds));
        }

        public static string UniqueId(JsonValue value)
        {
            object @object = value?.GetValue<object>();
            if(@object == null)
            {
                return Constans.UniqueId.Null;
            }

            return UniqueId(@object as dynamic);
        }

        public static string UniqueId(this JsonObject value)
        {
            if (value == null)
            {
                return Constans.UniqueId.Null;
            }

            if(value.ContainsKey(Constans.Serialization.PropertyName.Type) && value.ContainsKey(Constans.Serialization.PropertyName.Guid))
            {
                JsonValue jsonValue = value[Constans.Serialization.PropertyName.Guid]?.AsValue();

                if (jsonValue != null)
                {
                    if(jsonValue.TryGetValue(out Guid guid))
                    {
                        return UniqueId(guid);
                    }

                    if (jsonValue.TryGetValue(out string @string) && TryConvert(@string, out guid))
                    {
                        return UniqueId(guid);
                    }
                }
            }

            return UniqueId(value.ToString());
        }

        public static string UniqueId(this Enum @enum)
        {
            if(@enum == null)
            {
                return Constans.UniqueId.Null;
            }

            return System.Convert.ToInt32(@enum).ToString();
        }

        public static string UniqueId(this Guid guid)
        {
            return guid.ToString("N");
        }

        public static string UniqueId(this Guid? guid)
        {
            if (guid == null || !guid.HasValue)
            {
                return Constans.UniqueId.Null;
            }

            return UniqueId(@guid.Value);
        }

        public static string UniqueId(this IUniqueObject uniqueObject)
        {
            if(uniqueObject == null)
            {
                return Constans.UniqueId.Null;
            }

            return UniqueId(uniqueObject.Guid);
        }

        public static string UniqueId(this ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return Constans.UniqueId.Null;
            }

            if(serializableObject is IUniqueObject)
            {
                return UniqueId((IUniqueObject)serializableObject);
            }

            return UniqueId(serializableObject.ToJsonObject());
        }
    }
}