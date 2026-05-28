namespace DiGi.Core.Constants
{
    /// <summary>
    /// Constants used for serialization processes.
    /// </summary>
    public static class Serialization
    {
        /// <summary>
        /// Literal names for special values in serialization.
        /// </summary>
        public static class LiteralName
        {
            /// <summary>
            /// Positive infinity literal.
            /// </summary>
            public const string PositiveInfinity = "Infinity";

            /// <summary>
            /// Negative infinity literal.
            /// </summary>
            public const string NegativeInfinity = "-Infinity";
        }

        /// <summary>
        /// Property names used in serialized JSON objects.
        /// </summary>
        public static class PropertyName
        {
            /// <summary>
            /// Type property name.
            /// </summary>
            public const string Type = "_type";

            /// <summary>
            /// Guid property name.
            /// </summary>
            public const string Guid = "Guid";

            /// <summary>
            /// UniqueId property name.
            /// </summary>
            public const string UniqueId = "UniqueId";

            /// <summary>
            /// ValueType property name.
            /// </summary>
            public const string ValueType = "ValueType";

            /// <summary>
            /// Value property name.
            /// </summary>
            public const string Value = "Value";
        }

        /// <summary>
        /// Method names used in serialization/deserialization.
        /// </summary>
        public static class MethodName
        {
            /// <summary>
            /// Clone method name.
            /// </summary>
            public const string Clone = "Clone";
        }
    }
}