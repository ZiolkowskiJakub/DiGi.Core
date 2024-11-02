﻿using DiGi.Core.Interfaces;

namespace DiGi.Core.IO.Database_OLD
{
    public static partial class Query
    {
        public static string TableName(this ITypeRelatedReference typeRelatedReference)
        {
            string result = typeRelatedReference?.ToString();
            result = result.Replace(",", "..");

            return result;
        }
    }
}
