using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class PullEventArgs
    {
        private IEnumerable<UniqueReference> uniqueReferences;
        private IEnumerable<IMetadata> metadatas;

        private IEnumerable<WrapperItem> wrapperItems;

        public PullEventArgs(IEnumerable<UniqueReference> uniqueReferences)
        {
            this.uniqueReferences = uniqueReferences;
        }
    }
}
