using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using DiGi.Core.IO.Enums;

namespace DiGi.Core.IO.Database
{
    public static partial class Query
    {
        public static PropertyType PropertyType(this IData data)
        {
            if (data == null)
            {
                return Enums.PropertyType.Undefined;
            }

            if(data is DataObject)
            {
                return Enums.PropertyType.Object;
            }

            if(data is DataArray)
            {
                return Enums.PropertyType.Enumerable;
            }

            if (data is DataValue)
            {
                return Enums.PropertyType.Value;
            }

            throw new System.NotImplementedException();
        }

        public static PropertyType PropertyType(this Property property)
        {
            return PropertyType(property?.GetData<IData>());
        }
    }
}

