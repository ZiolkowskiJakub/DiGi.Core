using System;
using System.ComponentModel;
using System.IO;

namespace DiGi.Core.Classes
{
    [Description("File path or directory")]
    public struct Path
    {
        private string value;

        public Path(string value)
        {
            this.value = value; 
        }

        public Path(params string[] values)
        {
            value = null;
            if(values != null && values.Length > 0)
            {
                value = System.IO.Path.Combine(values);
            }
        }


        public static implicit operator Path(string value)
        {
            return new Path(value);
        }


        public static implicit operator string(Path path)
        {
            if(path == null)
            {
                return null;
            }

            return path.value;
        }
        
        public static bool operator !=(Path path_1, Path path_2)
        {
            if (ReferenceEquals(path_1, null) && ReferenceEquals(path_2, null))
            {
                return false;
            }

            if (ReferenceEquals(path_1, null) || ReferenceEquals(path_2, null))
            {
                return true;
            }

            return path_1.value != path_2.value;
        }

        public static bool operator ==(Path path_1, Path path_2)
        {
            if (ReferenceEquals(path_1, null) && ReferenceEquals(path_2, null))
            {
                return true;
            }

            if (ReferenceEquals(path_1, null) || ReferenceEquals(path_2, null))
            {
                return false;
            }

            return path_1.value == path_2.value;
        }

        public static Path operator +(Path path, string value)
        {
            if(path == null && value == null)
            {
                return null;
            }

            if(value == null)
            {
                return null;
            }

            return new Path(path, value);
        }

        public Path? DirectoryPath
        {
            get
            {
                if(value == null)
                {
                    return null;
                }

                string result = System.IO.Path.GetDirectoryName(value);

                if (string.IsNullOrWhiteSpace(result))
                {
                    return null;
                }

                return result;
            }
        }

        public string FileName
        {
            get
            {
                if (value == null)
                {
                    return null;
                }

                return System.IO.Path.GetFileName(value);
            }
        }

        public string FileNameWithoutExtension
        {
            get
            {
                if (value == null)
                {
                    return null;
                }

                return System.IO.Path.GetFileNameWithoutExtension(value);
            }
        }

        public string Extension
        {
            get
            {
                if (value == null)
                {
                    return null;
                }

                return System.IO.Path.GetExtension(value);
            }
        }

        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrWhiteSpace(value);
            }
        }

        public bool IsValid(UriKind uriKind)
        {
            if(IsEmpty)
            {
                return false;
            }

            bool isValid = Uri.TryCreate(value, uriKind, out Uri uri);
            return isValid && uri != null;
        }

        public bool IsValid()
        {
            return IsValid(UriKind.RelativeOrAbsolute);
        }

        public FileInfo GetFileInfo()
        {
            if(!IsValid())
            {
                return null;
            }

            FileInfo result = null;
            try
            {
                result = new FileInfo(value);
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public DirectoryInfo GetDirectoryInfo()
        {
            if (!IsValid())
            {
                return null;
            }

            DirectoryInfo result = null;
            try
            {
                result = new DirectoryInfo(value);
            }
            catch
            {
                result = null;
            }

            return result;
        }

        public bool FileExists
        {
            get
            {
                FileInfo fileInfo = GetFileInfo();
                if(fileInfo == null)
                {
                    return false;
                }

                return fileInfo.Exists;
            }
        }

        public bool DirectoryExists
        {
            get
            {
                DirectoryInfo directoryInfo = GetDirectoryInfo();
                if (directoryInfo == null)
                {
                    return false;
                }

                return directoryInfo.Exists;
            }
        }

    }
}
