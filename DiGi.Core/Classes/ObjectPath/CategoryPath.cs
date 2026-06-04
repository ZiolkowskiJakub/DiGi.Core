using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a hierarchical path to a category.
    /// </summary>
    public class CategoryPath : ObjectPath<CategoryPath>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class using a collection of segment names.
        /// </summary>
        public CategoryPath(IEnumerable<string> names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class with a single segment name.
        /// </summary>
        public CategoryPath(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class by appending a name to an existing path.
        /// </summary>
        public CategoryPath(string name, CategoryPath path)
            : base(name, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class from a JSON object.
        /// </summary>
        public CategoryPath(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        protected override CategoryPath Create(string name)
        {
            return new CategoryPath(name);
        }
    }
}