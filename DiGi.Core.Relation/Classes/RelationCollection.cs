using DiGi.Core.Classes;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationCollection<T> : SerializableObjectCollection<T> where T : IRelation
    {
        public RelationCollection() 
            :base()
        { 
        }

        public RelationCollection(IEnumerable<T> relations)
            : base(relations)
        {
        }

        public RelationCollection(RelationCollection<T> relationCollection)
            : base(relationCollection)
        {
        }

        public RelationCollection(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            int count = Count;

            bool result = false;
            for (int i = count; i >= 0; i--)
            {
                T relation = this[i];
                if (relation == null || !relation.Contains(uniqueReference))
                {
                    continue;
                }

                if (relation is IOneToOneRelation)
                {
                    RemoveAt(i);
                    result = true;
                    continue;
                }

                throw new NotImplementedException();
            }

            return result;
        }

        public bool Remove(T relation)
        {
            if (relation == null)
            {
                return false;
            }

            return Remove(relation);
        }

        public List<X> FindAll<X>(UniqueReference uniqueReference, Func<X, bool> func = null) where X : T
        {
            if (uniqueReference == null)
            {
                return null;
            }

            List<X> result = new List<X>();
            foreach (T relation in this)
            {
                X x = relation is X ? (X)relation : default;
                if (x == null || !x.Contains(uniqueReference))
                {
                    continue;
                }

                if (func != null && !func.Invoke(x))
                {
                    continue;
                }

                result.Add(x);
            }

            return result;
        }

        public List<X> FindAll<X>(Func<X, bool> func = null) where X : T
        {
            List<X> result = new List<X>();
            foreach (T relation in this)
            {
                X x = relation is X ? (X)relation : default;
                if (x == null)
                {
                    continue;
                }

                if (func != null && !func.Invoke(x))
                {
                    continue;
                }

                result.Add(x);
            }

            return result;
        }

        public X Find<X>(UniqueReference uniqueReference, Func<X, bool> func = null) where X : T
        {
            if (uniqueReference == null)
            {
                return default;
            }

            foreach (T relation in this)
            {
                X x = relation is X ? (X)relation : default;
                if (x == null || !x.Contains(uniqueReference))
                {
                    continue;
                }

                if(func != null)
                {
                    if (func.Invoke(x))
                    {
                        return x;
                    }

                    continue;
                }

                return x;
            }

            return default;
        }

        public X Find<X>(Func<X, bool> func = null) where X : T
        {
            foreach (T relation in this)
            {
                X x = relation is X ? (X)relation : default;
                if (x == null)
                {
                    continue;
                }

                if (func != null )
                {
                    if(func.Invoke(x))
                    {
                        return x;
                    }

                    continue;
                }

                return x;
            }

            return default;
        }

    }
}
