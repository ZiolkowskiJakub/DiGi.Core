using System;
using System.Collections;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static IList List(Type type)
        {
            if (type == null)
            {
                return null;
            }

            return (IList)Activator.CreateInstance(typeof(List<>).MakeGenericType(new[] { type }));
        }
    }
}