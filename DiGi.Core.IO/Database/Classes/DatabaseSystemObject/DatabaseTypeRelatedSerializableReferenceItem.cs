using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.IO.Database.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Database.Classes
{
    public class DatabaseTypeRelatedSerializableReferenceItem : SerializableObject, IDatabaseSystemObject
    {
        [JsonInclude, JsonPropertyName("UniqueId")]
        private string uniqueId;

        [JsonInclude, JsonPropertyName("Json")]
        private string json;

        public DatabaseTypeRelatedSerializableReferenceItem(string uniqueId, string json)
        {
            this.uniqueId = uniqueId;
            this.json = json;
        }

        public DatabaseTypeRelatedSerializableReferenceItem(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public DatabaseTypeRelatedSerializableReferenceItem(DatabaseTypeRelatedSerializableReferenceItem databaseTypeRelatedSerializableReferenceItem)
            : base(databaseTypeRelatedSerializableReferenceItem)
        {
            if(databaseTypeRelatedSerializableReferenceItem != null)
            {
                uniqueId = databaseTypeRelatedSerializableReferenceItem.uniqueId;
                json = databaseTypeRelatedSerializableReferenceItem.json;
            }
        }

        public DatabaseTypeRelatedSerializableReferenceItem(ITypeRelatedSerializableReference typeRelatedSerializableReference)
            :base()
        {
            if(typeRelatedSerializableReference != null)
            {
                json = Core.Convert.ToString(typeRelatedSerializableReference);
                uniqueId = Core.Query.UniqueId(typeRelatedSerializableReference);
            }
        }

        [JsonIgnore]
        public string UniqueId
        {
            get
            {
                return uniqueId;
            }
        }

        [JsonIgnore]
        public string Json
        {
            get
            {
                return json;
            }
        }

        public UTypeRelatedSerializableReference GetReference<UTypeRelatedSerializableReference>() where UTypeRelatedSerializableReference : ITypeRelatedSerializableReference
        {
            List<UTypeRelatedSerializableReference> typeRelatedReferences = Core.Convert.ToDiGi<UTypeRelatedSerializableReference>(Json);

            return typeRelatedReferences == null || typeRelatedReferences.Count == 0 ? default : typeRelatedReferences[0];
        }
    }
}