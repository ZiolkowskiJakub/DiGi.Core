using DiGi.Core.Classes;
using DiGi.Core.Interfaces;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Attempts to parse the specified string into an IReference.
        /// </summary>
        public static bool TryParse(this string? value, out IReference? reference)
        {
            reference = default;

            if (string.IsNullOrWhiteSpace(value))
            {
                return false;
            }

            if (!value!.Contains(",") || !value!.Contains(","))
            {
                return false;
            }

            string[] values = value.Split([Constants.Reference.Separator], System.StringSplitOptions.RemoveEmptyEntries);
            if (values.Length == 0)
            {
                return false;
            }

            string? externalReference = values[0]?.Trim();
            if (!string.IsNullOrWhiteSpace(externalReference) && externalReference!.StartsWith("\"") && externalReference!.EndsWith("\""))
            {
                string source = externalReference.Substring(1, externalReference.Length - 2);

                externalReference = value.Substring(values[0].Length);
                externalReference = externalReference.Substring(externalReference.IndexOf(Constants.Reference.Separator) + 2);
                if (TryParse(externalReference, out IReference? reference_Temp))
                {
                    if (reference_Temp is ITypeRelatedSerializableReference typeRelatedSerializableReference)
                    {
                        reference = new TypeRelatedExternalReference(source, typeRelatedSerializableReference);
                    }
                    else if (reference_Temp is IInstanceRelatedSerializableReference instanceRelatedSerializableReference)
                    {
                        reference = new InstanceRelatedExternalReference(source, instanceRelatedSerializableReference);
                    }
                    else
                    {
                        throw new System.NotImplementedException();
                    }
                }

                return reference != null;
            }

            TypeReference typeReference = new(values[0].Trim());

            if (values.Length == 1)
            {
                reference = typeReference;
                return true;
            }

            string uniqueId = values[1].Trim();

            string? propertyName;

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

            if (reference == null)
            {
                return false;
            }

            if (values.Length == 2)
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
                    if (reference is GuidReference guidReference)
                    {
                        reference = new GuidPropertyReference(guidReference, propertyName);
                        return true;
                    }

                    if (reference is UniqueIdReference uniqueIdReference)
                    {
                        reference = new UniqueIdPropertyReference(uniqueIdReference, propertyName);
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Attempts to parse the specified string into a UReference.
        /// </summary>
        public static bool TryParse<UReference>(this string? value, out UReference? reference) where UReference : IReference
        {
            reference = default;

            if (!TryParse(value, out IReference? reference_Temp))
            {
                return false;
            }

            if (reference_Temp is UReference uReference_Temp)
            {
                reference = uReference_Temp;
                return true;
            }

            return false;
        }
    }
}