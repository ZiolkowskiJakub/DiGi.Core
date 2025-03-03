using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class IndexedBools : IndexedObjects<bool>
    {
        public IndexedBools()
            : base()
        {

        }

        public IndexedBools(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public IndexedBools(IndexedBools indexedDoubles)
            : base(indexedDoubles)
        {

        }

        public IndexedBools(IEnumerable<bool> values)
            : base(values)
        {

        }

        public IndexedBools(IEnumerable<bool> values, int startIndex)
            : base(values, startIndex)
        {

        }

        public IndexedBools(int startIndex, int count, bool value)
            : base(startIndex, count, value)
        {

        }
    }
}
