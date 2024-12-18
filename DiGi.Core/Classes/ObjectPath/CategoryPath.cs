using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class CategoryPath : ObjectPath<CategoryPath>
    {
        public CategoryPath(IEnumerable<string> names)
            : base(names)
        {

        }

        public CategoryPath(string name)
            :base(name)
        {
            
        }

        public CategoryPath(string name, CategoryPath path)
            :base(name, path)
        {

        }

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
