﻿using DiGi.Core.Classes;
using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Relation
{
    public static partial class Query
    {
        public static HashSet<UniqueReference> UniqueReferences(this IRelation relation, RelationSide relationSide)
        {
            if(relation == null)
            {
                return null;
            }

            HashSet<UniqueReference> result = new HashSet<UniqueReference>();


            if (relation is IManyToManyRelation)
            {
                IManyToManyRelation manyToManyRelation = (IManyToManyRelation)relation;

                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && manyToManyRelation.UniqueReferences_From != null)
                {
                    foreach(UniqueReference uniqueReference in manyToManyRelation.UniqueReferences_From)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && manyToManyRelation.UniqueReferences_To != null)
                {
                    foreach (UniqueReference uniqueReference in manyToManyRelation.UniqueReferences_To)
                    {
                        result.Add(uniqueReference);
                    }
                }
            }
            else if (relation is IOneToManyRelation)
            {
                IOneToManyRelation oneToManyRelation = (IOneToManyRelation)relation;

                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && oneToManyRelation.UniqueReference_From != null)
                {
                    result.Add(oneToManyRelation.UniqueReference_From);
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && oneToManyRelation.UniqueReferences_To != null)
                {
                    foreach (UniqueReference uniqueReference in oneToManyRelation.UniqueReferences_To)
                    {
                        result.Add(uniqueReference);
                    }
                }
            }
            else if (relation is IManyToOneRelation)
            {
                IManyToOneRelation manyToOneRelation = (IManyToOneRelation)relation;

                if ((relationSide == RelationSide.From || relationSide == RelationSide.Undefined) && manyToOneRelation.UniqueReferences_From != null)
                {
                    foreach (UniqueReference uniqueReference in manyToOneRelation.UniqueReferences_From)
                    {
                        result.Add(uniqueReference);
                    }
                }

                if ((relationSide == RelationSide.To || relationSide == RelationSide.Undefined) && manyToOneRelation.UniqueReference_To != null)
                {
                    result.Add(manyToOneRelation.UniqueReference_To);
                }
            }
            else if (relation is IOneToOneRelation)
            {
                IOneToOneRelation oneToOneRelation = (IOneToOneRelation)relation;

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
