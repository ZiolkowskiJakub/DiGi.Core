using System.Threading.Tasks;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static ParallelOptions ParallelOptions(double fraction = 0.9)
        {
            return new ParallelOptions()
            {
                MaxDegreeOfParallelism = Query.ProcessorCount(fraction)
            };
        }
    }
}
