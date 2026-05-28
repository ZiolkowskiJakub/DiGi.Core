using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Enumerator defining the way in which two strings are compared.
    /// </summary>
    [Description("Enumerator defining the way in which two strings are compared.")]
    public enum TextComparisonType
    {
        [Description("Text Equals")] Equals,
        [Description("Text Not Equals")] NotEquals,
        [Description("Text Contains")] Contains,
        [Description("Text Not Contains")] NotContains,
        [Description("Text Starts With")] StartsWith,
        [Description("Text Ends With")] EndsWith,
    }
}