using DiGi.Core.Enums;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core.IO.Database
{
    public static partial class Create
    {
        public static Header Header(this IEnumerable<DataObject> dataObjects)
        {
            if(dataObjects == null || dataObjects.Count() == 0)
            {
                return null;
            }

            Dictionary<string, DataType> dictionary = new Dictionary<string, DataType>();
            foreach(DataObject dataObject in dataObjects)
            {
                List<Property> properties = Query.Properties<IData>(dataObject?.Value, false);
                if(properties == null)
                {
                    continue;
                }

                foreach(Property property in properties)
                {
                    if(property == null)
                    {
                        continue;
                    }

                    string name = property.Name;
                    DataType dataType = property.DataType;

                    if(!dictionary.TryGetValue(name, out DataType dataType_Existing) || dataType_Existing == DataType.Undefined)
                    {
                        dictionary[name] = dataType;
                    }
                }
            }

            List<Column> columns = new List<Column>();
            foreach(KeyValuePair<string, DataType> keyValuePair in dictionary)
            {
                columns.Add(new Column(keyValuePair.Key, keyValuePair.Value));
            }

            Header result = new Header(columns);

            return result;
        }
    }
}

