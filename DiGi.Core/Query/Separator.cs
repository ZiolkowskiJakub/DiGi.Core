using DiGi.Core.Enums;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static char Separator(this DelimitedFileType delimitedFileType)
        {
            switch (delimitedFileType)
            {
                case DelimitedFileType.Csv:
                    return ',';

                case DelimitedFileType.TabDelimited:
                    return '\t';

                default:
                    return '\n';
            }
        }
    }
}