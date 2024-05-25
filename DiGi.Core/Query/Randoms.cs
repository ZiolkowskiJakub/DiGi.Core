using DiGi.Core.Classes;
using System;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static List<double> Randoms(int count, Random random, double start, double end, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end, tolerance));
            }

            return result;
        }

        public static List<double> Randoms(int count, Random random, Range<double> range, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range, tolerance));
            }

            return result;
        }

        public static List<double> Randoms(int count, double start, double end, int seed = -1, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end, tolerance));
            }

            return result;
        }

        public static List<double> Randoms(int count, Range<double> range, int seed = -1, double tolerance = Constans.Tolerance.MacroDistance)
        {
            if (count <= 0 || range == null)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<double> result = new List<double>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range, tolerance));
            }

            return result;
        }

        public static List<int> Randoms(int count, Range<int> range, int seed = -1)
        {
            if (count <= 0 || range == null)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range));
            }

            return result;
        }

        public static List<int> Randoms(int count, int start, int end, int seed = -1)
        {
            if (count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end));
            }

            return result;
        }

        public static List<int> Randoms(int count, Random random, int start, int end)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, start, end));
            }

            return result;
        }

        public static List<int> Randoms(int count, Random random, Range<int> range)
        {
            if (count <= 0 || random == null || range == null)
            {
                return null;
            }

            List<int> result = new List<int>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random, range));
            }

            return result;
        }

        public static List<bool> Randoms(int count, Random random)
        {
            if (count <= 0 || random == null)
            {
                return null;
            }

            List<bool> result = new List<bool>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random));
            }

            return result;
        }

        public static List<bool> Randoms(int count, int seed = -1)
        { 
            if(count <= 0)
            {
                return null;
            }

            Random random = seed == -1 ? new Random() : new Random(seed);

            List<bool> result = new List<bool>();
            for (int i = 0; i < count; i++)
            {
                result.Add(Random(random));
            }

            return result;
        }
    }

}
