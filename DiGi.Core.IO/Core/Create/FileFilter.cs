using DiGi.Core.IO.Classes;

namespace DiGi.Core.IO
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a file filter with the specified name and allowed extensions.
        /// </summary>
        public static FileFilter FileFilter(string name, params string[] extensions)
        {
            return new FileFilter(name, extensions);
        }

        /// <summary>
        /// Creates a file filter that includes all files.
        /// </summary>
        public static FileFilter FileFilter_AllFiles()
        {
            return FileFilter("All files", "*");
        }
    }
}