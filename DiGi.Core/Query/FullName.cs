using System;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static string FullName(this Enum @enum)
        {
            if(@enum == null)
            {
                return null;
            }

            return string.Format("{0}:{1}", FullTypeName(@enum.GetType()), @enum.ToString());
        }
    }

}
