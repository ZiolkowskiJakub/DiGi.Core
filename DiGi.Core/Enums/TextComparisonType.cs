using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Enumerator defining the way in which two strings are compared.
    /// </summary>
    [Description("Enumerator defining the way in which two strings are compared.")]
    public enum TextComparisonType
    {
        /// <summary>Text Equals</summary>
        [Description("Text Equals")] Equals,

        /// <summary>Text Not Equals</summary>
        [Description("Text Not Equals")] NotEquals,

        /// <summary>Text Contains</summary>
        [Description("Text Contains")] Contains,

        /// <summary>Text Not Contains</summary>
        [Description("Text Not Contains")] NotContains,

        /// <summary>Text Starts With</summary>
        [Description("Text Starts With")] StartsWith,

        /// <summary>Text Ends With</summary>
        [Description("Text Ends With")] EndsWith,

        /// <summary>Text Not Starts With</summary>
        [Description("Text Not Starts With")] NotStartsWith,

        /// <summary>Text Not Ends With</summary>
        [Description("Text Not Ends With")] NotEndsWith,
    }
}