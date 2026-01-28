using System;
using System.ComponentModel;
using System.IO;

namespace DiGi.Core.Classes
{
    [Description("File path or directory")]
    public readonly struct Path
    {
        private readonly string? value;

        public Path(string? value)
        {
            this.value = value;
        }

        public Path(params string[]? values)
        {
            value = null;
            if (values != null && values.Length > 0)
            {
                value = System.IO.Path.Combine(values);
            }
        }

        public Path(Path? path)
        {
            value = path?.value;
        }

        public bool DirectoryExists
        {
            get
            {
                DirectoryInfo? directoryInfo = GetDirectoryInfo();
                if (directoryInfo == null)
                {
                    return false;
                }

                return directoryInfo.Exists;
            }
        }

        public Path? DirectoryPath
        {
            get
            {
                if (value == null)
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

        public string? Extension
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

        public bool FileExists
        {
            get
            {
                FileInfo? fileInfo = GetFileInfo();
                if (fileInfo == null)
                {
                    return false;
                }

                return fileInfo.Exists;
            }
        }

        public string? FileName
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

        public string? FileNameWithoutExtension
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

        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrWhiteSpace(value);
            }
        }

        public static implicit operator Path(string value)
        {
            return new Path(value);
        }

        public static implicit operator string?(Path? path)
        {
            if (path is null || !path.HasValue)
            {
                return null;
            }

            return path.Value.value;
        }

        public static bool operator !=(Path? path_1, Path? path_2)
        {
            if (path_1 is null && path_2 is null)
            {
                return false;
            }

            if (path_1 is null || path_2 is null)
            {
                return true;
            }

            return path_1.Value.value != path_2.Value.value;
        }

        public static Path? operator +(Path? path, string value)
        {
            if (path == null && value == null)
            {
                return null;
            }

            if (value == null)
            {
                return null;
            }

            if (path is null || path.Value == null)
            {
                return new Path(value);
            }

            return new Path(path.Value!, value);
        }

        public static bool operator ==(Path? path_1, Path? path_2)
        {
            if (path_1 is null && path_2 is null)
            {
                return true;
            }

            if (path_1 is null || path_2 is null)
            {
                return false;
            }

            return path_1.Value.value == path_2.Value.value;
        }

        public override bool Equals(object? obj)
        {
            return obj is Path path && value == path.value;
        }

        public DirectoryInfo? GetDirectoryInfo()
        {
            if (!IsValid())
            {
                return null;
            }

            DirectoryInfo? result;
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

        public FileInfo? GetFileInfo()
        {
            if (!IsValid())
            {
                return null;
            }

            FileInfo? result;
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

        public override int GetHashCode()
        {
            return value?.GetHashCode() ?? 0;
        }

        public bool IsValid(UriKind uriKind)
        {
            if (IsEmpty)
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
    }
}