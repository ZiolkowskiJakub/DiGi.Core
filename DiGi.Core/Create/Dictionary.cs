using System;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a dictionary instance with the specified key and value types.</summary>
        public static IDictionary? Dictionary(Type? key, Type? value)
        {
            if (key == null || value == null)
            {
                return null;
            }

            return (IDictionary)Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType([key, value]));
        }
    }
}