using DiGi.Core.Parameters.Enums;

namespace DiGi.Core.Parameters
{
    public static partial class Query
    {
        public static bool Write(this AccessType accessType)
        {
            return accessType == AccessType.Write || accessType == AccessType.ReadWrite;
        }
    }
}