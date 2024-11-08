using DiGi.Core.Relation.Interfaces;

namespace DiGi.Core.Relation
{
    public static partial class Query
    {
        public static bool IsValid(this IRelation relation, System.Type type, bool from = true, bool to = true)
        {
            if(relation == null)
            {
                return false;
            }

            if(from)
            {
                System.Type type_Relation = relation.GetType_From();
                if (type_Relation == null && type == null)
                {
                    return true;
                }

                if (type != null && type.IsAssignableFrom(type_Relation))
                {
                    return true;
                }
            }

            if (to)
            {
                System.Type type_Relation = relation.GetType_To();
                if (type_Relation == null && type == null)
                {
                    return true;
                }

                if (type != null && type.IsAssignableFrom(type_Relation))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
