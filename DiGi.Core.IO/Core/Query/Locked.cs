using System;
using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Query
    {
        public static bool Locked(this FileInfo fileInfo)
        {
            if(fileInfo == null)
            {
                return false;
            }

            try
            {
                using (FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    fileStream.Close();
                }
            }
            catch (Exception)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }

            //file is not locked
            return false;
        }
    }
}