using DiGi.Core.Interfaces;
using System;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static TGuidObject Duplicate<TGuidObject>(this TGuidObject guidObject, Guid? guid = null) where TGuidObject : IGuidObject
        {
            IGuidObject result =  guidObject?.Duplicate(guid);

            return result is TGuidObject ? (TGuidObject)result : default;

        }
    }

}
