using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class Column : SerializableObject, IDatabaseObject
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("DataType")]
        private DataType dataType;

        public Column(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Column(string name, DataType dataType)
            : base()
        {
            this.name = name;
            this.dataType = dataType;
        }

        public Column(Column column)
            : base(column)
        {
            if (column != null)
            {
                name = column.name;
                dataType = column.dataType;
            }
        }

        public override ISerializableObject Clone()
        {
            return new Column(this);
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonIgnore]
        public DataType DataType
        {
            get
            {
                return dataType;
            }
        }
    }
}
