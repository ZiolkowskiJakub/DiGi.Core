using DiGi.Core.Relation.Enums;
using DiGi.Core.Relation.Interfaces;

namespace DiGi.Core.Relation
{
    public static partial class Query
    {
        public static bool IsValid(this IRelation relation, System.Type type, RelationSide relationSide)
        {
            if(relation == null)
            {
                return false;
            }

            if(relationSide == RelationSide.From || relationSide == RelationSide.Undefined)
            {
                System.Type type_Relation = relation.GetType(RelationSide.From);
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
                System.Type type_Relation = relation.GetType(RelationSide.To);
                if (type_Relation == null && type == null)
                {
                    return true;
                }

                if (type != null && type_Relation.IsAssignableFrom(type)) //type.IsAssignableFrom(type_Relation)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
