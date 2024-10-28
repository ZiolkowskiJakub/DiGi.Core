using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DatabaseConvertOptions : ConvertOptions
    {
        public string DatabaseName { get; set; }

        public DatabaseConvertOptions()
            :base()
        {

        }
        public DatabaseConvertOptions(DatabaseConvertOptions databaseConvertOptions)
                    : base(databaseConvertOptions)
        {
            if(databaseConvertOptions != null)
            {
                DatabaseName = databaseConvertOptions.DatabaseName;
            }
        }

        public DatabaseConvertOptions(JsonObject jsonObject)
            : base(jsonObject)
        {

        }
    }
}
