using DiGi.Core.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Generates a list of random doubles within a specified range using a provided Random instance.
        /// </summary>
        /// <param name="count">The number of random doubles to generate.</param>
        /// <param name="random">The Random instance to use for generation.</param>
        /// <param name="start">The start value of the range.</param>
        /// <param name="end">The end value of the range.</param>
        /// <param name="tolerance">The tolerance value used during generation.</param>
        /// <returns>A list of random doubles, or null if generation fails.</returns>
        public static List<double>? Randoms(int count, Random? random, double start, double end, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<double> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end, tolerance));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random doubles within a specified Range using a provided Random instance.
        /// </summary>
        /// <param name="count">The number of random doubles to generate.</param>
        /// <param name="random">The Random instance to use for generation.</param>
        /// <param name="range">The range from which the random doubles are generated.</param>
        /// <param name="tolerance">The tolerance value used during generation.</param>
        /// <returns>A list of random doubles, or null if generation fails.</returns>
        public static List<double>? Randoms(int count, Random? random, Range<double>? range, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<double> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range, tolerance));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random doubles within a specified range using an optional seed.
        /// </summary>
        /// <param name="count">The number of random doubles to generate.</param>
        /// <param name="start">The start value of the range.</param>
        /// <param name="end">The end value of the range.</param>
        /// <param name="seed">An optional seed for the random number generator.</param>
        /// <param name="tolerance">The tolerance value used during generation.</param>
        /// <returns>A list of random doubles, or null if generation fails.</returns>
        public static List<double>? Randoms(int count, double start, double end, int seed = -1, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<double> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end, tolerance));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random doubles within a specified Range using an optional seed.
        /// </summary>
        /// <param name="count">The number of random doubles to generate.</param>
        /// <param name="range">The range from which the random doubles are generated.</param>
        /// <param name="seed">An optional seed for the random number generator.</param>
        /// <param name="tolerance">The tolerance value used during generation.</param>
        /// <returns>A list of random doubles, or null if generation fails.</returns>
        public static List<double>? Randoms(int count, Range<double>? range, int seed = -1, double tolerance = Constants.Tolerance.MacroDistance)
        {
            if (count <= 0 || range is null)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<double> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range, tolerance));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random integers within a specified Range using an optional seed.
        /// </summary>
        /// <param name="count">The number of random integers to generate.</param>
        /// <param name="range">The range from which the random integers are generated.</param>
        /// <param name="seed">An optional seed for the random number generator.</param>
        /// <returns>A list of random integers, or null if generation fails.</returns>
        public static List<int>? Randoms(int count, Range<int>? range, int seed = -1)
        {
            if (count <= 0 || range is null)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<int> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random integers within a specified range using an optional seed.
        /// </summary>
        /// <param name="count">The number of random integers to generate.</param>
        /// <param name="start">The inclusive lower bound of the range.</param>
        /// <param name="end">The exclusive upper bound of the range.</param>
        /// <param name="seed">The seed for the random number generator. Defaults to -1.</param>
        /// <returns>A list of random integers, or null if generation fails.</returns>
        public static List<int>? Randoms(int count, int start, int end, int seed = -1)
        {
            if (count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<int> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random integers within a specified range using a provided Random instance.
        /// </summary>
        /// <param name="count">The number of random integers to generate.</param>
        /// <param name="random">The Random instance used to generate the values.</param>
        /// <param name="start">The inclusive lower bound of the range.</param>
        /// <param name="end">The exclusive upper bound of the range.</param>
        /// <returns>A list of random integers, or null if generation fails.</returns>
        public static List<int>? Randoms(int count, Random? random, int start, int end)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<int> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random integers within a specified Range using a provided Random instance.
        /// </summary>
        /// <param name="count">The number of random integers to generate.</param>
        /// <param name="random">The Random instance used to generate the values.</param>
        /// <param name="range">The range within which the random integers should be generated.</param>
        /// <returns>A list of random integers, or null if generation fails.</returns>
        public static List<int>? Randoms(int count, Random? random, Range<int>? range)
        {
            if (count <= 0 || random == null || range is null)
            {
                return null;
            }

            List<int> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random booleans using a provided Random instance.
        /// </summary>
        /// <param name="count">The number of random booleans to generate.</param>
        /// <param name="random">The Random instance used to generate the values.</param>
        /// <returns>A list of random booleans, or null if generation fails.</returns>
        public static List<bool>? Randoms(int count, Random? random)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<bool> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random));
            }

            return result;
        }

        /// <summary>
        /// Generates a list of random booleans using an optional seed.
        /// </summary>
        /// <param name="count">The number of random booleans to generate.</param>
        /// <param name="seed">The seed for the random number generator. Defaults to -1.</param>
        /// <returns>A list of random booleans, or null if generation fails.</returns>
        public static List<bool>? Randoms(int count, int seed = -1)
        {
            if (count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<bool> result = [];
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random));
            }

            return result;
        }
    }
}