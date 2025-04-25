using DiGi.Core.IO.Classes;

namespace DiGi.Core.IO
{
    public static partial class Create
    {
        public static FileFilter FileFilter(string name, params string[] extensions)
        {
            return new FileFilter(name, extensions);
        }

        public static FileFilter FileFilter_AllFiles()
        {
            return FileFilter("All files", "*");
        }
    }
}

