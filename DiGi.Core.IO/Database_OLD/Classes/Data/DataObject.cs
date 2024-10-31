using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Database_OLD.Classes
{
    public class DataObject : Data<JsonObject>
    {
        public DataObject(JsonObject jsonObject)
            : base(GetJsonObject(jsonObject, true)) 
        {
            value = GetJsonObject(jsonObject, false);
        }

        public DataObject(DataObject dataObject)
            : base(dataObject)
        {

        }

        public override ISerializableObject Clone()
        {
            return new DataObject(this);
        }

        private static JsonObject GetJsonObject(JsonObject jsonObject, bool @base)
        {
            if(jsonObject == null)
            {
                return null;
            }

            if (Core.Query.FullTypeName(jsonObject) == Core.Query.FullTypeName(typeof(DataObject)))
            {
                return @base ? jsonObject : null;
            }
            else
            {
                return @base ? null : jsonObject;
            }
        }
    }
}

