using DiGi.Core.IO.DelimitedData.Enums;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the character value of a DelimitedDataSeparator enum member.
        /// </summary>
        /// <param name="delimitedDataSeparator">The delimited data separator to get the character value for.</param>
        /// <returns>The character representation of the specified delimiter.</returns>
        public static char Separator(this DelimitedDataSeparator delimitedDataSeparator)
        {
            return delimitedDataSeparator switch
            {
                DelimitedDataSeparator.Comma => ',',
                DelimitedDataSeparator.Tab => '\t',
                DelimitedDataSeparator.Undefined => '\t',
                _ => '\n',
            };
        }
    }
}