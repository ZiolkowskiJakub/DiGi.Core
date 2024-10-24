namespace DiGi.Core
{
    public static partial class Query
    {
        public static bool TryGetUniqueId(this object @object, out string uniqueId)
        {
            uniqueId = null;

            if (@object == null)
            {
                return false;
            }

            uniqueId = UniqueId(@object as dynamic);
            return uniqueId != null;
        }
    }
}