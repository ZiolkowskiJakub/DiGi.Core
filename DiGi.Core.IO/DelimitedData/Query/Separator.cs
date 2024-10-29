using DiGi.Core.IO.DelimitedData.Enums;

namespace DiGi.Core.IO.DelimitedData.Query
{
    public static partial class Query
    {
        public static char Separator(this DelimitedDataSeparator delimitedDataSeparator)
        {
            switch (delimitedDataSeparator)
            {
                case DelimitedDataSeparator.Comma:
                    return ',';

                case DelimitedDataSeparator.Tab:
                    return '\t';

                default:
                    return '\n';
            }
        }
    }
}