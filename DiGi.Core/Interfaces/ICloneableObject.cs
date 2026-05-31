namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for objects that can be cloned.</summary>
    public interface ICloneableObject : IObject
    {
    }

    /// <summary>Defines a generic contract for objects that can be cloned into a specific type.</summary>
    /// <typeparam name="TCloneableObject">The type of the clone.</typeparam>
    public interface ICloneableObject<out TCloneableObject> : ICloneableObject where TCloneableObject : ICloneableObject<TCloneableObject>
    {
        /// <summary>Creates a clone of the current object.</summary>
        /// <returns>A cloned instance of the object.</returns>
        TCloneableObject? Clone();
    }
}