namespace DiGi.Core.Constants
{
    /// <summary>
    /// 64-bit FNV-1a initial hash values
    /// </summary>
    public static class FNV
    {
        /// <summary>
        /// 64-bit FNV-1a initial value of the hash before processing any input
        /// </summary>
        public const ulong OffsetBasis = 14695981039346656037UL;

        /// <summary>
        /// 64-bit FNV-1a prime number is multiplied at each step to spread out the hash bits
        /// </summary>
        public const ulong Prime = 1099511628211UL;
    }
}