using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a unique identifier for the specified string.
        /// </summary>
        public static string UniqueId(this string? value)
        {
            if (value == null)
            {
                return Constants.UniqueId.Null;
            }

            //ulong result = 0;
            //int index = 0;
            //foreach (char c in value)
            //{
            //    ulong temp = (result * 31) + c;
            //    if (temp < result)
            //    {
            //        index++;
            //    }

            //    result = temp;
            //}

            //return index.ToString() + result.ToString();

            return UniqueHash(value).ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified double.
        /// </summary>
        public static string UniqueId(this double value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable double.
        /// </summary>
        public static string UniqueId(this double? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified float.
        /// </summary>
        public static string UniqueId(this float value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable float.
        /// </summary>
        public static string UniqueId(this float? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified decimal.
        /// </summary>
        public static string UniqueId(this decimal value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable decimal.
        /// </summary>
        public static string UniqueId(this decimal? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified integer.
        /// </summary>
        public static string UniqueId(this int value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable integer.
        /// </summary>
        public static string UniqueId(this int? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified unsigned integer.
        /// </summary>
        public static string UniqueId(this uint value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable unsigned integer.
        /// </summary>
        public static string UniqueId(this uint? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified short.
        /// </summary>
        public static string UniqueId(this short value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable short.
        /// </summary>
        public static string UniqueId(this short? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified boolean.
        /// </summary>
        public static string UniqueId(this bool value)
        {
            return value.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable boolean.
        /// </summary>
        public static string UniqueId(this bool? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return UniqueId(value.Value);
        }

        /// <summary>
        /// Generates a unique identifier for the specified DateTime.
        /// </summary>
        public static string UniqueId(this DateTime value)
        {
            return value.Ticks.ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable DateTime.
        /// </summary>
        public static string UniqueId(this DateTime? value)
        {
            if (value == null || !value.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return UniqueId(value.Value);
        }

        /// <summary>
        /// Generates a unique identifier for the specified JsonNode.
        /// </summary>
        public static string UniqueId(JsonNode? value)
        {
            if (value == null)
            {
                return Constants.UniqueId.Null;
            }

            switch (value.GetValueKind())
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
                    return Constants.UniqueId.Null;

                case System.Text.Json.JsonValueKind.Array:
                    return UniqueId(value.AsArray());

                case System.Text.Json.JsonValueKind.Undefined:
                    break;

                default:
                    break;
            }

            return Constants.UniqueId.Null;
        }

        /// <summary>
        /// Generates a unique identifier for the specified JsonArray.
        /// </summary>
        public static string UniqueId(JsonArray? value)
        {
            if (value == null)
            {
                return Constants.UniqueId.Null;
            }

            List<string> uniqueIds = [];
            foreach (JsonNode? jsonNode in value)
            {
                uniqueIds.Add(UniqueId(jsonNode));
            }

            return UniqueId(string.Join(string.Empty, uniqueIds));
        }

        /// <summary>
        /// Generates a unique identifier for the specified JsonValue.
        /// </summary>
        public static string UniqueId(JsonValue? value)
        {
            object? @object = value?.GetValue<object>();
            if (@object == null)
            {
                return Constants.UniqueId.Null;
            }

            return UniqueId(@object as dynamic);
        }

        /// <summary>
        /// Generates a unique identifier for the specified JsonObject.
        /// </summary>
        public static string UniqueId(this JsonObject? value)
        {
            if (value == null)
            {
                return Constants.UniqueId.Null;
            }

            if (value.ContainsKey(Constants.Serialization.PropertyName.Type) && value.ContainsKey(Constants.Serialization.PropertyName.Guid))
            {
                JsonValue? jsonValue = value[Constants.Serialization.PropertyName.Guid]?.AsValue();

                if (jsonValue != null)
                {
                    if (jsonValue.TryGetValue(out Guid guid))
                    {
                        return UniqueId(guid);
                    }

                    if (jsonValue.TryGetValue(out string? @string) && TryConvert(@string, out guid))
                    {
                        return UniqueId(guid);
                    }
                }
            }

            //return UniqueId(value.ToString());

            return UniqueHash(value).ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable Enum.
        /// </summary>
        public static string UniqueId(this Enum? @enum)
        {
            if (@enum == null)
            {
                return Constants.UniqueId.Null;
            }

            return System.Convert.ToInt32(@enum).ToString();
        }

        /// <summary>
        /// Generates a unique identifier for the specified Guid.
        /// </summary>
        public static string UniqueId(this Guid guid)
        {
            return guid.ToString("N");
        }

        /// <summary>
        /// Generates a unique identifier for the specified nullable Guid.
        /// </summary>
        public static string UniqueId(this Guid? guid)
        {
            if (guid == null || !guid.HasValue)
            {
                return Constants.UniqueId.Null;
            }

            return UniqueId(@guid.Value);
        }

        /// <summary>
        /// Generates a unique identifier for the specified IUniqueObject.
        /// </summary>
        public static string UniqueId(this IUniqueObject? uniqueObject)
        {
            if (uniqueObject == null)
            {
                return Constants.UniqueId.Null;
            }

            return uniqueObject?.UniqueId ?? Constants.UniqueId.Null;
        }

        /// <summary>
        /// Generates a unique identifier for the specified ISerializableObject.
        /// </summary>
        public static string UniqueId(this ISerializableObject? serializableObject)
        {
            if (serializableObject == null)
            {
                return Constants.UniqueId.Null;
            }

            if (serializableObject is IUniqueObject uniqueObject)
            {
                return UniqueId(uniqueObject);
            }

            return UniqueId(serializableObject.ToJsonObject());
        }
    }
}