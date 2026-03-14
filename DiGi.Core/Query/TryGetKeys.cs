using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetKeys<T>(this IDictionary<string, T>? dictionary, string? text, out List<string>? keys, Func<string?, string?>? func = null)
        {
            keys = null;

            if(dictionary is null || func is null)
            {
                return false;
            }

            string? text_Temp = func.Invoke(text); 

            keys = new List<string>();
            foreach(KeyValuePair<string, T> keyValuePair in dictionary)
            {
                string? key = func.Invoke(keyValuePair.Key);
                if(text_Temp == key)
                {
                    keys.Add(keyValuePair.Key);
                }
            }

            return keys is not null && keys.Count > 0;
        }
    }
}