using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DatabaseConvertOptions : ConvertOptions
    {
        public DatabaseConvertOptions()
            :base()
        {

        }
        public DatabaseConvertOptions(DatabaseConvertOptions databaseConvertOptions)
                    : base(databaseConvertOptions)
        {

        }
        public DatabaseConvertOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
