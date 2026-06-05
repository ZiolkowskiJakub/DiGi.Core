using DiGi.Core.IO.Classes;

namespace DiGi.Core.IO
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a file filter with the specified name and allowed extensions.
        /// </summary>
        /// <param name="name">The descriptive name of the filter.</param>
        /// <param name="extensions">An array of allowed file extensions.</param>
        /// <returns>A FileFilter configured with the specified name and extensions.</returns>
        public static FileFilter FileFilter(string name, params string[] extensions)
        {
            return new FileFilter(name, extensions);
        }

        /// <summary>
        /// Creates a file filter that includes all files.
        /// </summary>
        /// <returns>A FileFilter that matches all files.</returns>
        public static FileFilter FileFilter_AllFiles()
        {
            return FileFilter("All files", "*");
        }
    }
}