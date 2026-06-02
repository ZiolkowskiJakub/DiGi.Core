using DiGi.Core.Classes;
using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a random double within a range.
        /// </summary>
        /// <param name="random">The Random instance.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="tolerance">The tolerance.</param>
        /// <returns>A random double.</returns>
        public static double Random(Random? random, double start, double end, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (random == null)
            {
                return double.NaN;
            }

            return Random(random, new Range<double>(start, end), tolerance);
        }

        /// <summary>
        /// Generates a random double within a Range struct.
        /// </summary>
        /// <param name="random">The Random instance.</param>
        /// <param name="range">The range.</param>
        /// <param name="tolerance">The tolerance.</param>
        /// <returns>A random double.</returns>
        public static double Random(Random? random, Range<double>? range, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (range is null || random is null)
            {
                return double.NaN;
            }

            return Round(range.Min + ((range.Max - range.Min) * random.NextDouble()), tolerance);
        }

        /// <summary>
        /// Generates a random double using a seed.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="seed">The seed.</param>
        /// <param name="tolerance">The tolerance.</param>
        /// <returns>A random double.</returns>
        public static double Random(double start, double end, int seed = -1, double tolerance = Constants.Tolerance.MacroDistance)
        {
            return Random(new Range<double>(start, end), seed, tolerance);
        }

        /// <summary>
        /// Generates a random double within a Range struct using a seed.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <param name="seed">The seed.</param>
        /// <param name="tolerance">The tolerance.</param>
        /// <returns>A random double.</returns>
        public static double Random(Range<double>? range, int seed = -1, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (range is null)
            {
                return double.NaN;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            return Round(range.Min + ((range.Max - range.Min) * random.NextDouble()), tolerance);
        }

        /// <summary>
        /// Generates a random integer within a Range struct using a seed.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <param name="seed">The seed.</param>
        /// <returns>A random integer.</returns>
        public static int Random(Range<int>? range, int seed = -1)
        {
            if (range is null)
            {
                return int.MinValue;
            }

            Random random = Create.Random(seed);

            return random.Next(range.Min, range.Max);
        }

        /// <summary>
        /// Generates a random integer within a range using a seed.
        /// </summary>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <param name="seed">The seed.</param>
        /// <returns>A random integer.</returns>
        public static int Random(int start, int end, int seed = -1)
        {
            return Random(new Range<int>(start, end), seed);
        }

        /// <summary>
        /// Generates a random integer within a range.
        /// </summary>
        /// <param name="random">The Random instance.</param>
        /// <param name="start">The start value.</param>
        /// <param name="end">The end value.</param>
        /// <returns>A random integer.</returns>
        public static int Random(Random? random, int start, int end)
        {
            if (random == null)
            {
                return int.MinValue;
            }

            return Random(random, new Range<int>(start, end));
        }

        /// <summary>
        /// Generates a random integer within a Range struct.
        /// </summary>
        /// <param name="random">The Random instance.</param>
        /// <param name="range">The range.</param>
        /// <returns>A random integer.</returns>
        public static int Random(Random? random, Range<int>? range)
        {
            if (random == null || range is null)
            {
                return int.MinValue;
            }

            return random.Next(range.Min, range.Max);
        }

        /// <summary>
        /// Generates a random boolean.
        /// </summary>
        /// <param name="random">The Random instance.</param>
        /// <returns>A random boolean.</returns>
        public static bool Random(Random? random)
        {
            if (random == null)
            {
                return false;
            }

            return random.NextDouble() < 0.5;
        }

        /// <summary>
        /// Generates a random boolean using a seed.
        /// </summary>
        /// <param name="seed">The seed.</param>
        /// <returns>A random boolean.</returns>
        public static bool Random(int seed = -1)
        {
            Random random = seed == -1 ? new Random() : new Random(seed);

            return Random(random);
        }
    }
}