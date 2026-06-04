using DiGi.Core.Interfaces;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Provides an abstract base class for references to elements within a list cluster.
    /// </summary>
    public abstract class ListClusterReference<TKey_1, TKey_2>(TKey_1? key_1, TKey_2? key_2, int index) : IReference
    {
        /// <summary>
        /// Gets or sets the index of the reference within the list cluster.
        /// </summary>
        public int Index { get; } = index;

        /// <summary>
        /// Gets or sets the primary key associated with the reference.
        /// </summary>
        public TKey_1? Key_1 { get; } = key_1;

        /// <summary>
        /// Gets or sets the secondary key associated with the reference.
        /// </summary>
        public TKey_2? Key_2 { get; } = key_2;

        /// <summary>
        /// Determines whether the specified reference is equal to the current reference.
        /// </summary>
        public abstract bool Equals(IReference reference);
    }
}