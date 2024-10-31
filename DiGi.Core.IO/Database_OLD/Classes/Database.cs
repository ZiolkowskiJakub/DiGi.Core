using DiGi.Core.Classes;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class Database : UniqueObject, IDatabaseObject, IEnumerable<Table>
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name;

        [JsonIgnore]
        private Dictionary<string, Table> dictionary = new Dictionary<string, Table>();

        public Database(string name)
            : base()
        {
            this.name = name;
        }

        public Database(string name, IEnumerable<Table> tables)
            : base()
        {
            this.name = name;
            Tables = tables;
        }

        public Database(Database database)
            : base(database)
        {

        }

        public Database(JsonObject jsonObject)
            : base(jsonObject)
        {

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

        [JsonInclude, JsonPropertyName("Tables")]
        public IEnumerable<Table> Tables
        {
            get
            {
                return dictionary?.Values?.ToList();
            }

            set
            {
                dictionary?.Clear();
                if(value == null)
                {
                    return;
                }

                foreach(Table table in value)
                {
                    string name = table?.Name;
                    if (name == null)
                    {
                        continue;
                    }

                    dictionary[name] = table;
                }
            }
        }

        public Table GetTable(string name)
        {
            if(name == null || dictionary == null || !dictionary.TryGetValue(name, out Table result))
            {
                return null;
            }

            return result;
        }

        public bool Add(Table table)
        {
            string name = table?.Name;
            if(name == null)
            {
                return false;
            }

            dictionary[name] = table;
            return true;
        }

        public bool Remove(string name)
        {
            if(name == null)
            {
                return false;
            }

            return dictionary.Remove(name);
        }

        public bool Contains(string name)
        {
            if(name == null)
            {
                return false;
            }

            return dictionary.ContainsKey(name);
        }

        public IEnumerator<Table> GetEnumerator()
        {
            return dictionary == null ? new List<Table>().GetEnumerator() : new List<Table>(dictionary.Values).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}



