using DiGi.Core.Classes;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates an object path from the given text.</summary>
        /// <param name="text">The text to be converted into an object path.</param>
        /// <returns>An <see cref="ObjectPath"/> if successful; otherwise, <c>null</c>.</returns>
        public static ObjectPath? ObjectPath(string? text)
        {
            List<string>? names = Query.QuotedStrings(text, Classes.ObjectPath.Separator);
            if (names == null)
            {
                return null;
            }

            return new ObjectPath(names);
        }
    }
}