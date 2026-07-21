using System.Text;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Reverses <see cref="Escaped(string?)"/>, turning a reference segment back into its scalar value.
        /// </summary>
        /// <param name="value">The escaped segment.</param>
        /// <returns>
        /// The original scalar value; null when <paramref name="value"/> is null or is the
        /// <see cref="Constants.Reference.Null"/> token. A trailing lone escape character is malformed and also
        /// yields null.
        /// </returns>
        public static string? Unescaped(this string? value)
        {
            if (value == null || value == Constants.Reference.Null)
            {
                return null;
            }

            if (value.Length == 0)
            {
                return string.Empty;
            }

            StringBuilder stringBuilder = new(value.Length);

            for (int i = 0; i < value.Length; i++)
            {
                char @char = value[i];

                if (@char != Constants.Reference.Escape[0])
                {
                    stringBuilder.Append(@char);
                    continue;
                }

                i++;
                if (i >= value.Length)
                {
                    return null;
                }

                stringBuilder.Append(value[i]);
            }

            return stringBuilder.ToString();
        }
    }
}