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

        public ObjectPath(ObjectPath<TObjectPath>? path)
            : base(path)
        {
            if (path != null)
            {
                name = path.name;
                this.path = path.path?.Clone<TObjectPath>();
            }
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
            if (name == null)
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

            if (path != null)
            {
                return path.Add(names);
            }

            List<TObjectPath> paths = [];
            foreach (string name in names)
            {
                if (Create(name) is TObjectPath newPath)
                {
                    paths.Add(newPath);
                }
            }

            if (paths.Count == 0)
            {
                return null;
            }

            while (paths.Count > 1)
            {
                int count = paths.Count;

                paths[count - 2].Path = paths[count - 1];

                paths.RemoveAt(count - 1);
            }

            TObjectPath? result = paths[0];

            Path = result;

            return result;
        }

        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public List<string> GetNames(bool includeName = true)
        {
            List<string> result = [];
            if (includeName)
            {
                result.Add(Name);
            }

            TObjectPath? currentPath = Path;
            while (currentPath != null)
            {
                result.Add(currentPath.Name);
                currentPath = currentPath.Path;
            }

            return result;
        }

        public override string ToString()
        {
            string result = Name ?? string.Empty;
            result = string.Format("\"{0}\"", result.Replace("\"", "\"\""));
            if (path != null)
            {
                result += Separator + path.ToString();
            }

            return result;
        }

        protected abstract TObjectPath? Create(string name);
    }

    public class ObjectPath : ObjectPath<ObjectPath>
    {
        public ObjectPath(IEnumerable<string> names)
            : base(names)
        {

        }

        public ObjectPath(string name)
            : base(name)
        {

        }

        public ObjectPath(string name, ObjectPath path)
            : base(name, path)
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
