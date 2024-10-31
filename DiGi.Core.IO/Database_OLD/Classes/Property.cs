using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class Property : SerializableObject, IDatabaseObject
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name = null;

        [JsonInclude, JsonPropertyName("Data")]
        private IData data = null;

        public Property(string name, IData data)
        {
            this.name = name;
            this.data = data;
        }

        public T GetData<T>() where T : IData
        {
            return data is T ? (T)data : default;
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
                return Core.Query.DataType(data);
            }
        }
    }
}
