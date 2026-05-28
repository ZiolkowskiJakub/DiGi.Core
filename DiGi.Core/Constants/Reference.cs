namespace DiGi.Core.Constants
{
    /// <summary>
    /// Constants used for reference identifiers.
    /// </summary>
    public static class Reference
    {
        /// <summary>
        /// Separator used in reference strings.
        /// </summary>
        public const string Separator = "::";

        /// <summary>
        /// Format strings for references.
        /// </summary>
        public static class Format
        {
            /// <summary>
            /// Format for unique identifiers.
            /// </summary>
            public const string UniqueId = "\"{0}\"";
            /// <summary>
            /// Format for GUIDs.
            /// </summary>
            public const string Guid = "{0}";
            /// <summary>
            /// Format for properties.
            /// </summary>
            public const string Property = "[\"{0}\"]";
        }
    }
}