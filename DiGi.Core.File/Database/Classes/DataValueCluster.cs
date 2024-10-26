using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Xml.Linq;

namespace DiGi.Core.IO.Database.Classes
{
    public class DataValueCluster<UData> : SerializableObjectListCluster<TypeReference, UniqueIdReference, UData>, IDatabaseObject where UData : IData
    {
        public DataValueCluster()
            :base()
        {

        }

        public DataValueCluster(DataValueCluster<UData> dataValueCluster)
            :base(dataValueCluster)
        {

        }

        public DataValueCluster(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        protected override TypeReference GetKey_1(UData value)
        {
            return value?.UniqueIdReference?.TypeReference;
        }

        protected override UniqueIdReference GetKey_2(UData value)
        {
            return value?.UniqueIdReference;
        }
    }

    public class DataValueCluster : DataValueCluster<IData>
    {
        public DataValueCluster()
            : base()
        {
        }

        public DataValueCluster(DataValueCluster dataValueCluster)
            : base(dataValueCluster)
        {

        }

        public DataValueCluster(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public bool Add(ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return false;
            }

            return Add(serializableObject.ToJsonObject());
        }

        public bool Add(JsonNode jsonNode)
        {
            IData data = Create.Data(jsonNode);
            if (data == null)
            {
                return false;
            }

            return Add(data);
        }

        public List<T> AddRange<T>(IEnumerable<T> serializableObjects) where T : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            foreach (T serializableObject in serializableObjects)
            {
                bool added = Add(serializableObject);
                if (added)
                {
                    result.Add(serializableObject);
                }
            }

            return result;
        }
    }
}
