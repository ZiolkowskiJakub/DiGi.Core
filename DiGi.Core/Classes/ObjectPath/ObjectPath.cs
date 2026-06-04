using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Base class for representing a hierarchical path to an object.
    /// </summary>
    public abstract class ObjectPath<TObjectPath> : SerializableObject, IObjectPath<TObjectPath> where TObjectPath : ObjectPath<TObjectPath>
    {
        [JsonInclude, JsonPropertyName("Name")]
        private string name = string.Empty;

        [JsonInclude, JsonPropertyName("Path")]
        private TObjectPath? path = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class using a collection of segment names.
        /// </summary>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class with a single segment name.
        /// </summary>
        public ObjectPath(string? name)
            : this([name ?? string.Empty])
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class from a JSON object.
        /// </summary>
        public ObjectPath(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by appending a name to an existing path.
        /// </summary>
        public ObjectPath(string? name, TObjectPath? path)
            : this(name)
        {
            Path = path?.Clone<TObjectPath>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by copying an existing path.
        /// </summary>
        public ObjectPath(ObjectPath<TObjectPath>? path)
            : base(path)
        {
            if (path != null)
            {
                name = path.name;
                this.path = path.path?.Clone<TObjectPath>();
            }
        }

        /// <summary>
        /// Gets the character used to separate segments in the path.
        /// </summary>
        [JsonIgnore]
        public static string Separator { get; } = "->";

        /// <summary>
        /// Gets the name of the current path segment.
        /// </summary>
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

        /// <summary>
        /// Gets the parent path segment.
        /// </summary>
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

        /// <summary>
        /// Appends a new segment to the path and returns the resulting path.
        /// </summary>
        public TObjectPath? Add(string? name)
        {
            if (name == null)
            {
                return null;
            }

            return Add([name]);
        }

        /// <summary>
        /// Appends multiple segments to the path and returns the resulting path.
        /// </summary>
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

        /// <summary>
        /// Determines whether the specified object is equal to the current path.
        /// </summary>
        public override bool Equals(object obj)
        {
            return ToString() == obj?.ToString();
        }

        /// <summary>
        /// Returns the hash code for this path.
        /// </summary>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Retrieves a list of all segment names in the path.
        /// </summary>
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

        /// <summary>
        /// Returns a string representation of the hierarchical path.
        /// </summary>
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

    /// <summary>
    /// Represents a hierarchical path to an object.
    /// </summary>
    public class ObjectPath : ObjectPath<ObjectPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class using a collection of segment names.
        /// </summary>
        public ObjectPath(IEnumerable<string> names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class with a single segment name.
        /// </summary>
        public ObjectPath(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class by appending a name to an existing path.
        /// </summary>
        public ObjectPath(string name, ObjectPath path)
            : base(name, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectPath"/> class from a JSON object.
        /// </summary>
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