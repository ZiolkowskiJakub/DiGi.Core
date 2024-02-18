using DiGi.Core.Classes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static TypeReference TypeReference(this System.Type type)
        {
            string fullTypeName = Query.FullTypeName(type);
            if(string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            return new TypeReference(fullTypeName);
        }
    }
}
