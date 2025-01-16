using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ExternalReferenceGuidResult<TUniqueObject, UExternalReference> : GuidResult<TUniqueObject> where TUniqueObject: IUniqueObject where UExternalReference : IExternalReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private UExternalReference reference;

        public ExternalReferenceGuidResult()
            : base()
        {

        }

        public ExternalReferenceGuidResult(UExternalReference reference)
            : base()
        {
            this.reference = reference;
        }

        public ExternalReferenceGuidResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReferenceGuidResult(ExternalReferenceGuidResult<TUniqueObject, UExternalReference> externalReferenceGuidResult)
            : base(externalReferenceGuidResult)
        {
            if (externalReferenceGuidResult != null)
            {
                reference = externalReferenceGuidResult.reference;
            }
        }

        [JsonIgnore]
        public UExternalReference Reference
        {
            get
            {
                return reference;
            }
        }
    }
}
