using System.Collections.Generic;
using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Splits the body of a reference string - everything after the discriminator - into its segments.
        /// <para>Splits only on an unescaped <see cref="Constants.Reference.Separator"/> at nesting depth zero, so a
        /// separator inside an escaped payload or inside a nested reference never splits. Empty segments are
        /// preserved: an empty segment means <see cref="string.Empty"/> and is distinct from
        /// <see cref="Constants.Reference.Null"/>.</para>
        /// </summary>
        /// <param name="body">The body of a reference string.</param>
        /// <returns>
        /// The segments in order; null when <paramref name="body"/> is null or malformed - unbalanced nesting
        /// delimiters, or a trailing lone escape character.
        /// </returns>
        public static List<string>? Segments(this string? body)
        {
            if (body == null)
            {
                return null;
            }

            List<string> result = [];

            StringBuilder stringBuilder = new(body.Length);
            int depth = 0;

            for (int i = 0; i < body.Length; i++)
            {
                char @char = body[i];

                if (@char == Constants.Reference.Escape[0])
                {
                    i++;
                    if (i >= body.Length)
                    {
                        return null;
                    }

                    stringBuilder.Append(@char);
                    stringBuilder.Append(body[i]);
                    continue;
                }

                if (@char == Constants.Reference.NestingStart[0])
                {
                    depth++;
                    stringBuilder.Append(@char);
                    continue;
                }

                if (@char == Constants.Reference.NestingEnd[0])
                {
                    depth--;
                    if (depth < 0)
                    {
                        return null;
                    }

                    stringBuilder.Append(@char);
                    continue;
                }

                if (depth == 0 && IsSeparator(body, i))
                {
                    result.Add(stringBuilder.ToString());
                    stringBuilder.Clear();
                    i += Constants.Reference.Separator.Length - 1;
                    continue;
                }

                stringBuilder.Append(@char);
            }

            if (depth != 0)
            {
                return null;
            }

            result.Add(stringBuilder.ToString());

            return result;
        }

        /// <summary>
        /// Determines whether an unescaped <see cref="Constants.Reference.Separator"/> starts at the specified index.
        /// <para>The caller is responsible for having consumed any escape sequences before this index, so the
        /// character at <paramref name="index"/> is known to be unescaped.</para>
        /// </summary>
        /// <param name="value">The string to inspect.</param>
        /// <param name="index">The index to test.</param>
        /// <returns>True if the separator starts at the specified index; otherwise, false.</returns>
        public static bool IsSeparator(this string? value, int index)
        {
            if (value == null || index < 0 || index + Constants.Reference.Separator.Length > value.Length)
            {
                return false;
            }

            for (int i = 0; i < Constants.Reference.Separator.Length; i++)
            {
                if (value[index + i] != Constants.Reference.Separator[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
