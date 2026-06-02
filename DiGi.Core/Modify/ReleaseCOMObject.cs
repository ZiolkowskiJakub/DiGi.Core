using System.Runtime.InteropServices;

namespace DiGi.Core
{
    public static partial class Modify
    {
        /// <summary>
        /// Releases all references to a COM object.
        /// </summary>
        /// <param name="cOMObject">The COM object to release.</param>
        /// <returns>True if the object was successfully released; otherwise, false.</returns>
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