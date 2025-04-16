using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System;
using System.Reflection;
using System.Text.Json.Nodes;


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
