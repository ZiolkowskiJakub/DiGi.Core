using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryParse(this string value, out IReference reference)
        {
            reference = default;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (!value.Contains(",") || !value.Contains(","))
            {
                return false;
            }

            string[] values = value.Split(new string[] { Constans.Reference.Separator }, System.StringSplitOptions.RemoveEmptyEntries);
            if (values.Length == 0)
            {
                return false;
            }

            TypeReference typeReference = new TypeReference(values[0].Trim());


            if (values.Length == 1)
            {
                reference = typeReference;
                return true;
            }

            string uniqueId = values[1].Trim();

            string propertyName = null;

            if (uniqueId.StartsWith("\"") && uniqueId.EndsWith("\""))
            {
                reference = new UniqueIdReference(typeReference, uniqueId.Substring(1, uniqueId.Length - 2));
            }
            else if (uniqueId.StartsWith("[") && uniqueId.EndsWith("]"))
            {
                propertyName = uniqueId.Substring(1, uniqueId.Length - 2);
                if (propertyName.StartsWith("\"") && propertyName.EndsWith("\""))
                {
                    propertyName = propertyName.Substring(1, uniqueId.Length - 2);
                    reference = new TypePropertyReference(typeReference, propertyName);
                }
            }
            else if (System.Guid.TryParse(uniqueId, out System.Guid guid))
            {
                reference = new GuidReference(typeReference, guid);
            }

            if(reference == null)
            {
                return false;
            }

            if(values.Length == 2)
            {
                return true;
            }

            propertyName = values[2].Trim();

            if (propertyName.StartsWith("[") && propertyName.EndsWith("]"))
            {
                propertyName = propertyName.Substring(1, uniqueId.Length - 2);
                if (propertyName.StartsWith("\"") && propertyName.EndsWith("\""))
                {
                    propertyName = propertyName.Substring(1, uniqueId.Length - 2);
                    if(reference is GuidReference)
                    {
                        reference = new GuidPropertyReference((GuidReference)reference, propertyName);
                        return true;
                    }

                    if(reference is UniqueIdReference)
                    {
                        reference = new UniqueIdPropertyReference((UniqueIdReference)reference, propertyName);
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool TryParse<UReference>(this string value, out UReference reference) where UReference : IReference
        {
            reference = default;

            if(!TryParse(value, out IReference reference_Temp))
            {
                return false;
            }

            if (reference_Temp is UReference)
            {
                reference = (UReference)reference_Temp;
                return true;
            }

            return false;
        }
    }

}
