namespace DiGi.Core.Constants
{
    /// <summary>
    /// Constants defining the reference string grammar.
    /// <para>A reference renders as <c>discriminator ( "::" segment )*</c>, where the discriminator is a
    /// <see cref="Kind"/> token (always written) or an assembly-qualified full type name (accepted on read only).
    /// A segment is either an escaped scalar token, a nested reference wrapped in <see cref="NestingStart"/> /
    /// <see cref="NestingEnd"/>, or <see cref="Null"/>.</para>
    /// </summary>
    public static class Reference
    {
        // TODO [ReferenceFormat]: The nested Format class was removed here. It held the pre-discriminator
        // decorations - Guid "{0}", UniqueId "\"{0}\"" and Property "[\"{0}\"]" - which encoded a reference's type
        // by shape and could not be escaped. The discriminator carries that information now, so "[", "]" and "\""
        // are ordinary payload characters. Legacy strings written with those decorations are read by
        // Query.TryParseLegacy; restore this class only if the old format must be WRITTEN again.

        /// <summary>
        /// Separator between the discriminator and each segment. Only an unescaped occurrence at nesting depth zero
        /// separates; an occurrence inside a payload is escaped and never splits.
        /// </summary>
        public const string Separator = "::";

        /// <summary>
        /// Escape prefix. Applied to itself, to each character of <see cref="Separator"/>, and to
        /// <see cref="NestingStart"/> / <see cref="NestingEnd"/>, making the mapping prefix-free and invertible.
        /// </summary>
        public const string Escape = "\\";

        /// <summary>
        /// Opens a nested reference segment.
        /// </summary>
        public const string NestingStart = "(";

        /// <summary>
        /// Closes a nested reference segment.
        /// </summary>
        public const string NestingEnd = ")";

        /// <summary>
        /// Segment representing a null value, as distinct from an empty segment which represents
        /// <see cref="string.Empty"/>. A real payload can never render as this token, because a literal escape
        /// character is always itself escaped.
        /// </summary>
        public const string Null = "\\0";

        /// <summary>
        /// Discriminator tokens for the reference types defined in DiGi.Core.
        /// <para>These values are a persisted contract: they are written into stored reference strings, so they are
        /// append-only. Renaming one silently invalidates every string already stored in that format. Types outside
        /// DiGi.Core declare their own tokens in their repository's <c>Constants.ReferenceKind</c> class.</para>
        /// <para>A token must never contain a comma (which would make it parse as a full type name) or a colon.</para>
        /// </summary>
        public static class Kind
        {
            /// <summary>Discriminator for <see cref="Classes.TypeReference"/>.</summary>
            public const string Type = "Type";

            /// <summary>Discriminator for <see cref="Classes.GuidReference"/>.</summary>
            public const string Guid = "Guid";

            /// <summary>Discriminator for <see cref="Classes.UniqueIdReference"/>.</summary>
            public const string UniqueId = "UniqueId";

            /// <summary>Discriminator for <see cref="Classes.TypePropertyReference"/>.</summary>
            public const string TypeProperty = "TypeProperty";

            /// <summary>Discriminator for <see cref="Classes.GuidPropertyReference"/>.</summary>
            public const string GuidProperty = "GuidProperty";

            /// <summary>Discriminator for <see cref="Classes.UniqueIdPropertyReference"/>.</summary>
            public const string UniqueIdProperty = "UniqueIdProperty";

            /// <summary>Discriminator for <see cref="Classes.TypeRelatedExternalReference"/>.</summary>
            public const string TypeExternal = "TypeExternal";

            /// <summary>Discriminator for <see cref="Classes.InstanceRelatedExternalReference"/>.</summary>
            public const string InstanceExternal = "InstanceExternal";

            /// <summary>Discriminator for <see cref="Classes.GuidExternalReference"/>.</summary>
            public const string GuidExternal = "GuidExternal";

            /// <summary>Discriminator for <see cref="Classes.ComplexReference"/>.</summary>
            public const string Complex = "Complex";
        }
    }
}