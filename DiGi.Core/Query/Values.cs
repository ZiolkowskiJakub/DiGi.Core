using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Nodes;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static int[]? Values(this Range<int>? range)
        {
            if(range is null)
            {
                return null;
            }
            int[] result = new int[range.Max - range.Min];
            for (int i = range.Min; i <= range.Max; i++)
            {
                result[i] = i;
            }

            return result;
        }
    }

}
