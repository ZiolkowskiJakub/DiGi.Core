using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation
{
    /// <summary>Provides methods for modifying relations.</summary>
    public static partial class Modify
    {
        /// <summary>Removes the first occurrence of the specified reference from the list.</summary>
        public static bool RemoveFirst<TReference>(this List<TReference>? references, IReference? reference) where TReference : IReference
        {
            if (references == null || reference == null)
            {
                return false;
            }

            int count = references.Count;

            for (int i = 0; i < count; i++)
            {
                if (!reference.Equals(references[i]))
                {
                    continue;
                }

                references.RemoveAt(i);
                return true;
            }

            return false;
        }
    }
}