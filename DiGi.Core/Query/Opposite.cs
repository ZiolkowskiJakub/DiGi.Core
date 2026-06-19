using DiGi.Core.Enums;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the opposite of the specified <see cref="NumberComparisonType"/>.
        /// </summary>
        /// <param name="numberComparisonType">The number comparison type.</param>
        /// <returns>The opposite <see cref="NumberComparisonType"/>.</returns>
        public static NumberComparisonType Opposite(this NumberComparisonType numberComparisonType)
        {
            return numberComparisonType switch
            {
                NumberComparisonType.Equals => NumberComparisonType.NotEquals,
                NumberComparisonType.NotEquals => NumberComparisonType.Equals,
                NumberComparisonType.Greater => NumberComparisonType.LessOrEquals,
                NumberComparisonType.LessOrEquals => NumberComparisonType.Greater,
                NumberComparisonType.Less => NumberComparisonType.GreaterOrEquals,
                NumberComparisonType.GreaterOrEquals => NumberComparisonType.Less,
                _ => throw new ArgumentOutOfRangeException(nameof(numberComparisonType), numberComparisonType, null)
            };
        }

        /// <summary>
        /// Gets the opposite of the specified <see cref="TextComparisonType"/>.
        /// </summary>
        /// <param name="textComparisonType">The text comparison type.</param>
        /// <returns>The opposite <see cref="TextComparisonType"/>.</returns>
        public static TextComparisonType Opposite(this TextComparisonType textComparisonType)
        {
            return textComparisonType switch
            {
                TextComparisonType.Equals => TextComparisonType.NotEquals,
                TextComparisonType.NotEquals => TextComparisonType.Equals,
                TextComparisonType.Contains => TextComparisonType.NotContains,
                TextComparisonType.NotContains => TextComparisonType.Contains,
                TextComparisonType.StartsWith => TextComparisonType.NotStartsWith,
                TextComparisonType.NotStartsWith => TextComparisonType.StartsWith,
                TextComparisonType.EndsWith => TextComparisonType.NotEndsWith,
                TextComparisonType.NotEndsWith => TextComparisonType.EndsWith,
                _ => throw new ArgumentOutOfRangeException(nameof(textComparisonType), textComparisonType, null)
            };
        }
    }
}