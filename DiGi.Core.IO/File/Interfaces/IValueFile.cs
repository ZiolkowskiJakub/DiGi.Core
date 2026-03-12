namespace DiGi.Core.IO.File.Interfaces
{
    public interface IValueFile : IFile
    {
    }

    public interface IValueFile<T> : IValueFile
    {
        T? Value { get; set; }
    }
}