using DiGi.Core.Interfaces;

namespace DiGi.Core.Classes
{
    public abstract class ListClusterReference<TKey_1, TKey_2>(TKey_1? key_1, TKey_2? key_2, int index) : IReference
    {
        public int Index { get; } = index;

        public TKey_1? Key_1 { get; } = key_1;

        public TKey_2? Key_2 { get; } = key_2;

        public abstract bool Equals(IReference reference);
    }
}