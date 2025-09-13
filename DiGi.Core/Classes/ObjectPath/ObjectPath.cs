using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ObjectPath<TObjectPath> : SerializableObject, IObjectPath<TObjectPath> where TObjectPath : ObjectPath<TObjectPath>
    {
        [JsonInclude, JsonPropertyName("Name")]

        private string name = string.Empty;

        [JsonInclude, JsonPropertyName("Path")]

        private TObjectPath? path = null;

        public ObjectPath(IEnumerable<string>? names)
        {
            if (names != null && names.Count() != 0)
            {
                List<string> names_Temp = [.. names];
                Name = names_Temp[0] ?? string.Empty;
                if (names_Temp.Count > 1)
                {
                    names_Temp.RemoveAt(0);
                    Add(names_Temp);
                }
            }
        }

        public ObjectPath(string? name)
            : this([name ?? string.Empty])
        {

        }

        public ObjectPath(JsonObject? jsonObject)
            : base(jsonObject)
        {

        }

        public ObjectPath(string? name, TObjectPath? path)
            : this(name)
        {
            Path = path?.Clone<TObjectPath>();
        }

        [JsonIgnore]
        public static string Separator { get; } = "->";

        [JsonIgnore]
        public string Name 
        { 
            get
            {
                return name;
            }

            set
            {
                name = value ?? string.Empty;
            }
        }

        [JsonIgnore]
        public TObjectPath? Path
        {
            get
            {
                return path?.Clone<TObjectPath>();
            }

            set
            {
                path = value?.Clone<TObjectPath>();
            }
        }

        public TObjectPath? Add(string? name)
        {
            if(name == null)
            {
                return null;
            }

            return Add([name]);
        }

        public TObjectPath? Add(IEnumerable<string>? names)
        {
            if (names == null || names.Count() == 0)
            {
                return null;
            }

            if(path != null)
            {
                return path.Add(names);
            }

            List<string> names_Temp = [.. names];

            TObjectPath? result = null;

            TObjectPath? path_Last = null;  
            foreach (string name_Temp in names_Temp)
            {
                TObjectPath? path_Temp = Create(name_Temp);
                if(path_Temp == null)
                {
                    continue;
                }

                if (path_Last == null)
                {
                    result = path_Temp;
                }
                else
                {
                    path_Last.Path = path_Temp;
                }

                path_Last = path_Temp;
            }

            Path = result;

            return result;
        }

        public override string ToString()
        {
            string result = Name ?? string.Empty;
            result = string.Format("\"{0}\"", result.Replace("\"", "\"\""));
            if (Path != null)
            {
                result += Separator + Path.ToString();
            }

            return result;
        }

        protected abstract TObjectPath? Create(string name);

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }
    }

    public class ObjectPath : ObjectPath<ObjectPath>
    {
        public ObjectPath(IEnumerable<string> names)
            : base(names)
        {

        }

        public ObjectPath(string name)
            :base(name)
        {
            
        }

        public ObjectPath(string name, ObjectPath path)
            :base(name, path)
        {

        }

        public ObjectPath(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        protected override ObjectPath Create(string name)
        {
            return new ObjectPath(name);
        }
    }
}
