using DiGi.Core.Classes;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database
{
    public static partial class Modify
    {
        public static void Flatten(this DataValueCluster dataValueCluster, bool includeNested)
        {
            if (dataValueCluster == null)
            {
                return;
            }

            List<IData> datas = dataValueCluster.GetValues<IData>();
            if (datas == null)
            {
                return;
            }

            List<JsonObject> jsonObjects = new List<JsonObject>();
            foreach (IData data in datas)
            {
                if (data is DataObject)
                {
                    jsonObjects.Add(((DataObject)(object)data)?.Value);

                }
                else if (data is DataArray)
                {
                    List<JsonObject> jsonObjects_Temp = (((DataArray)data)?.Value).JsonObjects();
                    if(jsonObjects == null)
                    {
                        continue;
                    }
                }
            }

            Dictionary<UniqueIdReference, JsonObject> dictionary = new Dictionary<UniqueIdReference, JsonObject>();
            foreach(JsonObject jsonObject in jsonObjects)
            {
                UniqueIdReference uniqueIdReference = Core.Create.UniqueIdReference(jsonObject);
                if(uniqueIdReference == null)
                {
                    continue;
                }

                dictionary[uniqueIdReference] = jsonObject;
            }

            foreach(JsonObject jsonObject in dictionary.Values)
            {
                List<Property> properties = Query.Properties<DataObject>(jsonObject, includeNested);
                if(properties == null)
                {
                    continue;
                }

                foreach(Property property in properties)
                {
                    DataObject dataObject = property?.GetData<DataObject>();
                    if(dataObject == null)
                    {
                        continue;
                    }

                    dataValueCluster.Add(dataObject);
                }
            }
        }
    }
}

