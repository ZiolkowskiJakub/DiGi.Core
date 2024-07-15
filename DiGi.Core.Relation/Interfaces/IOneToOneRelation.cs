using DiGi.Core.Classes;

namespace DiGi.Core.Relation.Interfaces
{
    public interface IOneToOneRelation : IRelation
    {
        UniqueReference UniqueReference_From { get; }

        UniqueReference UniqueReference_To { get; }
    }
}
