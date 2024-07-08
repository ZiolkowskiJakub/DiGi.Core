using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using DiGi.Core.Relation.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.Relation.Classes
{
    public class RelationCollection : SerializableObjectCollection<IRelation>
    {
        public RelationCollection() 
            :base()
        { 
        }

        public RelationCollection(IEnumerable<IRelation> relations)
            : base(relations)
        {
        }

        public RelationCollection(RelationCollection relationCollection)
            : base(relationCollection)
        {
        }

        public RelationCollection(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        public bool Remove(UniqueReference uniqueReference)
        {
            if(uniqueReference == null)
            {
                return false;
            }

            int count = Count;

            bool result = false;
            for (int i = count; i >= 0; i--)
            {
                IRelation relation = this[i];
                if (relation == null || !relation.Contains(uniqueReference))
                {
                    continue;
                }

                if (relation is IOneToOneRelation)
                {
                    RemoveAt(i);
                    result = true;
                    continue;
                }

                throw new System.NotImplementedException();
            }

            return result;
        }

        public List<T> FindAll<T>(UniqueReference uniqueReference) where T : IRelation
        {
            if(uniqueReference == null)
            {
                return null;
            }

            List<T> result = new List<T>();
            foreach(IRelation relation in this)
            {
                T t = relation is T ? (T)relation : default;
                if(t == null || !t.Contains(uniqueReference))
                {
                    continue;
                }

                result.Add(t);
            }

            return result;
        }

    }
}
