using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database.Classes
{
    public class Table : UniqueObject, IDatabaseObject, IEnumerable<IData>
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonInclude, JsonPropertyName("HeaderName")]
        private Header header;

        [JsonInclude, JsonPropertyName("Datas")]
        private List<IData> datas;

        public Table(string name, Header header)
            : base()
        {
            this.name = name;
            this.header = header;
        }

        public Table(string name, Header header, IEnumerable<IData> datas)
            : base()
        {
            this.name = name;
            this.header = header;
            this.datas = datas == null ? null : new List<IData>(datas);
        }

        public Table(Table table)
            :base(table)
        {
            if(table != null)
            {
                name = table.Name;
                header = table.Header;
                datas = table.datas == null ? null : new List<IData>(datas);
            }
        }

        public Table(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new Table(this);
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        [JsonIgnore]
        public Header Header
        {
            get
            {
                return header;
            }

            set
            {
                header = value;
            }
        }

        [JsonIgnore]
        public List<IData> Datas
        {
            get
            {
                return datas;
            }

            set
            {
                datas = value;
            }
        }

        public Column GetColumn(string name)
        {
            return header?.GetColumn(name);
        }

        public IData GetData(int index)
        {
            if (datas == null || index < 0 || index >= datas.Count)
            {
                return default;
            }

            return datas[index];
        }

        public T GetData<T>(int index) where T : IData
        {
            IData result = GetData(index);

            return result is T ? (T)result : default;
        }

        public IEnumerator<IData> GetEnumerator()
        {
            return datas?.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}