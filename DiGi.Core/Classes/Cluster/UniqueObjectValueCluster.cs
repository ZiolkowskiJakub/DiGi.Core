using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class UniqueObjectValueCluster<TValue> : SerializableObjectValueCluster<TypeReference, UniqueReference, TValue> where TValue : IUniqueObject
    {
        public UniqueObjectValueCluster()
            : base()
        {
        }

        public UniqueObjectValueCluster(IEnumerable<TValue> values)
            : base(values)
        {
        }

        public UniqueObjectValueCluster(UniqueObjectValueCluster<TValue> uniqueObjectValueCluster)
            : base(uniqueObjectValueCluster)
        {
        }

        public UniqueObjectValueCluster(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public virtual bool Remove(UniqueReference key_2)
        {
            TypeReference typeReference = key_2?.TypeReference;
            if (typeReference == null)
            {
                return false;
            }

            return Remove(typeReference, key_2);
        }

        protected override TypeReference GetKey_1(TValue value)
        {
            if (value == null)
            {
                return null;
            }

            return new TypeReference(value);
        }

        protected override UniqueReference GetKey_2(TValue value)
        {
            if (value == null)
            {
                return null;
            }

            return new UniqueReference(value);
        }

        public List<TypeReference> GetTypeReferences()
        {
            return GetKeys_1();
        }

        public List<U> GetValues<U>(TypeReference key_1, bool exactMath) where U : TValue
        {
            if (exactMath)
            {
                return base.GetValues<U>(key_1);
            }

            Type type_TypeReference = key_1?.Type();
            if (type_TypeReference == null)
            {
                return null;
            }

            Type type = typeof(U);
            if (!type_TypeReference.IsAssignableFrom(type))
            {
                return null;
            }

            List<U> result = new List<U>();

            List<TypeReference> typeReferences = GetKeys_1();
            if (typeReferences == null)
            {
                return result;
            }

            foreach (TypeReference typeReference in typeReferences)
            {
                Type type_TypeReference_Temp = typeReference?.Type();
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

                List<U> values = base.GetValues<U>(typeReference);
                if (values != null)
                {
                    result.AddRange(values);
                }
            }

            return result;
        }

        public bool TryGetValues<U>(TypeReference key_1, bool exactMatch, out List<U> values) where U : TValue
        {
            values = GetValues<U>(key_1, exactMatch);
            return values != null && values.Count != 0;
        }

        public override List<U> GetValues<U>(TypeReference key_1)
        {
            return GetValues<U>(key_1, false);
        }

        public List<U> GetValues<U>(Type type)
        {
            if (type == null)
            {
                return null;
            }

            return GetValues<U>(new TypeReference(type));
        }

        public override U GetValue<U>(Func<U, bool> func)
        {
            Type type = typeof(U);

            List<TypeReference> typeReferences = GetKeys_1();
            if (typeReferences == null)
            {
                return default;
            }

            foreach (TypeReference typeReference in typeReferences)
            {
                Type type_TypeReference_Temp = typeReference?.Type();
                if (type_TypeReference_Temp == null)
                {
                    continue;
                }

                if (!type.IsAssignableFrom(type_TypeReference_Temp))
                {
                    continue;
                }

                List<U> values = base.GetValues<U>(typeReference);
                if (values == null)
                {
                    continue;
                }

                foreach (U value in values)
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

        public U GetValue<U>(UniqueReference uniqueReference) where U : TValue
        {
            return GetValue<U>(uniqueReference.TypeReference, uniqueReference);
        }

        public bool TryGetValue<U>(UniqueReference uniqueReference, out U value) where U : TValue
        {
            return TryGetValue(uniqueReference?.TypeReference, uniqueReference, out value);
        }

        public bool TryGetValues<U>(IEnumerable<UniqueReference> uniqueReferences, out List<U> values) where U : TValue
        {
            values = null;
            if(uniqueReferences == null)
            {
                return false;
            }

            values = new List<U>();
            foreach(UniqueReference uniqueReference in uniqueReferences)
            {
                U u = GetValue<U>(uniqueReference);
                if(u != null)
                {
                    values.Add(u);
                }
            }

            return values != null && values.Count != 0;
        }

        public bool Contains(UniqueReference uniqueReference)
        {
            TypeReference typeReference = uniqueReference?.TypeReference;
            if(typeReference == null)
            {
                return false;
            }

            return Contains(typeReference, uniqueReference);
        }
    }
}
