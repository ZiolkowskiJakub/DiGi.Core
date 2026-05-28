using System.Threading.Tasks;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates parallel options based on the specified processor fraction.</summary>
        public static ParallelOptions ParallelOptions(double fraction = 0.9)
        {
            return new ParallelOptions()
            {
                MaxDegreeOfParallelism = Query.ProcessorCount(fraction)
            };
        }
    }
}