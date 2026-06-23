using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to convert the specified object to the target type.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted object, or null if conversion failed.</param>
        /// <param name="type">The target type to convert to.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(this object? @object, out object? result, Type? type)
        {
            result = default;

            if (type is null)
            {
                return false;
            }

            if (type == typeof(object))
            {
                result = @object;
                return true;
            }

            if (@object is null)
            {
                if (type.IsNullable())
                {
                    result = null;
                    return true;
                }

                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            Type? type_Object = @object?.GetType();
            if (type_Object == type || type == null)
            {
                result = @object;
                return true;
            }

            Type type_Temp = Nullable.GetUnderlyingType(type) ?? type;
            if (type_Temp.IsAssignableFrom(@object!.GetType()))
            {
                result = @object;
                return true;
            }

            bool succeeded;

            if (type_Temp.IsEnum)
            {
                succeeded = TryConvert_Enum(@object, out Enum? @enum, type_Temp);
                result = @enum;
                return succeeded;
            }

            TypeCode typeCode = System.Type.GetTypeCode(type_Temp);

            switch (typeCode)
            {
                case TypeCode.String:
                    succeeded = TryConvert_String(@object, out string? @string);
                    result = @string;
                    return succeeded;

                case TypeCode.Int32:

                    succeeded = TryConvert_Int(@object, out int? @int);
                    result = @int;
                    return succeeded;

                case TypeCode.Int64:
                    succeeded = TryConvert_Long(@object, out long? @long);
                    result = @long;
                    return succeeded;

                case TypeCode.Boolean:
                    succeeded = TryConvert_Boolean(@object, out bool? @bool);
                    result = @bool;
                    return succeeded;

                case TypeCode.Double:
                    succeeded = TryConvert_Double(@object, out double? @double);
                    result = @double;
                    return succeeded;

                case TypeCode.Decimal:
                    succeeded = TryConvert_Decimal(@object, out decimal? @decimal);
                    result = @decimal;
                    return succeeded;

                case TypeCode.Single:
                    succeeded = TryConvert_Float(@object, out float? @float);
                    result = @float;
                    return succeeded;

                case TypeCode.UInt16:
                    succeeded = TryConvert_Ushort(@object, out ushort? @ushort);
                    result = @ushort;
                    return succeeded;

                case TypeCode.UInt32:
                    succeeded = TryConvert_Uint(@object, out uint? @uint);
                    result = @uint;
                    return succeeded;

                case TypeCode.Int16:
                    succeeded = TryConvert_Short(@object, out short? @short);
                    result = @short;
                    return succeeded;

                case TypeCode.Byte:
                    succeeded = TryConvert_Byte(@object, out byte? @byte);
                    result = @byte;
                    return succeeded;

                case TypeCode.UInt64:
                    succeeded = TryConvert_Ulong(@object, out ulong? @ulong);
                    result = @ulong;
                    return succeeded;

                case TypeCode.DateTime:
                    succeeded = TryConvert_DateTime(@object, out DateTime? @dateTime);
                    result = @dateTime;
                    return succeeded;

                case TypeCode.SByte:
                    succeeded = TryConvert_Sbyte(@object, out sbyte? @sbyte);
                    result = @sbyte;
                    return succeeded;

                case TypeCode.Char:
                    succeeded = TryConvert_Char(@object, out char? @char);
                    result = @char;
                    return succeeded;
            }

            if (type_Temp == typeof(Guid))
            {
                succeeded = TryConvert_Guid(@object, out Guid? @guid);
                result = @guid;
                return succeeded;
            }
            else if (type_Temp == typeof(System.Drawing.Color))
            {
                succeeded = TryConvert_Color(@object, out System.Drawing.Color? @color);
                result = @color;
                return succeeded;
            }
            else if (type_Temp == typeof(TimeSpan))
            {
                succeeded = TryConvert_TimeSpan(@object, out TimeSpan? @timeSpan);
                result = @timeSpan;
                return succeeded;
            }
            else if (type_Temp == typeof(DateTimeOffset))
            {
                succeeded = TryConvert_DateTimeOffset(@object, out DateTimeOffset? @dateTimeOffset);
                result = @dateTimeOffset;
                return succeeded;
            }
            else if (type_Temp.IsSubclassOf(typeof(Type)) || type_Temp == typeof(Type))
            {
                succeeded = TryConvert_Type(@object, out Type? @type_Result);
                result = @type_Result;
                return succeeded;
            }
            else if (typeof(ISerializableObject).IsAssignableFrom(type_Temp))
            {
                succeeded = TryConvert_SerializableObject(@object, out ISerializableObject? serializableObject, type_Temp);
                result = serializableObject;
                return succeeded;
            }
            else if (typeof(JsonObject).IsAssignableFrom(type_Temp))
            {
                succeeded = TryConvert_JsonNode(@object, out JsonNode? jsonNode);
                result = jsonNode;
                return succeeded;
            }
            else if (typeof(IEnumerable).IsAssignableFrom(type_Temp))
            {
                succeeded = TryConvert_Enumerable(@object, out IEnumerable? @enumerable, type_Temp);
                result = @enumerable;
                return succeeded;
            }

            result = default;
            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to the target type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">The target type to convert to.</typeparam>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted value, or default if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert<T>(this object? @object, out T? result)
        {
            result = default;

            if (!TryConvert(@object, out object? result_Object, typeof(T)))
            {
                return false;
            }

            if (result_Object is null)
            {
                result = default;
            }
            else
            {
                result = (T)result_Object;
            }

            return true;
        }

        /// <summary>
        /// Attempts to convert the specified object using a DataType enum to determine the target type.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted object, or null if conversion failed.</param>
        /// <param name="dataType">The DataType enum value indicating the target type.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(this object? @object, out object? result, DataType dataType)
        {
            result = null;
            if (dataType == Enums.DataType.Undefined)
            {
                return false;
            }

            return TryConvert(@object, out result, Type(dataType));
        }

        /// <summary>
        /// Attempts to convert a <see cref="JsonElement"/> to the specified target type.
        /// </summary>
        /// <param name="jsonElement">The JsonElement to convert.</param>
        /// <param name="result">When this method returns, contains the converted object, or null if conversion failed.</param>
        /// <param name="type">The target type to convert to.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert(this JsonElement jsonElement, out object? result, Type type)
        {
            result = null;
            object? rawValue = null;

            // Use a switch on ValueKind to extract the underlying value from JsonElement
            switch (jsonElement.ValueKind)
            {
                case System.Text.Json.JsonValueKind.Null:
                    // For nullable types, null is a valid result
                    if (type.IsNullable() || !type.IsValueType)
                    {
                        result = null;
                        return true;
                    }
                    return false;

                case System.Text.Json.JsonValueKind.Object:
                    // For objects, we pass the raw JSON string to be handled by
                    // TryConvert_SerializableObject or TryConvert_JsonNode
                    rawValue = jsonElement.GetRawText();
                    break;

                case System.Text.Json.JsonValueKind.Array:
                    // Enumerable conversion expects an IEnumerable.
                    // We pass the JsonElement itself, assuming TryConvert_Enumerable
                    // can handle it or we convert it to a string/list.
                    rawValue = jsonElement;
                    break;

                case System.Text.Json.JsonValueKind.String:
                    // Extract the string without quotes for further parsing
                    rawValue = jsonElement.GetString();
                    break;

                case System.Text.Json.JsonValueKind.Number:
                    // We need to be careful with numbers.
                    // We can try to extract the most precise decimal and let TryConvert handle downcasting.
                    if (jsonElement.TryGetDecimal(out decimal decimalValue))
                    {
                        rawValue = decimalValue;
                    }
                    else if (jsonElement.TryGetDouble(out double doubleValue))
                    {
                        rawValue = doubleValue;
                    }
                    break;

                case System.Text.Json.JsonValueKind.True:
                    rawValue = true;
                    break;

                case System.Text.Json.JsonValueKind.False:
                    rawValue = false;
                    break;

                case System.Text.Json.JsonValueKind.Undefined:
                default:
                    return false;
            }

            // Now delegate the actual type conversion to the main TryConvert logic
            return TryConvert(rawValue, out result, type);
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable boolean.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted bool, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Boolean(object @object, out bool? result)
        {
            result = null;

            if (@object is string @string)
            {
                if (bool.TryParse(@string, out bool @bool))
                {
                    result = @bool;
                    return true;
                }

                // Avoid ToUpper() to reduce allocations. Use OrdinalIgnoreCase.
                if (string.Equals(@string, "1") ||
                    string.Equals(@string, "YES", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(@string, "TRUE", StringComparison.OrdinalIgnoreCase))
                {
                    result = true;
                    return true;
                }

                return false;
            }

            if (IsNumeric(@object))
            {
                result = System.Convert.ToInt64(@object) == 1;
                return true;
            }

            if (@object is JsonNode jsonNode)
            {
                result = jsonNode?.GetValue<bool>();
                return true;
            }

            if (@object is JsonElement jsonElement)
            {
                switch (jsonElement.ValueKind)
                {
                    case System.Text.Json.JsonValueKind.True:
                        result = true;
                        return true;

                    case System.Text.Json.JsonValueKind.False:
                        result = false;
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (jsonElement.GetString() is not string value)
                        {
                            result = false;
                            return false;
                        }
                        return TryConvert_Boolean(value, out result);

                    case System.Text.Json.JsonValueKind.Number:
                        // Handling cases where 1/0 is used for boolean in JSON
                        if (jsonElement.TryGetInt64(out long @long))
                        {
                            result = (@long == 1);
                            return true;
                        }
                        break;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable byte.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted byte, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Byte(object @object, out byte? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (byte.TryParse(@string, out byte @byte))
                {
                    result = @byte;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToByte(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<byte>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Byte(jsonNode.GetValue<string>(), out byte? @byte))
                        {
                            result = @byte;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetByte(out byte byteVal))
                {
                    result = byteVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Byte(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable <see cref="System.Drawing.Color"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted Color, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Color(object @object, out System.Drawing.Color? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (@string.StartsWith("##"))
                {
                    result = Convert.ToDrawing(@string);
                    if (!result.Equals(System.Drawing.Color.Empty))
                    {
                        return true;
                    }
                }

                if (int.TryParse(@string, out int @int))
                {
                    result = Convert.ToDrawing(@int);
                    return true;
                }

                if (uint.TryParse(@string, out uint @uint))
                {
                    result = Convert.ToDrawing(@uint);
                    return true;
                }

                result = Convert.ToDrawing(@string);
                if (!result.Equals(System.Drawing.Color.Empty))
                    return true;
            }
            else if (@object is Classes.Color color)
            {
                result = (System.Drawing.Color)color;
                return true;
            }
            else if (@object is int @int)
            {
                result = Convert.ToDrawing(@int);
                return true;
            }
            else if (@object is uint unit)
            {
                result = Convert.ToDrawing(unit);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable <see cref="DateTime"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted DateTime, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_DateTime(object @object, out DateTime? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (DateTime.TryParse(@string, out DateTime dateTime))
                {
                    result = dateTime;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = @object is double @double ? DateTime.FromOADate(@double) : new DateTime(System.Convert.ToInt64(@object));
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.String:
                        // Using ToString() is safer as it provides the string representation
                        // without the strict type-checking constraints of GetValue<string>()
                        string text = jsonNode.ToString();
                        if (text.StartsWith("\"") && text.EndsWith("\""))
                        {
                            text = text.Substring(1, text.Length - 2);
                        }

                        // We don't need Substring here; System.Text.Json.Nodes handles
                        // JSON quotes automatically during the ToString/GetValue call
                        // string text = jsonNode.GetValue<string>();
                        if (DateTime.TryParse(text, out DateTime dateTime))
                        {
                            result = dateTime;
                            return true;
                        }
                        break;

                    case System.Text.Json.JsonValueKind.Number:
                        // Optional: Handle Unix timestamps if your database or API sends them as numbers
                        if (jsonNode.AsValue().TryGetValue(out long unixTimestamp))
                        {
                            result = DateTimeOffset.FromUnixTimeSeconds(unixTimestamp).DateTime;
                            return true;
                        }
                        break;
                }

                try
                {
                    // Final fallback attempt for standard ISO 8601 formats
                    result = jsonNode.GetValue<DateTime>();
                    return true;
                }
                catch (Exception)
                {
                    // Return default value if all conversion attempts fail
                    return false;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && jsonElement.TryGetDateTime(out DateTime dt))
                {
                    result = dt;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetInt64(out long ticks))
                {
                    // Handling ticks or Unix timestamps via the numeric path
                    result = new DateTime(ticks);
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable decimal.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted decimal, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Decimal(object @object, out decimal? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (decimal.TryParse(@string, out decimal @decimal))
                {
                    result = @decimal;
                    return true;
                }
            }
            else if (IsNumeric(@object) && @object is not System.Type)
            {
                result = System.Convert.ToDecimal(@object);
                return true;
            }
            else if (@object is bool @bool)
            {
                decimal @decimal = 0;
                if (@bool)
                    @decimal = 1;

                result = @decimal;
                return true;
            }
            else if (@object is int @int)
            {
                result = System.Convert.ToDecimal(@int);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<decimal>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Decimal(jsonNode.GetValue<string>(), out decimal? dec_Temp))
                        {
                            result = dec_Temp;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetDecimal(out decimal decVal))
                {
                    result = decVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Decimal(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable double.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted double, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Double(object @object, out double? result)
        {
            result = null;

            if (@object is null || @object is Type)
            {
                return false;
            }

            TypeCode typeCode = System.Type.GetTypeCode(@object.GetType());

            switch (typeCode)
            {
                case TypeCode.String:
                    if (TryParseDouble((string)@object, out double @double))
                    {
                        result = @double;
                        return true;
                    }
                    break;

                case TypeCode.Boolean:
                    result = (bool)@object ? 1 : 0;
                    return true;
            }

            if (IsNumeric(@object) && @object is not System.Type)
            {
                result = System.Convert.ToDouble(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<double>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Double(jsonNode.GetValue<string>(), out double? @double))
                        {
                            result = @double;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetDouble(out double doubleVal))
                {
                    result = doubleVal;
                    return true;
                }

                if (jsonElement.GetString() is not string value)
                {
                    return false;
                }

                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && TryConvert_Double(value, out double? stringDouble))
                {
                    result = stringDouble;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an Enum of the specified type.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted Enum, or null if conversion failed.</param>
        /// <param name="type">The target enum type.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Enum(object @object, out Enum? result, Type type)
        {
            result = default;

            if (@object is Enum @enum_Temp)
            {
                result = @enum_Temp;
                return true;
            }

            if (@object == null)
            {
                return false;
            }

            Array array = System.Enum.GetValues(type);
            if (array is null || array.Length == 0)
            {
                return false;
            }

            object @object_Temp = @object;
            if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        @object_Temp = jsonNode.GetValue<int>();
                        break;

                    case System.Text.Json.JsonValueKind.String:
                        @object_Temp = jsonNode.GetValue<string>();
                        break;
                }
            }

            if (@object_Temp is string string_Temp)
            {
                if (string.IsNullOrWhiteSpace(string_Temp))
                {
                    return false;
                }
                string string_Normalized = string_Temp.Replace(" ", string.Empty);

                foreach (Enum @enum in array)
                {
                    if (string.Equals(@enum.ToString(), string_Normalized, StringComparison.OrdinalIgnoreCase))
                    {
                        result = @enum;
                        return true;
                    }

                    string? description = Description(@enum);
                    if (description != null)
                    {
                        string description_Normalized = description.Replace(" ", string.Empty);
                        if (string.Equals(description_Normalized, string_Normalized, StringComparison.OrdinalIgnoreCase))
                        {
                            result = @enum;
                            return true;
                        }
                    }
                }

                if (int.TryParse(string_Normalized, out int index) && System.Enum.IsDefined(type, index))
                {
                    result = (Enum)System.Enum.ToObject(type, index);
                    return true;
                }
            }
            else if (IsNumeric(@object_Temp))
            {
                if (TryConvert(@object_Temp, out int index) && System.Enum.IsDefined(type, index))
                {
                    foreach (Enum @enum in array)
                    {
                        if ((int)(object)@enum == index)
                        {
                            result = @enum;
                            return true;
                        }
                    }
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    @object_Temp = value;
                }
                else if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetInt32(out int intVal))
                {
                    @object_Temp = intVal;
                }

                if (object_Temp is null)
                {
                    return false;
                }

                return TryConvert_Enum(object_Temp, out result, type);
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an IEnumerable of the specified type.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted IEnumerable, or null if conversion failed.</param>
        /// <param name="type">The target enumerable type.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Enumerable(object @object, out IEnumerable? result, Type type)
        {
            result = default;

            if (@object is JsonElement jsonElement && jsonElement.ValueKind == System.Text.Json.JsonValueKind.Array)
            {
                // We can treat JsonElement array as an IEnumerable of its elements
                @object = jsonElement.EnumerateArray();
            }

            if (type.IsArray)
            {
                Type elementType = type.GetElementType();

                if (@object is IEnumerable enumerable)
                {
                    List<object?> objects = [];
                    foreach (object? object_Temp in enumerable)
                    {
                        if (TryConvert(object_Temp, out object? @object_Converted, elementType))
                        {
                            objects.Add(@object_Converted);
                        }
                    }

                    Array array = Array.CreateInstance(elementType, objects.Count);
                    for (int i = 0; i < objects.Count; i++)
                    {
                        array.SetValue(objects[i], i);
                    }

                    result = array;
                    return true;
                }
                else if (TryConvert(@object, out object? @object_Converted, elementType))
                {
                    Array array = Array.CreateInstance(elementType, 1);
                    array.SetValue(object_Converted, 0);
                    result = array;
                    return true;
                }
            }

            if (type.IsGenericType)
            {
                MethodInfo? methodInfo = Settings.ConversionManager.GetMethodInfo(type); //type.GetMethod("Add");
                if (methodInfo is not null)
                {
                    Type elementType = type.GetGenericArguments()[0];
                    object enumerable = Activator.CreateInstance(type);

                    if (@object is IEnumerable enumerable_Temp)
                    {
                        foreach (object? object_Temp in enumerable_Temp)
                        {
                            if (TryConvert(object_Temp, out object? @object_Converted, elementType))
                            {
                                methodInfo.Invoke(enumerable, [@object_Converted]);
                            }
                        }
                        result = (IEnumerable)enumerable;
                        return true;
                    }
                    else
                    {
                        if (TryConvert(@object, out object? @object_Converted, elementType))
                        {
                            methodInfo.Invoke(enumerable, [@object_Converted]);
                            result = (IEnumerable)enumerable;
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable float.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted float, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Float(object @object, out float? result)
        {
            result = null;

            if (@object is null || @object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (TryParseDouble(@string, out double @double))
                {
                    result = System.Convert.ToSingle(@double);
                    return true;
                }
            }
            else if (IsNumeric(@object) && @object is not System.Type)
            {
                result = System.Convert.ToSingle(@object);
                return true;
            }
            else if (@object is bool @bool)
            {
                float @float = 0;
                if (@bool)
                    @float = 1;

                result = @float;
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<float>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out float @float))
                        {
                            result = @float;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetSingle(out float floatVal))
                {
                    result = floatVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Float(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable <see cref="Guid"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted Guid, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Guid(object @object, out Guid? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (Guid.TryParse(@string, out Guid guid))
                {
                    result = guid;
                    return true;
                }
            }

            if (@object is JsonNode jsonNode)
            {
                if (jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.String)
                {
                    if (Guid.TryParse(jsonNode.GetValue<string>(), out Guid guid))
                    {
                        result = guid;
                        return true;
                    }
                }
            }

            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && jsonElement.TryGetGuid(out Guid guidVal))
                {
                    result = guidVal;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable int.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted int, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Int(object @object, out int? result)
        {
            result = null;

            if (@object is string s && int.TryParse(s, out int i))
            {
                result = i;
                return true;
            }

            if (@object is Enum @enum)
            {
                result = System.Convert.ToInt32(@enum);
                return true;
            }

            if (IsNumeric(@object))
            {
                result = System.Convert.ToInt32(@object);
                return true;
            }

            if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<int>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Int(jsonNode.GetValue<string>(), out int? @int))
                        {
                            result = @int;
                            return true;
                        }
                        break;
                }
            }

            // Added: Support for JsonElement
            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetInt32(out int intVal))
                {
                    result = intVal;
                    return true;
                }

                if (jsonElement.GetString() is not string value)
                {
                    return false;
                }

                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && TryConvert_Int(value, out int? stringInt))
                {
                    result = stringInt;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a <see cref="JsonNode"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted JsonNode, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_JsonNode(object @object, out JsonNode? result)
        {
            result = default;

            if (@object is string @string)
            {
                try
                {
                    result = JsonNode.Parse(@string);
                    return true;
                }
                catch (System.Text.Json.JsonException)
                {
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable long.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted long, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Long(object @object, out long? result)
        {
            result = null;

            if (@object is string @string && long.TryParse(@string, out long @long))
            {
                result = @long;
                return true;
            }
            else if (@object is Enum @enum)
            {
                result = System.Convert.ToInt64(@enum);
                return true;
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToInt64(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<long>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Long(jsonNode.GetValue<string>(), out long? @long_Temp))
                        {
                            result = @long_Temp;
                            return true;
                        }
                        break;
                }
            }

            // Added: Support for JsonElement
            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetInt64(out long longVal))
                {
                    result = longVal;
                    return true;
                }

                if (jsonElement.GetString() is not string value)
                {
                    return false;
                }

                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && TryConvert_Long(value, out long? stringLong))
                {
                    result = stringLong;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an <see cref="ISerializableObject"/> of the specified type.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted ISerializableObject, or null if conversion failed.</param>
        /// <param name="type">The target ISerializableObject type.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_SerializableObject(object @object, out ISerializableObject? result, Type type)
        {
            result = null;

            object? @object_Temp = @object;

            if (@object is JsonElement jsonElement)
            {
                @object_Temp = jsonElement.GetRawText();
            }

            Type? type_Object = @object_Temp?.GetType();
            if (type == null)
            {
                return false;
            }

            if (type_Object == type)
            {
                result = (ISerializableObject)@object_Temp!;
                return true;
            }

            if (@object_Temp is string @string)
            {
                List<ISerializableObject>? serializableObjects = Convert.ToDiGi<ISerializableObject>(@string);
                if (serializableObjects != null && serializableObjects.Count != 0)
                {
                    ISerializableObject serializableObject = serializableObjects.Find(x => x != null && type.IsAssignableFrom(x.GetType()));
                    if (serializableObject != null)
                    {
                        result = serializableObject;
                        return true;
                    }
                }
                else if (typeof(Classes.Color).IsAssignableFrom(type))
                {
                    if (int.TryParse(@string, out int int_color))
                    {
                        result = new Classes.Color(Convert.ToDrawing(int_color));
                        return true;
                    }
                    else
                    {
                        string value = @string;
                        if (!string.IsNullOrWhiteSpace(value) && value.Contains(","))
                        {
                            string[] values = value.Split(',');
                            if (values.Length == 3)
                            {
                                if (int.TryParse(values[0], out int r) && int.TryParse(values[1], out int g) && int.TryParse(values[2], out int b))
                                {
                                    result = new Classes.Color(System.Drawing.Color.FromArgb(r, g, b));
                                    return true;
                                }
                            }
                            else if (values.Length == 4)
                            {
                                if (int.TryParse(values[0], out int a) && int.TryParse(values[1], out int r) && int.TryParse(values[2], out int g) && int.TryParse(values[3], out int b))
                                {
                                    result = new Classes.Color(System.Drawing.Color.FromArgb(a, r, g, b));
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            if (type_Object == typeof(Classes.Color))
            {
                System.Drawing.Color color = System.Drawing.Color.Empty;
                if (TryConvert(@object_Temp, out color))
                {
                    if (color == System.Drawing.Color.Empty)
                    {
                        result = default;
                        return true;
                    }

                    result = new Classes.Color(color);
                    return true;
                }
            }

            if (type_Object == typeof(System.Drawing.Color))
            {
                result = new Classes.Color((System.Drawing.Color)@object_Temp!);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable short.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted short, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Short(object @object, out short? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (short.TryParse(@string, out short @short))
                {
                    result = @short;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToInt16(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<short>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Short(jsonNode.GetValue<string>(), out short? @short_Temp))
                        {
                            result = @short_Temp;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetInt16(out short shortVal))
                {
                    result = shortVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Short(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable string.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted string, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_String(this object? @object, out string? result)
        {
            if (@object is null)
            {
                result = null;
                return true;
            }

            if (@object is ISerializableObject serializable)
            {
                result = serializable.ToJsonObject()?.ToString();
                return true;
            }

            if (@object is JsonNode jsonNode)
            {
                result = jsonNode.GetValue<string>();
                return true;
            }

            if (@object is JsonElement jsonElement)
            {
                result = jsonElement.ValueKind == System.Text.Json.JsonValueKind.String ? jsonElement.GetString() : jsonElement.GetRawText();
                return true;
            }

            result = @object?.ToString();
            return true;
        }

        /// <summary>
        /// Attempts to convert the specified object to a <see cref="TimeSpan"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted TimeSpan value if successful; otherwise, the default value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_TimeSpan(object @object, out TimeSpan? result)
        {
            result = default;

            if (@object == null)
            {
                return false;
            }

            if (@object is TimeSpan timeSpan_Val)
            {
                result = timeSpan_Val;
                return true;
            }

            if (@object is string @string)
            {
                if (TimeSpan.TryParse(@string, out TimeSpan timeSpan))
                {
                    result = timeSpan;
                    return true;
                }
            }

            if (@object is JsonNode jsonNode)
            {
                if (jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.String)
                {
                    if (TimeSpan.TryParse(jsonNode.GetValue<string>(), out TimeSpan timeSpan))
                    {
                        result = timeSpan;
                        return true;
                    }
                }
            }

            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (TimeSpan.TryParse(jsonElement.GetString(), out TimeSpan timeSpan))
                    {
                        result = timeSpan;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a <see cref="System.Type"/>.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted Type value if successful; otherwise, the default value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Type(object @object, out Type? result)
        {
            result = default;

            if (@object is Type type_Val)
            {
                result = type_Val;
                return true;
            }

            if (@object is string @string && !string.IsNullOrWhiteSpace(@string))
            {
                result = System.Type.GetType(@string);
                return true;
            }

            if (@object is JsonNode jsonNode)
            {
                if (jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.String)
                {
                    string? string_Type = jsonNode.GetValue<string>();
                    if (!string.IsNullOrWhiteSpace(string_Type))
                    {
                        result = System.Type.GetType(string_Type);
                        return true;
                    }
                }
            }

            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    string? string_Type = jsonElement.GetString();
                    if (!string.IsNullOrWhiteSpace(string_Type))
                    {
                        result = System.Type.GetType(string_Type);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an unsigned integer (uint).
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted uint value if successful; otherwise, the default value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Uint(object @object, out uint? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (uint.TryParse(@string, out uint @uint))
                {
                    result = @uint;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToUInt32(@object);
                return true;
            }
            else if (@object is Classes.Color color)
            {
                result = System.Convert.ToUInt32(color.Value);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<uint>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Uint(jsonNode.GetValue<string>(), out uint? @uint))
                        {
                            result = @uint;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetUInt32(out uint uintVal))
                {
                    result = uintVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Uint(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an unsigned long (ulong).
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted ulong value if successful; otherwise, the default value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Ulong(object @object, out ulong? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (ulong.TryParse(@string, out ulong @ulong))
                {
                    result = @ulong;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToUInt64(@object);
                return true;
            }
            else if (@object is Enum)
            {
                result = (ulong)@object;
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<ulong>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert(jsonNode.GetValue<string>(), out ulong @ulong))
                        {
                            result = @ulong;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetUInt64(out ulong ulongVal))
                {
                    result = ulongVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Ulong(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to an unsigned short (ushort).
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted ushort value if successful; otherwise, the default value.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Ushort(object @object, out ushort? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (ushort.TryParse(@string, out ushort @ushort))
                {
                    result = @ushort;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToUInt16(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<ushort>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Ushort(jsonNode.GetValue<string>(), out ushort? @ushort))
                        {
                            result = @ushort;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetUInt16(out ushort @ushort))
                {
                    result = @ushort;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Ushort(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable DateTimeOffset.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted DateTimeOffset, or null if conversion failed.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_DateTimeOffset(object @object, out DateTimeOffset? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is DateTimeOffset dateTimeOffset)
            {
                result = dateTimeOffset;
                return true;
            }

            if (@object is DateTime dateTime)
            {
                result = new DateTimeOffset(dateTime);
                return true;
            }

            if (@object is string @string)
            {
                if (DateTimeOffset.TryParse(@string, out DateTimeOffset dateTimeOffset_Parsed))
                {
                    result = dateTimeOffset_Parsed;
                    return true;
                }
            }

            if (@object is JsonNode jsonNode)
            {
                if (jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.String)
                {
                    if (DateTimeOffset.TryParse(jsonNode.GetValue<string>(), out DateTimeOffset dateTimeOffset_Parsed))
                    {
                        result = dateTimeOffset_Parsed;
                        return true;
                    }
                }
            }

            if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String && jsonElement.TryGetDateTimeOffset(out DateTimeOffset dateTimeOffset_Parsed))
                {
                    result = dateTimeOffset_Parsed;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable sbyte.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted sbyte value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Sbyte(object @object, out sbyte? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is string @string)
            {
                if (sbyte.TryParse(@string, out sbyte sby))
                {
                    result = sby;
                    return true;
                }
            }
            else if (IsNumeric(@object))
            {
                result = System.Convert.ToSByte(@object);
                return true;
            }
            else if (@object is JsonNode jsonNode)
            {
                switch (jsonNode.GetValueKind())
                {
                    case System.Text.Json.JsonValueKind.Number:
                        result = jsonNode.GetValue<sbyte>();
                        return true;

                    case System.Text.Json.JsonValueKind.String:
                        if (TryConvert_Sbyte(jsonNode.GetValue<string>(), out sbyte? sby_Temp))
                        {
                            result = sby_Temp;
                            return true;
                        }
                        break;
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.Number && jsonElement.TryGetSByte(out sbyte sbyVal))
                {
                    result = sbyVal;
                    return true;
                }
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (jsonElement.GetString() is not string value)
                    {
                        return false;
                    }

                    return TryConvert_Sbyte(value, out result);
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to convert the specified object to a nullable char.
        /// </summary>
        /// <param name="object">The object to convert.</param>
        /// <param name="result">When this method returns, contains the converted char value if successful; otherwise, null.</param>
        /// <returns>True if the conversion was successful; otherwise, false.</returns>
        public static bool TryConvert_Char(object @object, out char? result)
        {
            result = null;

            if (@object == null)
            {
                return false;
            }

            if (@object is Type)
            {
                return false;
            }

            if (@object is char ch)
            {
                result = ch;
                return true;
            }

            if (@object is string @string)
            {
                if (char.TryParse(@string, out char ch_Val))
                {
                    result = ch_Val;
                    return true;
                }
            }
            else if (@object is JsonNode jsonNode)
            {
                if (jsonNode.GetValueKind() == System.Text.Json.JsonValueKind.String)
                {
                    if (char.TryParse(jsonNode.GetValue<string>(), out char ch_Val))
                    {
                        result = ch_Val;
                        return true;
                    }
                }
            }
            else if (@object is JsonElement jsonElement)
            {
                if (jsonElement.ValueKind == System.Text.Json.JsonValueKind.String)
                {
                    if (char.TryParse(jsonElement.GetString(), out char ch_Val))
                    {
                        result = ch_Val;
                        return true;
                    }
                }
            }

            return false;
        }
    }
}