using System.ComponentModel;

namespace DiGi.Core.IO.DelimitedData.Enums
{
    /// <summary>
    /// Defines the separator used for delimited data.
    /// </summary>
    [Description("Delimited Data Separator")]
    public enum DelimitedDataSeparator
    {
        /// <summary>Undefined separator</summary>
        [Description("Undefined")] Undefined,
        /// <summary>Comma separator</summary>
        [Description("Comma")] Comma,
        /// <summary>Tab separator</summary>
        [Description("Tab")] Tab
    }
}