using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a value cluster that ensures uniqueness of its contained objects.
    /// </summary>
    /// <typeparam name="TValue">The type of values contained in the cluster.</typeparam>
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
        /// <param name="values">The collection of values to initialize the cluster with.</param>
        public UniqueObjectValueCluster(IEnumerable<TValue>? values)
            : base(values)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class from another unique object value cluster.
        /// </summary>
        /// <param name="uniqueObjectValueCluster">The unique object value cluster to copy from.</param>
        public UniqueObjectValueCluster(UniqueObjectValueCluster<TValue>? uniqueObjectValueCluster)
            : base(uniqueObjectValueCluster)
        {
        }

        /// <summary>
        /// Initializes a new instance of the UniqueObjectValueCluster class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object used to initialize the cluster.</param>
        public UniqueObjectValueCluster(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Determines whether the cluster contains an element with the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference to locate in the cluster.</param>
        /// <returns>True if the cluster contains an element with the specified unique reference; otherwise, false.</returns>
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
        /// <returns>A list of type references present in the cluster, or null if none exist.</returns>
        public List<TypeReference>? GetTypeReferences()
        {
            return GetKeys_1();
        }

        /// <summary>
        /// Retrieves the first value that satisfies the specified predicate.
        /// </summary>
        /// <typeparam name="UValue">The type of the value to retrieve.</typeparam>
        /// <param name="func">The predicate used to determine if a value satisfies the condition.</param>
        /// <returns>The first value that satisfies the predicate, or null if no such value is found.</returns>
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
        /// <typeparam name="UValue">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference for which to retrieve the value.</param>
        /// <returns>The value associated with the specified unique reference, or null if not found.</returns>
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
        /// <typeparam name="UValue">The type of the values to retrieve.</typeparam>
        /// <param name="key_1">The type reference used to identify the values.</param>
        /// <param name="exactMath">A value indicating whether an exact match is required for the retrieval.</param>
        /// <returns>A list of values associated with the specified type reference, or null if none are found.</returns>
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
        /// <typeparam name="UValue">The type of the values to retrieve.</typeparam>
        /// <param name="key_1">The type reference used to identify the values.</param>
        /// <returns>A list of values associated with the specified type reference, or null if none are found.</returns>
        public override List<UValue>? GetValues<UValue>(TypeReference? key_1) where UValue : default
        {
            return GetValues<UValue>(key_1, false);
        }

        /// <summary>
        /// Retrieves all values of the specified type from the cluster.
        /// </summary>
        /// <typeparam name="U">The type of the values to retrieve.</typeparam>
        /// <param name="type">The type used to filter the values in the cluster.</param>
        /// <returns>A list of values of the specified type, or null if no such values exist.</returns>
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
        /// <typeparam name="UValue">The type of the values to retrieve.</typeparam>
        /// <param name="uniqueReferences">A collection of unique references to look up.</param>
        /// <returns>A list of values associated with the provided unique references, or null if no values are found.</returns>
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
        /// <param name="key_2">The unique reference of the value to remove.</param>
        /// <returns>True if the value was successfully removed; otherwise, false.</returns>
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
        /// <param name="keys_2">The collection of unique references to be removed.</param>
        /// <returns>A list containing the references that were actually removed, or null if no references were removed.</returns>
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
        /// <typeparam name="UValue">The type of the values to remove.</typeparam>
        /// <param name="values">The collection of values to be removed from the cluster.</param>
        /// <returns>A list containing the values that were actually removed, or null if no values were removed.</returns>
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
        /// <typeparam name="UValue">The type of the value to retrieve.</typeparam>
        /// <param name="uniqueReference">The unique reference used to look up the value.</param>
        /// <param name="value">When this method returns, contains the retrieved value if successful; otherwise, the default value for <typeparamref name="UValue"/>.</param>
        /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
        public bool TryGetValue<UValue>(IUniqueReference? uniqueReference, out UValue? value) where UValue : TValue
        {
            return TryGetValue(uniqueReference?.TypeReference, uniqueReference, out value);
        }

        /// <summary>
        /// Attempts to retrieve values for a specific type reference, optionally requiring an exact match.
        /// </summary>
        /// <typeparam name="UValue">The type of the values to retrieve.</typeparam>
        /// <param name="key_1">The type reference used as the key for retrieval.</param>
        /// <param name="exactMatch">A boolean indicating whether an exact match is required.</param>
        /// <param name="values">When this method returns, contains the retrieved values if successful; otherwise, null.</param>
        /// <returns>True if one or more values were successfully retrieved; otherwise, false.</returns>
        public bool TryGetValues<UValue>(TypeReference? key_1, bool exactMatch, out List<UValue>? values) where UValue : TValue
        {
            values = GetValues<UValue>(key_1, exactMatch);
            return values != null && values.Count != 0;
        }

        /// <summary>
        /// Attempts to retrieve values associated with a collection of unique references.
        /// </summary>
        /// <typeparam name="UValue">The type of the values to retrieve.</typeparam>
        /// <param name="uniqueReferences">A collection of unique references to look up.</param>
        /// <param name="values">When this method returns, contains the retrieved values if successful; otherwise, null.</param>
        /// <returns>True if one or more values were successfully retrieved; otherwise, false.</returns>
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