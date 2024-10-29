using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DataValueCluster<UData> : SerializableObjectValueCluster<TypeReference, UniqueIdReference, UData>, IDatabaseObject where UData : IData
    {
        public DataValueCluster()
            :base()
        {

        }

        public DataValueCluster(DataValueCluster<UData> dataValueCluster)
            :base(dataValueCluster)
        {

        }

        public DataValueCluster(IEnumerable<UData> datas)
            : base(datas)
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

        public DataValueCluster(IEnumerable<IData> datas)
            : base(datas)
        {

        }

        public bool Add(ISerializableObject serializableObject)
        {
            if (serializableObject == null)
            {
                return false;
            }

            if(serializableObject is IData)
            {
                return base.Add((IData)serializableObject);
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

        public List<USerializableObject> AddRange<USerializableObject>(IEnumerable<USerializableObject> serializableObjects) where USerializableObject : ISerializableObject
        {
            if (serializableObjects == null)
            {
                return null;
            }

            List<USerializableObject> result = new List<USerializableObject>();
            foreach (USerializableObject serializableObject in serializableObjects)
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
