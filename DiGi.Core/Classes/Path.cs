using System;
using System.ComponentModel;
using System.IO;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a file system path or directory and provides utilities for manipulating and validating it.
    /// </summary>
    [Description("File path or directory")]
    public readonly struct Path
    {
        private readonly string? value;

        /// <summary>
        /// Initializes a new instance of the Path struct with a specified path string.
        /// </summary>
        /// <param name="value">The path string.</param>
        public Path(string? value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the Path struct by combining multiple path segments.
        /// </summary>
        /// <param name="values">The path segments to combine.</param>
        public Path(params string[]? values)
        {
            value = null;
            if (values != null && values.Length > 0)
            {
                value = System.IO.Path.Combine(values);
            }
        }

        /// <summary>
        /// Initializes a new instance of the Path struct by copying another Path.
        /// </summary>
        /// <param name="path">The source path.</param>
        public Path(Path? path)
        {
            value = path?.value;
        }

        /// <summary>
        /// Gets a value indicating whether the current path refers to an existing directory.
        /// </summary>
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

        /// <summary>
        /// Gets a new Path representing the directory component of the current path.
        /// </summary>
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

        /// <summary>
        /// Gets the extension of the path, including the period ('.').
        /// </summary>
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

        /// <summary>
        /// Gets a value indicating whether the current path refers to an existing file.
        /// </summary>
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

        /// <summary>
        /// Gets the file name and extension of the path.
        /// </summary>
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

        /// <summary>
        /// Gets the file name of the path without the extension.
        /// </summary>
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

        /// <summary>
        /// Gets a value indicating whether the path is null or empty.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return string.IsNullOrWhiteSpace(value);
            }
        }

        /// <summary>
        /// Implicitly converts a string to a Path.
        /// </summary>
        public static implicit operator Path(string value)
        {
            return new Path(value);
        }

        /// <summary>
        /// Implicitly converts a Path to its underlying string value.
        /// </summary>
        public static implicit operator string?(Path? path)
        {
            if (path is null || !path.HasValue)
            {
                return null;
            }

            return path.Value.value;
        }

        /// <summary>
        /// Determines whether two Path instances are unequal.
        /// </summary>
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

        /// <summary>
        /// Combines the current Path with another string segment to create a new Path.
        /// </summary>
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

        /// <summary>
        /// Determines whether two Path instances are equal.
        /// </summary>
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

        /// <summary>
        /// Determines whether the specified object is equal to the current Path.
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Path path && value == path.value;
        }

        /// <summary>
        /// Retrieves a DirectoryInfo object for the current path, if valid.
        /// </summary>
        /// <returns>A DirectoryInfo object or null if the path is invalid.</returns>
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

        /// <summary>
        /// Retrieves a FileInfo object for the current path, if valid.
        /// </summary>
        /// <returns>A FileInfo object or null if the path is invalid.</returns>
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

        /// <summary>
        /// Returns the hash code for this Path.
        /// </summary>
        public override int GetHashCode()
        {
            return value?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Validates whether the path is a valid URI of the specified kind.
        /// </summary>
        /// <param name="uriKind">The type of URI to validate against.</param>
        /// <returns>True if valid; otherwise, false.</returns>
        public bool IsValid(UriKind uriKind)
        {
            if (IsEmpty)
            {
                return false;
            }

            bool isValid = Uri.TryCreate(value, uriKind, out Uri uri);
            return isValid && uri != null;
        }

        /// <summary>
        /// Validates whether the path is a valid URI (relative or absolute).
        /// </summary>
        /// <returns>True if valid; otherwise, false.</returns>
        public bool IsValid()
        {
            return IsValid(UriKind.RelativeOrAbsolute);
        }
    }
}