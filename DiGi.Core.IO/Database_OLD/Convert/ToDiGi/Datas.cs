using DiGi.Core.Classes;
using DiGi.Core.IO.Database_OLD.Classes;
using DiGi.Core.IO.Database_OLD.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.IO.Database_OLD
{
    public static partial class Convert
    {
        public static List<UData> ToDiGi<UData>(this Classes.Database database) where UData : IData
        {
            if(database == null)
            {
                return null;
            }

            string uniqueId = Core.Query.UniqueId(new TypeReference(typeof(DatabaseItem)));

            Table table = database.GetTable(uniqueId);

            foreach(IData data in table.Datas)
            {
                if(data is DataObject)
                {
                    DatabaseItem databaseItem = Core.Create.SerializableObject<DatabaseItem>(((DataObject)data).Value);
                }
            }

            return null;

        }
    }
}
