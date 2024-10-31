using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class DatabaseItem : SerializableObject, IDatabaseSystemObject
    {
        [JsonInclude, JsonPropertyName("DataType")]
        private DataType dataType;

        [JsonInclude, JsonPropertyName("Value")]
        private object value;

        public DatabaseItem(IData data)
        {
            if(data != null)
            {
                dataType = data.DataType;
                value = Query.TableValue(data);
            }
        }

        public DatabaseItem(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public DatabaseItem(DatabaseItem databaseItem)
            : base(databaseItem)
        {
            if(databaseItem != null)
            {
                dataType = databaseItem.dataType;
                value = databaseItem.value;
            }
        }
    }
}