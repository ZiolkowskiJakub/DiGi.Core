using System.ComponentModel;

namespace DiGi.Core.Enums
{
    [Description("Delimited File Type")]
    public enum DelimitedFileType
    {
        [Description("Undefined")] Undefined,
        [Description("Csv")] Csv,
        [Description("Tab Delimited")] TabDelimited
    }
}