using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Wrapper.Classes
{
    public class PushEventArgs
    {
        private IEnumerable<WrapperItem> wrapperItems;

        private IMetadata metadata;
        
        public PushEventArgs(IEnumerable<WrapperItem> wrapperItems) 
        {
            this.wrapperItems = wrapperItems;
        }
    }
}
