using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    /// <summary>Represents a collection of relations.</summary>
    /// <typeparam name="TRelation">The type of relation elements in the collection.</typeparam>
    public class RelationCollection<TRelation> : SerializableObjectCollection<TRelation> where TRelation : IRelation
    {
        /// <summary>Initializes a new instance of the RelationCollection class.</summary>
        public RelationCollection()
            : base()
        {
        }

        /// <summary>Initializes a new instance of the RelationCollection class with the specified relations.</summary>
        /// <param name="relations">The collection of relations to initialize with.</param>
        public RelationCollection(IEnumerable<TRelation>? relations)
            : base(relations)
        {
        }

        /// <summary>Initializes a new instance of the RelationCollection class by copying another RelationCollection.</summary>
        /// <param name="relationCollection">The source collection to copy from.</param>
        public RelationCollection(RelationCollection<TRelation>? relationCollection)
            : base(relationCollection)
        {
        }

        /// <summary>Initializes a new instance of the RelationCollection class from a JSON object.</summary>
        /// <param name="jsonObject">The JSON object to initialize the collection from.</param>
        public RelationCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>Finds the first relation that contains the specified unique reference and optionally matches the predicate.</summary>
        /// <param name="uniqueReference">The unique reference to filter by.</param>
        /// <param name="func">The predicate used to further filter the relations.</param>
        /// <typeparam name="XRelation">The type of relation being searched for.</typeparam>
        /// <returns>The first relation that matches both the unique reference and the predicate, or null if no match is found.</returns>
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

        /// <summary>Finds the first relation that optionally matches the predicate.</summary>
        /// <param name="func">The predicate used to filter the relations.</param>
        /// <typeparam name="XRelation">The type of relation being searched for.</typeparam>
        /// <returns>The first relation that matches the predicate, or null if no match is found.</returns>
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

        /// <summary>Finds all relations that contain the specified unique reference and optionally match the predicate.</summary>
        /// <param name="uniqueReference">The unique reference to filter by.</param>
        /// <param name="func">The predicate used to further filter the relations.</param>
        /// <typeparam name="XRelation">The type of relation being searched for.</typeparam>
        /// <returns>A list of relations that match both the unique reference and the predicate, or null if no matches are found.</returns>
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

        /// <summary>Finds all relations that optionally match the predicate.</summary>
        /// <param name="func">The predicate used to filter the relations.</param>
        /// <typeparam name="XRelation">The type of relation being searched for.</typeparam>
        /// <returns>A list of relations that match the predicate, or null if no matches are found.</returns>
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

        /// <summary>Removes all relations that contain the specified unique reference.</summary>
        /// <param name="uniqueReference">The unique reference of the relations to remove.</param>
        /// <returns>True if one or more relations were removed; otherwise, false.</returns>
        public bool Remove(IUniqueReference? uniqueReference)
        {
            if (uniqueReference == null)
            {
                return false;
            }

            int count = Count;

            bool result = false;
            for (int i = count - 1; i >= 0; i--)
            {
                TRelation relation = this[i];
                if (relation == null)
                {
                    continue;
                }

                if (relation.Remove(Enums.RelationSide.Undefined, uniqueReference))
                {
                    result = true;
                    if (!relation.Has(Enums.RelationSide.From) || !relation.Has(Enums.RelationSide.To))
                    {
                        RemoveAt(i);
                    }
                }
            }

            return result;
        }
    }
}