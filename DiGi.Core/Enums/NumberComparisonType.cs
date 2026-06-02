using System.ComponentModel;

namespace DiGi.Core.Enums
{
    /// <summary>
    /// Enumerator defining the way in which two numbers are compared.
    /// </summary>
    [Description("Enumerator defining the way in which two numbers are compared.")]
    public enum NumberComparisonType
    {
        /// <summary>Numer Equals</summary>
        [Description("Numer Equals")] Equals,

        /// <summary>Number Not Equals</summary>
        [Description("Number Not Equals")] NotEquals,

        /// <summary>Number Greater Than</summary>
        [Description("Number Greater Than")] Greater,

        /// <summary>Number Less Than</summary>
        [Description("Number Less Than")] Less,

        /// <summary>Number Less Than Or Equals</summary>
        [Description("Number Less Than Or Equals")] LessOrEquals,

        /// <summary>Number Greater Than Or Equals</summary>
        [Description("Number Greater Than Or Equals")] GreaterOrEquals
    }
}