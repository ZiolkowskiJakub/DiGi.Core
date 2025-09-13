using DiGi.Core.IO.DelimitedData.Enums;

namespace DiGi.Core.IO.DelimitedData
{
    public static partial class Query
    {
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