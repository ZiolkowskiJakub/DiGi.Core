using DiGi.Core.Classes;
using DiGi.Core.IO.Database.Classes;
using DiGi.Core.IO.Database.Interfaces;

namespace DiGi.Core.IO.Database
{
    public static partial class Convert
    {
        public static Classes.Database ToDiGi<UData>(this DataValueCluster<UData> dataValueCluster, DatabaseConvertOptions databaseConvertOptions) where UData: IData
        {
            if(dataValueCluster == null)
            {
                return null;
            }

            throw new System.NotImplementedException();
            //TODO: Continue here (WIP)

        }
    }
}
