using System;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a list instance of the specified type.</summary>
        /// <param name="type">The type of elements in the list.</param>
        /// <returns>A new <see cref="IList"/> instance, or null if the operation fails.</returns>
        public static IList? List(Type? type)
        {
            if (type is null)
            {
                return null;
            }

            return (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType([type]));
        }
    }
}