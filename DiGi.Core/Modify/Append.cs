using System;
using System.Text;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Appends the full, formatted type name of a Type to the StringBuilder.
        /// </summary>
        /// <param name="stringBuilder">The StringBuilder to append to.</param>
        /// <param name="type">The Type to format and append.</param>
        public static void Append(this StringBuilder? stringBuilder, Type? type)
        {
            if (stringBuilder == null || type == null)
            {
                return;
            }

            if (type.IsGenericType)
            {
                stringBuilder.Append(type.Namespace).Append('.').Append(type.Name);

                Type[] types_Generic = type.GetGenericArguments();
                if (types_Generic != null && types_Generic.Length > 0)
                {
                    stringBuilder.Append('[');
                    for (int i = 0; i < types_Generic.Length; i++)
                    {
                        if (i > 0)
                        {
                            stringBuilder.Append(',');
                        }

                        stringBuilder.Append('[');
                        Append(stringBuilder, types_Generic[i]);
                        stringBuilder.Append(']');
                    }
                    stringBuilder.Append(']');
                }
            }
            else
            {
                stringBuilder.Append(type.FullName);
            }

            stringBuilder.Append(',');
            string assemblyFullName = type.Assembly.FullName;
            int commaIndex = assemblyFullName.IndexOf(',');
            if (commaIndex > 0)
            {
                stringBuilder.Append(assemblyFullName, 0, commaIndex);
            }
            else
            {
                stringBuilder.Append(assemblyFullName);
            }
        }
    }
}
