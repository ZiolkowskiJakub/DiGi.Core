using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a value cluster that ensures uniqueness of its contained objects.
    /// </summary>
    public class UniqueObjectValueCluster<TValue> : SerializableObjectValueCluster<TypeReference, IUniqueReference, TValue> where TValue : IUniqueObject
    {
        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class.
        /// </summary>
        public UniqueObjectValueCluster()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class using the specified collection of values.
        /// </summary>
        public UniqueObjectValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class from another unique object value cluster.
        /// </summary>
        public UniqueObjectValueCluster(UniqueObjectValueCluster<TValue>? uniqueObjectValueCluster)
            : base(uniqueObjectValueCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class from a JSON object.
        /// </summary>
        public UniqueObjectValueCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Determines whether the cluster contains an element with the specified unique reference.
        /// </summary>
        public bool Contains(IUniqueReference? uniqueReference)
        {
            TypeReference? typeReference = uniqueReference?.TypeReference;
            if (typeReference == null)
            {
                return false;
            }

            return Contains(typeReference, uniqueReference);
        }

        /// <summary>
        /// Retrieves all type references present in the unique object value cluster.
        /// </summary>
        public List<TypeReference>? GetTypeReferences()
        {
            return GetKeys_1();
        }

        /// <summary>
        /// Retrieves the first value that satisfies the specified predicate.
        /// </summary>
        public override UValue? GetValue<UValue>(Func<UValue?, bool>? func) where UValue : default
        {
            Type type = typeof(UValue);

            List<TypeReference>? typeReferences = GetKeys_1();
            if (typeReferences == null)
            {
                return default;
            }

            foreach (TypeReference typeReference in typeReferences)
            {
                Type? type_TypeReference_Temp = typeReference?.Type();
                if (type_TypeReference_Temp == null)
                {
                    continue;
                }

                if (!type.IsAssignableFrom(type_TypeReference_Temp))
                {
                    continue;
                }

                List<UValue>? values = base.GetValues<UValue>(typeReference);
                if (values == null)
                {
                    continue;
                }

                foreach (UValue? value in values)
                {
                    if (value == null)
                    {
                        continue;
                    }

                    if (func == null)
                    {
                        return value;
                    }

                    if (func.Invoke(value))
                    {
                        return value;
                    }
                }
            }

            return default;
        }

        /// <summary>
        /// Retrieves the value associated with the specified unique reference.
        /// </summary>
        public UValue? GetValue<UValue>(IUniqueReference? uniqueReference) where UValue : TValue
        {
            if (uniqueReference is null)
            {
                return default;
            }

            return GetValue<UValue>(uniqueReference.TypeReference, uniqueReference);
        }

        /// <summary>
        /// Retrieves values for a specific type reference, optionally requiring an exact match.
        /// </summary>
        public List<UValue>? GetValues<UValue>(TypeReference? key_1, bool exactMath) where UValue : TValue
        {
            if (exactMath)
            {
                return base.GetValues<UValue>(key_1);
            }

            Type? type_TypeReference = key_1?.Type();
            if (type_TypeReference == null)
            {
                return null;
            }

            Type type = typeof(UValue);
            if (!type_TypeReference.IsAssignableFrom(type))
            {
                return null;
            }

            List<UValue> result = [];

            List<TypeReference>? typeReferences = GetKeys_1();
            if (typeReferences == null)
            {
                return result;
            }

            foreach (TypeReference typeReference in typeReferences)
            {
                Type? type_TypeReference_Temp = typeReference?.Type();
                if (type_TypeReference_Temp == null)
                {
                    continue;
                }

                if (!type.IsAssignableFrom(type_TypeReference_Temp))
                {
                    continue;
                }

                if (!type_TypeReference.IsAssignableFrom(type_TypeReference_Temp))
                {
                    continue;
                }

                List<UValue>? values = base.GetValues<UValue>(typeReference);
                if (values != null)
                {
                    result.AddRange(values);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves all values associated with the specified type reference.
        /// </summary>
        public override List<UValue>? GetValues<UValue>(TypeReference? key_1) where UValue : default
        {
            return GetValues<UValue>(key_1, false);
        }

        /// <summary>
        /// Retrieves all values of the specified type from the cluster.
        /// </summary>
        public List<U>? GetValues<U>(Type? type)
        {
            if (type == null)
            {
                return null;
            }

            return GetValues<U>(new TypeReference(type));
        }

        /// <summary>
        /// Retrieves values associated with a collection of unique references.
        /// </summary>
        public List<UValue>? GetValues<UValue>(IEnumerable<IUniqueReference>? uniqueReferences) where UValue : TValue
        {
            if (!TryGetValues(uniqueReferences, out List<UValue>? result))
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Removes the value associated with the specified unique reference.
        /// </summary>
        public bool Remove(IUniqueReference? key_2)
        {
            if (key_2 == null)
            {
                return false;
            }

            List<IUniqueReference>? uniqueReferences = Remove([key_2]);
            return uniqueReferences != null && uniqueReferences.Count > 0;
        }

        /// <summary>
        /// Removes and returns references for a collection of unique references.
        /// </summary>
        public virtual List<IUniqueReference>? Remove(IEnumerable<IUniqueReference>? keys_2)
        {
            if (keys_2 == null)
            {
                return null;
            }

            List<IUniqueReference> result = [];
            foreach (IUniqueReference key_2 in keys_2)
            {
                TypeReference? typeReference = key_2?.TypeReference;
                if (typeReference is null)
                {
                    continue;
                }

                if (Remove(typeReference, key_2))
                {
                    result.Add(key_2!);
                }
            }

            return result;
        }

        /// <summary>
        /// Removes and returns the specified collection of values from the cluster.
        /// </summary>
        public virtual List<UValue>? Remove<UValue>(IEnumerable<UValue>? values) where UValue : TValue
        {
            if (values == null)
            {
                return null;
            }

            List<UValue> result = [];
            foreach (UValue value in values)
            {
                if (value == null)
                {
                    continue;
                }

                if (Remove(Create.UniqueReference(value)))
                {
                    result.Add(value);
                }
            }

            return result;
        }

        /// <summary>
        /// Attempts to retrieve a value associated with the specified unique reference.
        /// </summary>
        public bool TryGetValue<UValue>(IUniqueReference? uniqueReference, out UValue? value) where UValue : TValue
        {
            return TryGetValue(uniqueReference?.TypeReference, uniqueReference, out value);
        }

        /// <summary>
        /// Attempts to retrieve values for a specific type reference, optionally requiring an exact match.
        /// </summary>
        public bool TryGetValues<UValue>(TypeReference? key_1, bool exactMatch, out List<UValue>? values) where UValue : TValue
        {
            values = GetValues<UValue>(key_1, exactMatch);
            return values != null && values.Count != 0;
        }

        /// <summary>
        /// Attempts to retrieve values associated with a collection of unique references.
        /// </summary>
        public bool TryGetValues<UValue>(IEnumerable<IUniqueReference>? uniqueReferences, out List<UValue>? values) where UValue : TValue
        {
            values = null;
            if (uniqueReferences == null)
            {
                return false;
            }

            values = [];
            foreach (IUniqueReference guidReference in uniqueReferences)
            {
                UValue? u = GetValue<UValue>(guidReference);
                if (u != null)
                {
                    values.Add(u);
                }
            }

            return values != null && values.Count != 0;
        }

        protected override TypeReference? GetKey_1(TValue? value)
        {
            if (value == null)
            {
                return null;
            }

            return new TypeReference(value);
        }

        protected override IUniqueReference? GetKey_2(TValue? value)
        {
            if (value == null)
            {
                return null;
            }

            return Create.UniqueReference(value);
        }
    }
}