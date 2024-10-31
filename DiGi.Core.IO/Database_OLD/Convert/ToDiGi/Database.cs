using DiGi.Core.Classes;
using DiGi.Core.IO.Database_OLD.Classes;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database_OLD
{
    public static partial class Convert
    {
        public static Classes.Database ToDiGi(this IEnumerable<object> objects, DatabaseConvertOptions databaseConvertOptions)
        {
            if(objects == null)
            {
                return null;
            }

            List<IData> datas = new List<IData>();
            foreach(object @object in objects)
            {
                IData data = Create.Data(@object);
                if(data == null)
                {
                    continue;
                }

                datas.Add(data);
            }

            return ToDiGi(datas, databaseConvertOptions);
        }

        public static Classes.Database ToDiGi<UData>(this IEnumerable<UData> datas, DatabaseConvertOptions databaseConvertOptions) where UData : IData
        {
            if (datas == null)
            {
                return null;
            }

            if (databaseConvertOptions == null)
            {
                databaseConvertOptions = new DatabaseConvertOptions();
            }

            List<IData> datas_Temp = new List<IData>();
            foreach(UData uData in datas)
            {
                if(uData == null)
                {
                    continue;
                }

                datas_Temp.Add(uData);
                datas_Temp.Add(new DataObject(new DatabaseItem(uData).ToJsonObject()));
            }

            DataValueCluster dataValueCluter = new DataValueCluster(datas_Temp);
            dataValueCluter.Flatten(true);

            List<TypeReference> typeReferences = dataValueCluter.GetKeys_1();
            if(typeReferences == null)
            {
                return null;
            }

            Classes.Database result = new Classes.Database(databaseConvertOptions.DatabaseName);

            Table table = null;
            DatabaseTypeRelatedSerializableReferenceItem databaseTypeRelatedSerializableReferenceItem = null;
            List<DataObject> dataObjects_Temp = null;

            List<DatabaseTypeRelatedSerializableReferenceItem> databaseTypeRelatedSerializableReferenceItems = new List<DatabaseTypeRelatedSerializableReferenceItem>();

            foreach (TypeReference typeReference in typeReferences)
            {
                List<DataObject> dataObjects = dataValueCluter.GetValues<DataObject>(typeReference);
                if (dataObjects != null && dataObjects.Count != 0)
                { 
                    databaseTypeRelatedSerializableReferenceItem = new DatabaseTypeRelatedSerializableReferenceItem(typeReference);

                    databaseTypeRelatedSerializableReferenceItems.Add(databaseTypeRelatedSerializableReferenceItem);

                    Dictionary<TypePropertyReference, List<DataObject>> dictionary = new Dictionary<TypePropertyReference, List<DataObject>>();

                    foreach (DataObject dataObject in dataObjects)
                    {
                        UniqueIdReference uniqueIdReference = dataObject?.UniqueIdReference;
                        if(uniqueIdReference == null)
                        {
                            continue;
                        }

                        List<Property> properties = Query.Properties<DataArray>(dataObject.Value, false);
                        if (properties == null)
                        {
                            continue;
                        }

                        foreach (Property property in properties)
                        {
                            DataArray dataArray = property?.GetData<DataArray>();
                            if (dataArray == null)
                            {
                                continue;
                            }

                            string name = property.Name;
                            if(string.IsNullOrWhiteSpace(name))
                            {
                                continue;
                            }

                            TypePropertyReference typePropertyReference = new TypePropertyReference(name, typeReference);
                            if (!dictionary.TryGetValue(typePropertyReference, out  dataObjects_Temp) || dataObjects_Temp == null)
                            {
                                dataObjects_Temp = new List<DataObject>();
                                dictionary[typePropertyReference] = dataObjects_Temp;
                            }

                            foreach (JsonNode jsonNode in dataArray.Value)
                            {
                                dataObjects_Temp.Add(new DataObject(new DatabaseArrayItem(uniqueIdReference, Create.Data(jsonNode)).ToJsonObject()));
                            }
                        }
                    }

                    table = new Table(databaseTypeRelatedSerializableReferenceItem.UniqueId, Create.Header(dataObjects));
                    table.Datas = dataObjects.ConvertAll(x => (IData)x);
                    result.Add(table);

                    foreach(KeyValuePair<TypePropertyReference, List<DataObject>> keyValuePair in dictionary)
                    {
                        databaseTypeRelatedSerializableReferenceItem = new DatabaseTypeRelatedSerializableReferenceItem(keyValuePair.Key);

                        databaseTypeRelatedSerializableReferenceItems.Add(databaseTypeRelatedSerializableReferenceItem);

                        table = new Table(databaseTypeRelatedSerializableReferenceItem.UniqueId, Create.Header(keyValuePair.Value));
                        table.Datas = keyValuePair.Value.ConvertAll(x => (IData)x);
                        result.Add(table);
                    }
                }
            }

            databaseTypeRelatedSerializableReferenceItem = new DatabaseTypeRelatedSerializableReferenceItem(new TypeReference(typeof(DatabaseTypeRelatedSerializableReferenceItem)));
            databaseTypeRelatedSerializableReferenceItems.Add(databaseTypeRelatedSerializableReferenceItem);

            dataObjects_Temp = databaseTypeRelatedSerializableReferenceItems.ConvertAll(x => new DataObject(x.ToJsonObject()));
            table = new Table(databaseTypeRelatedSerializableReferenceItem.UniqueId, Create.Header(dataObjects_Temp));
            table.Datas = dataObjects_Temp.ConvertAll(x => (IData)x);
            result.Add(table);

            return result;
        }
    }
}
