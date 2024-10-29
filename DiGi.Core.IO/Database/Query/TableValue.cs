using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Query
    {
        public static object TableValue(this IData data)
        {
            if (data == null)
            {
                return null;
            }

            if(data is DataObject)
            {
                return ((DataObject)data).UniqueIdReference.ToString();
            }

            if(data is DataArray)
            {
                return ((DataArray)data).UniqueIdReference.ToString();
            }

            if (data is DataValue)
            {
                JsonValue jsonValue = ((DataValue)data).Value;
                if(jsonValue == null || !jsonValue.TryGetValue(out object result))
                {
                    return null;
                }

                return result;
            }

            throw new System.NotImplementedException();
        }
    }
}

