using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Encapsulates the logic to rebuild an <see cref="IReference"/> from the segments of its string form, using a
    /// method marked with <see cref="ReferenceFactoryAttribute"/>.
    /// </summary>
    public class ReferenceConstructor
    {
        private readonly string? fullTypeName;
        private readonly string? kind;
        private readonly MethodInfo? methodInfo;
        private readonly Type? referenceType;
        private readonly bool valid;

        internal ReferenceConstructor(Type? referenceType, string? fullTypeName, string? kind, MethodInfo? methodInfo)
        {
            this.referenceType = referenceType;
            this.fullTypeName = fullTypeName;
            this.kind = kind;
            this.methodInfo = methodInfo;

            if (referenceType != null && methodInfo != null && methodInfo.IsStatic)
            {
                ParameterInfo[] parameterInfos = methodInfo.GetParameters();
                if (parameterInfos.Length == 1
                    && parameterInfos[0].ParameterType == typeof(IReadOnlyList<string?>)
                    && typeof(IReference).IsAssignableFrom(methodInfo.ReturnType))
                {
                    valid = true;
                }
            }
        }

        /// <summary>
        /// Gets the assembly-qualified full type name of the reference type this constructor creates.
        /// </summary>
        public string? FullTypeName
        {
            get
            {
                return fullTypeName;
            }
        }

        /// <summary>
        /// Gets the short discriminator token this reference type is written with, or null when it falls back to
        /// <see cref="FullTypeName"/>.
        /// </summary>
        public string? Kind
        {
            get
            {
                return kind;
            }
        }

        /// <summary>
        /// Gets the reference type this constructor creates.
        /// </summary>
        public Type? ReferenceType
        {
            get
            {
                return referenceType;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the factory method matches the required signature.
        /// </summary>
        public bool Valid
        {
            get
            {
                return valid;
            }
        }

        /// <summary>
        /// Gets the discriminator this reference type is written with: its <see cref="Kind"/> when declared,
        /// otherwise its <see cref="FullTypeName"/>.
        /// </summary>
        public string? Discriminator
        {
            get
            {
                return string.IsNullOrWhiteSpace(kind) ? fullTypeName : kind;
            }
        }

        /// <summary>
        /// Rebuilds the reference from its segments.
        /// </summary>
        /// <param name="segments">The segments, in the order declared by the type's Segments property.</param>
        /// <returns>The reference, or null when the segments do not describe a valid instance.</returns>
        public IReference? Create(IReadOnlyList<string?>? segments)
        {
            if (!valid || methodInfo == null)
            {
                return null;
            }

            // A factory is reached from arbitrary, possibly malformed input. Callers use the Try pattern, so a
            // factory that throws must surface as a failed parse rather than as an exception.
            try
            {
                return methodInfo.Invoke(null, [segments]) as IReference;
            }
            catch (TargetInvocationException)
            {
                return null;
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
    }
}