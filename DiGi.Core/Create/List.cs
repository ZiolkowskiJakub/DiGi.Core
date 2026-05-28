using System;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a list instance of the specified type.</summary>
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