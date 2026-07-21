using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Renders a scalar value as a segment of a reference string.
        /// </summary>
        /// <param name="value">The scalar value.</param>
        /// <returns>The escaped segment, or <see cref="Constants.Reference.Null"/> when <paramref name="value"/> is null.</returns>
        public static string Segment(this string? value)
        {
            return Escaped(value);
        }

        /// <summary>
        /// Renders a nested reference as a segment of a reference string, wrapped in the nesting delimiters so that
        /// the segment stays self-contained and the enclosing string can be split without knowing the nested type.
        /// </summary>
        /// <param name="reference">The reference to nest.</param>
        /// <returns>
        /// The nested segment, <see cref="Constants.Reference.Null"/> when <paramref name="reference"/> is null, or
        /// when the reference renders to null.
        /// </returns>
        public static string Segment(this IReference? reference)
        {
            string? value = reference?.ToString();
            if (value == null)
            {
                return Constants.Reference.Null;
            }

            return string.Concat(Constants.Reference.NestingStart, value, Constants.Reference.NestingEnd);
        }
    }
}