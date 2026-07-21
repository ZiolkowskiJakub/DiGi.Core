namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Splits a reference string into its discriminator and its body at the first unescaped
        /// <see cref="Constants.Reference.Separator"/> at nesting depth zero.
        /// <para>The discriminator is either a <see cref="Constants.Reference.Kind"/> token or an assembly-qualified
        /// full type name; the two are told apart by the comma a full type name always contains and a kind token
        /// never does. This method does not validate the discriminator - a caller must resolve it to know whether it
        /// names a reference type at all.</para>
        /// </summary>
        /// <param name="value">The reference string.</param>
        /// <param name="discriminator">When this method returns, contains the discriminator; otherwise, null.</param>
        /// <param name="body">
        /// When this method returns, contains everything after the first separator, or null when the string has no
        /// separator and is therefore a bare discriminator.
        /// </param>
        /// <returns>True if a discriminator was extracted; otherwise, false.</returns>
        public static bool TryGetDiscriminator(this string? value, out string? discriminator, out string? body)
        {
            discriminator = null;
            body = null;

            if (string.IsNullOrEmpty(value))
            {
                return false;
            }

            int depth = 0;

            for (int i = 0; i < value!.Length; i++)
            {
                char @char = value[i];

                if (@char == Constants.Reference.Escape[0])
                {
                    i++;
                    continue;
                }

                if (@char == Constants.Reference.NestingStart[0])
                {
                    depth++;
                    continue;
                }

                if (@char == Constants.Reference.NestingEnd[0])
                {
                    depth--;
                    continue;
                }

                if (depth != 0 || !IsSeparator(value, i))
                {
                    continue;
                }

                discriminator = value.Substring(0, i);
                body = value.Substring(i + Constants.Reference.Separator.Length);

                return !string.IsNullOrEmpty(discriminator);
            }

            discriminator = value;

            return true;
        }
    }
}