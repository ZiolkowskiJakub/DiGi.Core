using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation
{
    /// <summary>Provides methods for querying relations.</summary>
    public static partial class Query
    {
        /// <summary>Gets the set of unique references from the relation on the specified side.</summary>
        public static HashSet<IUniqueReference>? UniqueReferences(this IRelation? relation, RelationSide relationSide)
        {
            if (relation == null)
            {
                return null;
            }

            HashSet<IUniqueReference> result = [];

            if (relation is IManyToManyRelation manyToManyRelation)
            {
                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && manyToManyRelation.UniqueReferences_From != null)
                {
                    foreach (IUniqueReference uniqueReference in manyToManyRelation.UniqueReferences_From)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && manyToManyRelation.UniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in manyToManyRelation.UniqueReferences_To)
                    {
                        result.Add(uniqueReference);
                    }
                }
            }
            else if (relation is IOneToManyRelation oneToManyRelation)
            {
                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && oneToManyRelation.UniqueReference_From != null)
                {
                    result.Add(oneToManyRelation.UniqueReference_From);
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && oneToManyRelation.UniqueReferences_To != null)
                {
                    foreach (IUniqueReference uniqueReference in oneToManyRelation.UniqueReferences_To)
                    {
                        result.Add(uniqueReference);
                    }
                }
            }
            else if (relation is IManyToOneRelation manyToOneRelation)
            {
                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && manyToOneRelation.UniqueReferences_From != null)
                {
                    foreach (IUniqueReference uniqueReference in manyToOneRelation.UniqueReferences_From)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && manyToOneRelation.UniqueReference_To != null)
                {
                    result.Add(manyToOneRelation.UniqueReference_To);
                }
            }
            else if (relation is IOneToOneRelation oneToOneRelation)
            {
                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && oneToOneRelation.UniqueReference_From != null)
                {
                    result.Add(oneToOneRelation.UniqueReference_From);
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && oneToOneRelation.UniqueReference_To != null)
                {
                    result.Add(oneToOneRelation.UniqueReference_To);
                }
            }

            return result;
        }
    }
}