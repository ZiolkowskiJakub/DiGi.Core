using System.Runtime.InteropServices;

namespace DiGi.Core
{
    public static partial class Modify
    {
        public static bool ReleaseCOMObject(this object? cOMObject)
        {
            if (cOMObject == null)
            {
                return false;
            }

            int referenceCount;
            do
            {
                referenceCount = Marshal.FinalReleaseComObject(cOMObject);
            }
            while (referenceCount > 0);

            return true;
        }
    }
}
