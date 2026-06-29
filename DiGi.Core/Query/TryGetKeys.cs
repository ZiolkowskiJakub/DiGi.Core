using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to find all keys in the dictionary whose transformed value matches the transformed text.
        /// </summary>
        /// <typeparam name="T">The type of the dictionary values.</typeparam>
        /// <param name="dictionary">The dictionary to search.</param>
        /// <param name="text">The text to match against.</param>
        /// <param name="keys">When this method returns, contains a list of all matching keys, or null if none were found.</param>
        /// <param name="func">An optional transformation function applied to both the text and dictionary keys before comparison.</param>
        /// <returns>True if one or more matching keys were found; otherwise, false.</returns>
        public static bool TryGetKeys<T>(this IDictionary<string, T>? dictionary, string? text, out List<string>? keys, Func<string?, string?>? func = null)
        {
            keys = null;

            if (dictionary is null || func is null)
            {
                return false;
            }

            string? text_Temp = func.Invoke(text);

            keys = new List<string>();
            foreach (KeyValuePair<string, T> keyValuePair in dictionary)
            {
                string? key = func.Invoke(keyValuePair.Key);
                if (text_Temp == key)
                {
                    keys.Add(keyValuePair.Key);
                }
            }

            return keys.Count > 0;
        }
    }
}