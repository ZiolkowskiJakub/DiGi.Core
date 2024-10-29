using DiGi.Core.Classes;
using DiGi.Core.Enums;
using DiGi.Core.IO.Database.Interfaces;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database.Classes
{
    public class DatabaseArrayItem : SerializableObject, IDatabaseSystemObject
    {
        [JsonInclude, JsonPropertyName("UniqueIdReference")]
        private UniqueIdReference uniqueIdReference;

        [JsonInclude, JsonPropertyName("Value")]
        private object value;

        public DatabaseArrayItem(UniqueIdReference uniqueIdReference, IData data)
        {
            if(data != null)
            {
                this.uniqueIdReference = uniqueIdReference;
                value = Query.TableValue(data);
            }
        }
    }
}