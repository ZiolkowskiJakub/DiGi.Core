using DiGi.Core.Classes;
using DiGi.Core.IO.Wrapper.Interfaces;
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
        
        public override string ToString()
        {
            return reference.ToString();
        }

        public static explicit operator TSerializableReference(WrapperReference<TSerializableReference> reference)
        {
            if (reference == null)
            {
                return null;
            }

            return reference.reference;
        }
    }

}
