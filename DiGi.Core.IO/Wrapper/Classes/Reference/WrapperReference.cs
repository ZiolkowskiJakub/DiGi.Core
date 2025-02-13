using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
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
            if (@object == null)
            {
                return false;
            }

            if (@object is IReference)
            {
                return Equals((IReference)@object);
            }

            return false;
        }

        public bool Equals(IReference reference)
        {
            if (reference == null)
            {
                return false;
            }

            return reference.GetHashCode() == GetHashCode();
        }
    }

    internal abstract class WrapperReference<TSerializableReference> : WrapperReference, IWrapperReference<TSerializableReference> where TSerializableReference : SerializableReference
    {
        public WrapperReference()
            : base()
        {
        }

        public WrapperReference(WrapperReference<TSerializableReference> wrapperReference)
            : base(wrapperReference)
        {

        }
        
        public WrapperReference(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        [JsonIgnore]
        public abstract TSerializableReference Reference { get; }

        public override string ToString()
        {
            return Reference?.ToString();
        }
    }

}
