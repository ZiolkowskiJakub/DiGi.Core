using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetFirstKey<T>(this IDictionary<string, T>? dictionary, string? text, out string? key, Func<string?, string?>? func = null)
        {
            key = null;

            if(dictionary is null || func is null)
            {
                return false;
            }

            string? text_Temp = func.Invoke(text); 

            foreach(KeyValuePair<string, T> keyValuePair in dictionary)
            {
                string? key_Temp = func.Invoke(keyValuePair.Key);
                if(text_Temp == key_Temp)
                {
                    key = key_Temp;
                    return true;
                }
            }

            return false;
        }
    }
}