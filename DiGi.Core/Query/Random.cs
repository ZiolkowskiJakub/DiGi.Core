using DiGi.Core.Classes;
using System;
using System.Security.Cryptography;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static double Random(Random random, double start, double end, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if(random == null)
            {
                return double.NaN;
            }

            return Random(random, new Range<double>(start, end), tolerance);
        }

        public static double Random(Random random, Range<double> range, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (range == null || random == null)
            {
                return double.NaN;
            }

            return Round(range.Min + ((range.Max - range.Min) * random.NextDouble()), tolerance);
        }

        public static double Random(double start, double end, int seed = -1, double tolerance = Constans.Tolerance.MacroDistance)
        {
            return Random(new Range<double>(start, end), seed, tolerance);
        }

        public static double Random(Range<double> range, int seed = -1, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (range == null)
            {
                return double.NaN;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            return Round(range.Min + ((range.Max - range.Min) * random.NextDouble()), tolerance);
        }

        public static int Random(Range<int> range, int seed = -1)
        {
            if (range == null)
            {
                return int.MinValue;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            return random.Next(range.Min, range.Max);
        }

        public static int Random(int start, int end, int seed = -1)
        {
            return Random(new Range<int>(start, end), seed);
        }

        public static int Random(Random random, int start, int end)
        {
            if (random == null)
            {
                return int.MinValue;
            }

            return Random(random, new Range<int>(start, end));
        }

        public static int Random(Random random, Range<int> range)
        {
            if (random == null)
            {
                return int.MinValue;
            }

            return random.Next(range.Min, range.Max);
        }

        public static bool Random(Random random)
        {
            if(random == null)
            {
                return false;
            }

            return random.NextDouble() < 0.5;
        }

        public static bool Random(int seed = -1)
        { 
            Random random = seed == -1 ? new Random() : new Random(seed);

            return Random(random);
        }
    }

}
