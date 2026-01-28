using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationCollection<TRelation> : SerializableObjectCollection<TRelation> where TRelation : IRelation
    {
        public RelationCollection()
            : base()
        {
        }

        public RelationCollection(IEnumerable<TRelation>? relations)
            : base(relations)
        {
        }

        public RelationCollection(RelationCollection<TRelation>? relationCollection)
            : base(relationCollection)
        {
        }

        public RelationCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public XRelation? Find<XRelation>(IUniqueReference? uniqueReference, Func<XRelation?, bool>? func = null) where XRelation : TRelation
        {
            if (uniqueReference == null)
            {
                return default;
            }

            foreach (TRelation relation in this)
            {
                XRelation? x = relation is XRelation xRelation ? xRelation : default;
                if (x == null || !x.Contains(Enums.RelationSide.Undefined, uniqueReference))
                {
                    continue;
                }

                if (func != null)
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

        public XRelation? Find<XRelation>(Func<XRelation?, bool>? func = null) where XRelation : TRelation
        {
            foreach (TRelation relation in this)
            {
                XRelation? x = relation is XRelation x_Temp ? x_Temp : default;
                if (x == null)
                {
                    continue;
                }

                if (func != null)
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

        public List<XRelation>? FindAll<XRelation>(IUniqueReference? uniqueReference, Func<XRelation?, bool>? func = null) where XRelation : TRelation
        {
            if (uniqueReference == null)
            {
                return null;
            }

            List<XRelation> result = [];
            foreach (TRelation relation in this)
            {
                XRelation? x = relation is XRelation xRelation ? xRelation : default;
                if (x == null || !x.Contains(Enums.RelationSide.Undefined, uniqueReference))
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

        public List<XRelation>? FindAll<XRelation>(Func<XRelation?, bool>? func = null) where XRelation : TRelation
        {
            List<XRelation> result = [];
            foreach (TRelation relation in this)
            {
                XRelation? x = relation is XRelation xRelation ? xRelation : default;
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

        public bool Remove(IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            int count = Count;

            bool result = false;
            for (int i = count; i >= 0; i--)
            {
                TRelation relation = this[i];
                if (relation == null || !relation.Contains(Enums.RelationSide.Undefined, uniqueReference))
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
    }
}