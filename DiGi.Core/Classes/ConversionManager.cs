using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Caches and retrieves reflection data (MethodInfo) for type conversion methods.
    /// </summary>
    public class ConversionManager
    {
        private readonly Dictionary<string, MethodInfo> dictionary = [];

        public ConversionManager()
        {
        }

        /// <summary>
        /// Retrieves the <see cref="MethodInfo"/> for the specified type.
        /// </summary>
        /// <param name="type">The type to get the method info for.</param>
        /// <param name="update">If set to <c>true</c>, updates the internal cache if the method info is not found.</param>
        /// <returns>The <see cref="MethodInfo"/> if found; otherwise, <c>null</c>.</returns>
        public MethodInfo? GetMethodInfo(Type? type, bool update = true)
        {
            if (type == null)
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return GetMethodInfo(fullTypeName, update);
        }

        /// <summary>
        /// Retrieves the <see cref="MethodInfo"/> for the specified full type name.
        /// </summary>
        /// <param name="fullTypeName">The full name of the type to get the method info for.</param>
        /// <param name="update">If set to <c>true</c>, updates the internal cache if the method info is not found.</param>
        /// <returns>The <see cref="MethodInfo"/> if found; otherwise, <c>null</c>.</returns>
        public MethodInfo? GetMethodInfo(string? fullTypeName, bool update = true)
        {
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            if (dictionary.TryGetValue(fullTypeName!, out MethodInfo? result))
            {
                return result;
            }

            if (!update)
            {
                return null;
            }

            Type? type = Query.Type(fullTypeName);
            if (type == null)
            {
                return null;
            }

            result = type.GetMethod("Add");
            if (result != null)
            {
                lock (dictionary)
                {
                    dictionary[fullTypeName!] = result;
                }
            }

            return result;
        }
    }
}