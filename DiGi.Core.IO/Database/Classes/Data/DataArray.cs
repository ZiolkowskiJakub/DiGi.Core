using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database.Classes
{
    public class DataArray : Data<JsonArray>
    {
        public DataArray(JsonArray jsonArray)
            : base(jsonArray)
        {

        }

        public DataArray(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DataArray(DataArray dataArray)
            : base(dataArray)
        {

        }

        public override ISerializableObject Clone()
        {
            return new DataArray(this);
        }

    }
}