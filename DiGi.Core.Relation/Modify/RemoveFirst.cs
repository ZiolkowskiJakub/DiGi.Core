using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation
{
    public static partial class Modify
    {
        public static bool RemoveFirst<T>(this List<T> references, IReference reference) where T : IReference
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
