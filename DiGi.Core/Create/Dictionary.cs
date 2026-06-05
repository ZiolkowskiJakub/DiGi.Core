using System;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a dictionary instance with the specified key and value types.</summary>
        /// <param name="key">The type of keys in the dictionary.</param>
        /// <param name="value">The type of values in the dictionary.</param>
        /// <returns>An <see cref="IDictionary"/> instance created with the specified types, or null.</returns>
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