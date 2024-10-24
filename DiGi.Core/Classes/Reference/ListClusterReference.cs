using DiGi.Core.Interfaces;

namespace DiGi.Core.Classes
{
    public class ListClusterReference<TKey_1, TKey_2> : IReference
    {
        public TKey_1 Key_1 { get; }

        public TKey_2 Key_2 { get; }

        public int Index { get; }

        public ListClusterReference(TKey_1 key_1, TKey_2 key_2, int index)
        {
            Key_1 = key_1;
            Key_2 = key_2;
            Index = index;
        }
    }
}
