using DiGi.Core.Classes;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class Header : SerializableObject, IDatabaseObject, IEnumerable<Column>
    {
        [JsonIgnore]
        private Dictionary<string, Column> dictionary = new Dictionary<string, Column>();

        public Header(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Header(Header header)
            : base(header)
        {
            if (header != null)
            {
                Columns = header.Columns;
            }
        }

        public Header(IEnumerable<Column> columns)
            : base()
        {
            if(columns != null)
            {
                Columns = new List<Column>(columns);
            }
        }

        [JsonInclude, JsonPropertyName("Columns")]
        public List<Column> Columns
        {
            get
            {
                return dictionary.Values.ToList();
            }

            set
            {
                dictionary.Clear();
                if (value == null)
                {
                    return;
                }

                foreach(Column column in value)
                {
                    string name = column?.Name;
                    if (name == null)
                    {
                        continue;
                    }

                    dictionary[column.Name] = column;
                }
            }
        }

        public IEnumerator<Column> GetEnumerator()
        {
            List<Column> columns = Columns;
            if(columns == null)
            {
                return new List<Column>().GetEnumerator();
            }

            return Columns.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Column GetColumn(string name)
        {
            if(name == null || !dictionary.TryGetValue(name, out Column result))
            {
                return null;
            }

            return result;
        }
    }
}