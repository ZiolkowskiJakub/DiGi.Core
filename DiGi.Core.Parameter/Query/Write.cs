using DiGi.Core.Parameter.Enums;

namespace DiGi.Core.Parameter
{
    public static partial class Query
    {
        public static bool Write(this AccessType accessType)
        {
            return accessType == AccessType.Write || accessType == AccessType.ReadWrite;
        }
    }
}