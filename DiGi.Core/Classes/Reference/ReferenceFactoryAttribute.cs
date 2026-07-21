using System;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Marks a public static method as the factory that rebuilds a reference type from the segments of its string
    /// form, and declares the discriminator that type is written with.
    /// <para>The method must have the signature
    /// <c>public static IReference? Name(IReadOnlyList&lt;string?&gt;? segments)</c> and must consume exactly the
    /// segments that the type's <c>Segments</c> property declares, in the same order. Those two together are the
    /// round-trip contract.</para>
    /// <para>Factories are discovered reflectively, which is what lets DiGi.Core parse reference types defined in
    /// repositories it cannot reference. Place the factory in the repository that owns the reference type.</para>
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="ReferenceFactoryAttribute"/> class.
    /// </remarks>
    /// <param name="referenceType">The concrete reference type this factory creates.</param>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class ReferenceFactoryAttribute(Type referenceType) : Attribute
    {
        /// <summary>
        /// Gets the concrete reference type this factory creates.
        /// </summary>
        public Type ReferenceType { get; } = referenceType;

        /// <summary>
        /// Gets or sets the short discriminator token this reference type is written with.
        /// <para>Kind tokens share one flat namespace across every repository and are a persisted contract: they are
        /// append-only, must be unique, and must contain neither a comma nor a colon. When left null the type falls
        /// back to being written with its assembly-qualified full type name.</para>
        /// </summary>
        public string? Kind { get; set; }
    }
}