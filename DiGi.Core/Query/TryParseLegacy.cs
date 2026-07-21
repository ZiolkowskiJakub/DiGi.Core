using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;

// TODO [ReferenceFormat]: Remove this file and its single call site in Query/TryParse.cs once every storage archive
// has been regenerated in the current reference format.
//
// WHY THIS EXISTS
// Reference strings are on-disk keys, not just display text: Query.Encode(uniqueReference) is the ZIP entry name
// inside a storage file (DiGi.Core.IO/File/Classes/StorageFile.cs), and reference strings are persisted into
// WrapperMetadata.References. Archives written before the discriminator was introduced still hold the old strings.
// Without this fallback those entries simply would not be found, and such an archive would read back EMPTY - with no
// error, because a missing entry is not an error.
//
// WHAT THE OLD FORMAT LOOKED LIKE
// The type was encoded by SHAPE rather than by a discriminator, and nothing was escaped:
//     TypeReference      DiGi.GIS.Classes.Building2D,DiGi.GIS
//     GuidReference      DiGi.GIS.Classes.Building2D,DiGi.GIS::0f8fad5bd9cb469fa16570867728950e
//     UniqueIdReference  DiGi.GIS.Classes.Building2D,DiGi.GIS::"BLD-001"
// Those three are the only types this needs to handle, because Encode only ever accepted a UniqueReference. They are
// mutually unambiguous: quoted means a unique identifier, a bare parsable GUID means a GUID, neither means a type.
//
// LIMITS - these are properties of the old format and cannot be fixed here
//   - A uniqueId containing "::" or a leading/trailing quote was already unrecoverable when it was written.
//   - Property and external references were already ambiguous with each other and are not attempted.
//
// THIS IS READ-ONLY. Nothing writes the old format; Query.TryParse always emits the current one. Nothing else in the
// codebase may reference the old grammar - keeping it in this one file is what makes the removal a deletion.
namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to parse a reference string written in the format used before discriminators were introduced.
        /// <para>Read-only compatibility for pre-existing storage archives. See the file header for the format, its
        /// limits, and the conditions for deleting this method.</para>
        /// </summary>
        /// <param name="value">The legacy string to parse.</param>
        /// <param name="reference">When this method returns, contains the parsed reference; otherwise, null.</param>
        /// <returns>True if the string was successfully parsed; otherwise, false.</returns>
        public static bool TryParseLegacy(this string? value, out IReference? reference)
        {
            reference = default;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            // The old format had no escaping, so a plain split is exactly what wrote it.
            string[] values = value!.Split([Constants.Reference.Separator], StringSplitOptions.None);

            if (values.Length == 1)
            {
                reference = new TypeReference(values[0]);
                return true;
            }

            if (values.Length != 2)
            {
                return false;
            }

            TypeReference typeReference = new(values[0]);

            string value_Identity = values[1];

            if (value_Identity.Length > 1
                && value_Identity.StartsWith("\"", StringComparison.Ordinal)
                && value_Identity.EndsWith("\"", StringComparison.Ordinal))
            {
                reference = new UniqueIdReference(typeReference, value_Identity.Substring(1, value_Identity.Length - 2));
                return true;
            }

            if (Guid.TryParse(value_Identity, out Guid guid))
            {
                reference = new GuidReference(typeReference, guid);
                return true;
            }

            return false;
        }
    }
}