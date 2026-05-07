using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Core.Classes
{
    public class ConversionManager
    {
        private readonly Dictionary<string, MethodInfo> dictionary = [];

        public ConversionManager()
        {
        }

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