using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.IO.Wrapper.Classes
{
    internal abstract class WrapperReference : SerializableObject, IWrapperReference
    {
        [JsonIgnore]
        private int? hashCode;

        public WrapperReference()
        {

        }

        public WrapperReference(WrapperReference wrapperReference)
        {

        }

        public WrapperReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public override int GetHashCode()
        {
            if(hashCode == null || !hashCode.HasValue)
            {
                hashCode = ToString().GetHashCode();
            }

            return hashCode.Value;
        }

        public override bool Equals(object @object)
        {
            WrapperReference wrapperReference = @object as WrapperReference;
            if(wrapperReference == null)
            {
                return false;
            }

            return wrapperReference.GetHashCode() == GetHashCode();
        }

        public static bool operator !=(WrapperReference wrapperReference_1, WrapperReference wrapperReference_2)
        {
            if (Equals(wrapperReference_1, wrapperReference_2))
            {
                return true;
            }

            if (Equals(wrapperReference_1, null))
            {
                return false;
            }

            if (Equals(wrapperReference_2, null))
            {
                return false;
            }

            return !wrapperReference_1.Equals(wrapperReference_2);
        }

        public static bool operator ==(WrapperReference wrapperReference_1, WrapperReference wrapperReference_2)
        {
            if (Equals(wrapperReference_1, wrapperReference_2))
            {
                return true;
            }

            if (Equals(wrapperReference_1, null))
            {
                return false;
            }

            if (Equals(wrapperReference_2, null))
            {
                return false;
            }

            return wrapperReference_1.Equals(wrapperReference_2);
        }
    }

    internal abstract class WrapperReference<TSerializableReference> : WrapperReference, IWrapperReference<TSerializableReference> where TSerializableReference : SerializableReference
    {
        [JsonInclude, JsonPropertyName("Reference")]
        protected TSerializableReference reference;

        public WrapperReference(TSerializableReference reference) 
        {
            this.reference = reference;
        }

        public WrapperReference(WrapperReference<TSerializableReference> wrapperReference)
            : base(wrapperReference)
        {
            if(wrapperReference != null)
            {
                reference = wrapperReference.reference;
            }

        }
        
        public WrapperReference(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public override string ToString()
        {
            return reference.ToString();
        }

        public TSerializableReference Reference
        {
            get
            {
                return reference;
            }
        }
    }

}
