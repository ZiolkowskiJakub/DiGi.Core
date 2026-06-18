using DiGi.Core.Classes;

namespace DiGi.Core.Interfaces
{
    /// <summary>
    /// Defines a contract for objects that can hold and manage metadata tag.
    /// </summary>
    public interface ITaggable
    {
        /// <summary>
        /// Gets tag associated with this object.
        /// </summary>
        Tag Tag { get; set; }
    }
}