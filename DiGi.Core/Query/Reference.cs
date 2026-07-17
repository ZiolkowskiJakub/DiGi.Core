using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Reverses <see cref="Segment(IReference?)"/>, turning a nested segment back into a reference by stripping
        /// one nesting layer and parsing the content.
        /// </summary>
        /// <param name="segment">The nested segment, including its enclosing nesting delimiters.</param>
        /// <returns>
        /// The reference; null when <paramref name="segment"/> is null, is <see cref="Constants.Reference.Null"/>,
        /// is not a nested segment, or does not parse.
        /// </returns>
        public static IReference? Reference(this string? segment)
        {
            if (string.IsNullOrEmpty(segment) || segment == Constants.Reference.Null)
            {
                return null;
            }

            if (!segment!.StartsWith(Constants.Reference.NestingStart, StringComparison.Ordinal)
                || !segment.EndsWith(Constants.Reference.NestingEnd, StringComparison.Ordinal))
            {
                return null;
            }

            string value = segment.Substring(
                Constants.Reference.NestingStart.Length,
                segment.Length - Constants.Reference.NestingStart.Length - Constants.Reference.NestingEnd.Length);

            if (!TryParse(value, out IReference? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Reverses <see cref="Segment(IReference?)"/> and narrows the result to the requested reference type.
        /// </summary>
        /// <typeparam name="TReference">The expected reference type.</typeparam>
        /// <param name="segment">The nested segment, including its enclosing nesting delimiters.</param>
        /// <returns>The reference when it parses and is of the requested type; otherwise, the default value.</returns>
        public static TReference? Reference<TReference>(this string? segment) where TReference : IReference
        {
            if (Reference(segment) is TReference result)
            {
                return result;
            }

            return default;
        }
    }
}
