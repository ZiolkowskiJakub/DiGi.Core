using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to find the first key in the dictionary whose transformed value matches the transformed text.
        /// </summary>
        /// <typeparam name="T">The type of the dictionary values.</typeparam>
        /// <param name="dictionary">The dictionary to search.</param>
        /// <param name="text">The text to match against.</param>
        /// <param name="key">When this method returns, contains the first matching key, or null if not found.</param>
        /// <param name="func">An optional transformation function applied to both the text and dictionary keys before comparison.</param>
        /// <returns>True if a matching key was found; otherwise, false.</returns>
        public static bool TryGetFirstKey<T>(this IDictionary<string, T>? dictionary, string? text, out string? key, Func<string?, string?>? func = null)
        {
            key = null;

            if (dictionary is null || func is null)
            {
                return false;
            }

            string? text_Temp = func.Invoke(text);

            foreach (KeyValuePair<string, T> keyValuePair in dictionary)
            {
                string? key_Temp = func.Invoke(keyValuePair.Key);
                if (text_Temp == key_Temp)
                {
                    key = key_Temp;
                    return true;
                }
            }

            return false;
        }
    }
}