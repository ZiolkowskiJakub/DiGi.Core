using DiGi.Core.Classes;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Database
{
    public static partial class Convert
    {
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

            List<TypeReference> typeReferences;


            DataValueCluster dataValueCluter = new DataValueCluster(datas_Temp);
            dataValueCluter.Flatten(true);

            typeReferences = dataValueCluter.GetKeys_1();
            if(typeReferences == null)
            {
                return null;
            }

            Dictionary<TypeReference, DatabaseType> dictionary = new Dictionary<TypeReference, DatabaseType>();

            if(typeReferences.Count != 0)
            {
                DatabaseType databaseType = null;

                int id = 0;

                databaseType = new DatabaseType(id, typeof(DatabaseType));

                dictionary[databaseType.TypeReference] = databaseType;

                foreach(TypeReference typeReference in typeReferences)
                {
                    id++;

                    databaseType = new DatabaseType(id, typeReference);
                    dictionary[typeReference] = databaseType;
                }

                foreach(DatabaseType databaseType_Temp in dictionary.Values)
                {
                    dataValueCluter.Add(new DataObject(databaseType_Temp.ToJsonObject()));
                }

                typeReferences = dataValueCluter.GetKeys_1();
            }

            Classes.Database result = new Classes.Database(databaseConvertOptions.DatabaseName);

            List<Table> tables = new List<Table>();
            foreach (TypeReference typeReference in typeReferences)
            {
                if(!dictionary.TryGetValue(typeReference, out DatabaseType databaseType) || databaseType == null)
                {
                    continue;
                }

                //DODO: Continue here

                Table table = new Table("types", new Header(new Column[] { new Column("id", Enums.DataType.Int), new Column("fullTypeName", Enums.DataType.String) }));

                dataValueCluter.GetValues<IData>(typeReference);
            }

            throw new System.NotImplementedException();


            //Table table_Items = new Table("items", new Header(new Column[] { new Column("type", Enums.DataType.String), new Column("value", Enums.DataType.Undefined) }));
            //List<IData> datas_Items = new List<IData>();
            //foreach (IData data in datas)
            //{
            //    JsonObject jsonObject = new JsonObject()
            //    {
            //        new KeyValuePair<string, JsonNode> ( "type", data.DataType.ToString() ),
            //        new KeyValuePair<string, JsonNode> ( "value", Query.TableValue(data) as dynamic ),
            //    };

            //    datas_Items.Add(new DataObject(jsonObject));
            //}

            //table_Items.Datas = new List<IData>(datas);
            //result.Add(table_Items);


            //dataValueCluter_Temp.Flatten(true);

            //int index = 0;

            //IEnumerable<TypeReference> typeReferences = dataValueCluter_Temp.GetKeys_1();
            //if (typeReferences != null)
            //{
            //    Table table_Types = new Table("types", new Header(new Column[] { new Column("id", Enums.DataType.Int), new Column("fullTypeName", Enums.DataType.String) }));
            //    List<IData> datas_Types = new List<IData>();

            //    foreach (TypeReference typeReference in typeReferences)
            //    {
            //        string fullTypeName = typeReference?.FullTypeName;
            //        if (string.IsNullOrWhiteSpace(fullTypeName))
            //        {
            //            continue;
            //        }

            //        List<UniqueIdReference> uniqueIdReferences = dataValueCluter_Temp.GetKeys_2(typeReference);
            //        if (uniqueIdReferences == null || uniqueIdReferences.Count == 0)
            //        {
            //            continue;
            //        }

            //        JsonObject jsonObject = new JsonObject()
            //        {
            //            new KeyValuePair<string, JsonNode> ( "id", index ),
            //            new KeyValuePair<string, JsonNode> ( "fullTypeName", typeReference.FullTypeName ),
            //        };

            //        datas_Types.Add(new DataObject(jsonObject));

            //        index++;

            //        //List<Column> columns = new List<Column>();
            //        //foreach(IData data in dataValueCluter_Temp)
            //        //{

            //        //}

            //        //Table table_Types = new Table("types", new Header(new Column[] { new Column("id", Enums.DataType.Int), new Column("fullTypeName", Enums.DataType.String) }));
            //    }

            //    table_Types.Datas = datas_Types;
            //    result.Add(table_Types);
            //}



            //return result;
        }
    }
}
