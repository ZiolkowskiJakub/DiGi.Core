using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public abstract class ExternalReferenceUniqueResult<TUniqueObject, UExternalReference> : UniqueResult<TUniqueObject> where TUniqueObject: IUniqueObject where UExternalReference : IExternalReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        private UExternalReference reference;

        public ExternalReferenceUniqueResult()
            : base()
        {

        }

        public ExternalReferenceUniqueResult(UExternalReference reference)
            : base()
        {
            this.reference = reference;
        }

        public ExternalReferenceUniqueResult(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public ExternalReferenceUniqueResult(ExternalReferenceUniqueResult<TUniqueObject, UExternalReference> externalReferenceUniqueResult)
            : base(externalReferenceUniqueResult)
        {
            if (externalReferenceUniqueResult != null)
            {
                reference = externalReferenceUniqueResult.reference;
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
