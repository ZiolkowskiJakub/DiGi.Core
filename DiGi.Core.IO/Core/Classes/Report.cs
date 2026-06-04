using DiGi.Core.IO.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Classes
{
    /// <summary>
    /// Represents a report used for collecting and exporting data.
    /// </summary>
    public sealed class Report : IIOObject
    {
        private readonly List<string[]> lines = [];
        private readonly string separator = "\t";

        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class.
        /// </summary>
        public Report()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class with a specified separator character.
        /// </summary>
        public Report(char separator)
        {
            this.separator = separator.ToString();
        }

        /// <summary>
        /// Adds a collection of values to the report.
        /// </summary>
        public void Add<T>(IEnumerable<T?>? values)
        {
            T?[]? values_Temp = values?.ToArray();
            if (values_Temp == null)
            {
                return;
            }

            Add(values_Temp);
        }

        /// <summary>
        /// Adds one or more values of type <typeparamref name="T"/> to the report.
        /// </summary>
        public void Add<T>(params T?[]? values)
        {
            List<string> values_Temp = [];
            if (values != null)
            {
                foreach (T? value in values)
                {
                    string? text = value?.ToString();
                    values_Temp.Add(text ?? string.Empty);
                }
            }

            lines.Add([.. values_Temp]);
        }

        /// <summary>
        /// Adds one or more objects to the report.
        /// </summary>
        public void Add(params object?[]? values)
        {
            Add<object>(values);
        }

        /// <summary>
        /// Adds a new entry to the report.
        /// </summary>
        public void Add()
        {
            lines.Add([]);
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        /// <summary>
        /// Returns a string representation of the current report.
        /// </summary>
        public override string ToString()
        {
            if (lines == null || lines.Count == 0)
            {
                return string.Empty;
            }

            List<string> values = [];
            foreach (string[] line in lines)
            {
                if (line == null || line.Length == 0)
                {
                    values.Add(string.Empty);
                    continue;
                }

                List<string> values_Temp = [];
                foreach (string value in line)
                {
                    values_Temp.Add(value ?? string.Empty);
                }

                values.Add(string.Join(separator, values_Temp));
            }

            return string.Join("\n", values);
        }

        /// <summary>
        /// Writes the report content to the specified file path.
        /// </summary>
        public bool Write(string? path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return false;
            }

            if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)))
            {
                return false;
            }

            System.IO.File.WriteAllText(path, ToString());
            return true;
        }
    }
}