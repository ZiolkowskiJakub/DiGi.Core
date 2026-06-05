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
        /// <param name="names">The collection of segment names to initialize the path.</param>
        public CategoryPath(IEnumerable<string> names)
            : base(names)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class with a single segment name.
        /// </summary>
        /// <param name="name">The name of the category segment.</param>
        public CategoryPath(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class by appending a name to an existing path.
        /// </summary>
        /// <param name="name">The name of the segment to append.</param>
        /// <param name="path">The existing category path to which the name will be appended.</param>
        public CategoryPath(string name, CategoryPath path)
            : base(name, path)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryPath"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the category path.</param>
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