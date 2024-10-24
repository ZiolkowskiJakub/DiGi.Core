using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public abstract class UniqueReference : TypeReference
    {
        public UniqueReference(UniqueReference uniqueReference)
            :base((TypeReference)uniqueReference)
        {

        }

        public UniqueReference(TypeReference typeReference)
            : base(typeReference)
        {

        }

        public UniqueReference(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public UniqueReference(string fullTypeName)
            : base(fullTypeName)
        {

        }

        public UniqueReference(IObject @object)
            : base(@object)
        {

        }

        public TypeReference TypeReference
        {
            get
            {
                return new TypeReference((TypeReference)this);
            }
        }

        public override bool Equals(object @object)
        {
            UniqueReference uniqueReference = @object as UniqueReference;
            if (uniqueReference == null)
            {
                return false;
            }

            return uniqueReference.ToString() == ToString();
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
