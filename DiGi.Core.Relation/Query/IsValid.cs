using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;

namespace DiGi.Core.Relation
{
    /// <summary>Provides methods for querying relations.</summary>
    public static partial class Query
    {
        /// <summary>Determines whether the relation is valid for the specified type and side.</summary>
        /// <param name="relation">The relation to validate.</param>
        /// <param name="type">The type to check against.</param>
        /// <param name="relationSide">The side of the relation.</param>
        /// <returns>True if the relation is valid; otherwise, false.</returns>
        public static bool IsValid(this IRelation? relation, System.Type? type, RelationSide relationSide)
        {
            if (relation == null)
            {
                return false;
            }

            if (relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                System.Type? type_Relation = relation.GetType(RelationSide.From);
                if (type_Relation == null && type == null)
                {
                    return true;
                }

                if (type != null && type.IsAssignableFrom(type_Relation))
                {
                    return true;
                }
            }

            if (relationSide == RelationSide.To || relationSide == RelationSide.Undefined)
            {
                System.Type? type_Relation = relation.GetType(RelationSide.To);
                if (type_Relation == null && type == null)
                {
                    return true;
                }

                if (type != null && type_Relation is not null && type_Relation.IsAssignableFrom(type)) //type.IsAssignableFrom(type_Relation)
                {
                    return true;
                }
            }

            return false;
        }
    }
}