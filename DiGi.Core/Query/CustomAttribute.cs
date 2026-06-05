using System;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Optimized retrieval of a custom attribute from an Enum value.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="enum">The enum value to search for the attribute.</param>
        /// <returns>The specified attribute if found; otherwise, null.</returns>
        public static TAttribute? CustomAttribute<TAttribute>(Enum? @enum) where TAttribute : Attribute
        {
            if (@enum is null)
            {
                return default;
            }

            Type type = @enum.GetType();
            // Enum.GetName is more efficient than .ToString() as it avoids some string formatting overhead
            string? name = System.Enum.GetName(type, @enum);

            if (name is null)
            {
                return default;
            }

            // GetField is more specific than GetMember, which reduces search time in the metadata table
            FieldInfo? fieldInfo = type.GetField(name, BindingFlags.Public | BindingFlags.Static);

            return fieldInfo?.GetCustomAttribute<TAttribute>(false);
        }

        /// <summary>
        /// Optimized retrieval of a custom attribute from a Type and member name.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="type">The type containing the member.</param>
        /// <param name="text">The name of the member from which to retrieve the attribute.</param>
        /// <returns>The specified attribute if found; otherwise, null.</returns>
        public static TAttribute? CustomAttribute<TAttribute>(Type? type, string? text) where TAttribute : Attribute
        {
            if (type is null || string.IsNullOrEmpty(text))
            {
                return default;
            }

            // Narrowing the search to Public Static/Instance members avoids unnecessary metadata scanning
            MemberInfo[] memberInfos = type.GetMember(text, BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance);

            if (memberInfos.Length == 0)
            {
                return default;
            }

            // Directly using the extension method from System.Reflection
            return memberInfos[0].GetCustomAttribute<TAttribute>(false);
        }

        /// <summary>
        /// Efficiently retrieves a custom attribute from MemberInfo using generic reflection extensions.
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="memberInfo">The member information to search for the attribute.</param>
        /// <returns>The specified attribute if found; otherwise, null.</returns>
        public static TAttribute? CustomAttribute<TAttribute>(this MemberInfo? memberInfo) where TAttribute : Attribute
        {
            if (memberInfo is null)
            {
                return default;
            }

            // .GetCustomAttribute<T>() is significantly faster than .GetCustomAttributes()
            // because it doesn't allocate an array if only one attribute is found.
            // It uses an internal optimized path in the CLR.
            return memberInfo.GetCustomAttribute<TAttribute>(false);
        }

        /// <summary>
        /// Retrieves an attribute from the Type level (e.g., for CategoryAttribute on Enum declaration).
        /// </summary>
        /// <typeparam name="TAttribute">The type of the attribute to retrieve.</typeparam>
        /// <param name="type">The type from which to retrieve the attribute.</param>
        /// <returns>The specified attribute if found; otherwise, null.</returns>
        public static TAttribute? CustomTypeAttribute<TAttribute>(Type? type) where TAttribute : Attribute
        {
            if (type is null)
            {
                return default;
            }

            return CustomAttribute<TAttribute>(type);
        }
    }
}