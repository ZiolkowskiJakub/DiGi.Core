using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to parse the specified string into an <see cref="IReference"/>.
        /// <para>The string's discriminator names exactly one reference type, so the result is the same type that
        /// produced the string. Types defined outside DiGi.Core resolve too, provided their assembly is loaded.</para>
        /// <para>Strings written before the discriminator was introduced are still accepted, via
        /// <see cref="TryParseLegacy(string?, out IReference?)"/>.</para>
        /// </summary>
        /// <param name="value">The string to parse.</param>
        /// <param name="reference">When this method returns, contains the parsed reference; otherwise, null.</param>
        /// <returns>True if the string was successfully parsed; otherwise, false.</returns>
        public static bool TryParse(this string? value, out IReference? reference)
        {
            reference = default;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (TryGetDiscriminator(value, out string? discriminator, out string? body))
            {
                // Resolution, not shape, is what separates a discriminator from a legacy string: a legacy reference
                // opens with its target's full type name, which looks exactly like the full-type-name discriminator
                // form. Only a type that is an IReference AND has a factory is a real discriminator.
                ReferenceConstructor? referenceConstructor = Settings.ReferenceManager.GetReferenceConstructor(discriminator);
                if (referenceConstructor != null)
                {
                    List<string>? segments = Segments(body);

                    reference = referenceConstructor.Create(segments?.ConvertAll(x => (string?)x));

                    return reference != null;
                }
            }

            // TODO [ReferenceFormat]: remove this call together with Query/TryParseLegacy.cs, once every storage
            // archive has been regenerated in the current reference format.
            return TryParseLegacy(value, out reference);
        }

        /// <summary>
        /// Attempts to parse the specified string into a reference of the requested type.
        /// </summary>
        /// <typeparam name="UReference">The type of reference to parse.</typeparam>
        /// <param name="value">The string to parse.</param>
        /// <param name="reference">When this method returns, contains the parsed reference; otherwise, null.</param>
        /// <returns>True if the string was successfully parsed into the requested type; otherwise, false.</returns>
        public static bool TryParse<UReference>(this string? value, out UReference? reference) where UReference : IReference
        {
            reference = default;

            if (!TryParse(value, out IReference? reference_Temp))
            {
                return false;
            }

            if (reference_Temp is UReference uReference_Temp)
            {
                reference = uReference_Temp;
                return true;
            }

            return false;
        }
    }
}