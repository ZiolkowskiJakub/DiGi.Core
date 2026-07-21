using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>
        /// Combines two references into a single <see cref="ComplexReference"/> whose steps are those of
        /// <paramref name="reference_Base"/> followed by those of <paramref name="reference"/>.
        /// <para>The result is flattened, not nested: when either operand is itself a <see cref="ComplexReference"/>,
        /// its steps are spread into the chain rather than added as one step, so combining two paths concatenates them
        /// (A then B then C then D), never produces a path of paths.</para>
        /// <para>A null operand is treated as an empty chain and the other operand is returned unchanged - so
        /// combining with null is a no-op that does not wrap the surviving operand in a new
        /// <see cref="ComplexReference"/>.</para>
        /// </summary>
        /// <param name="reference_Base">The reference whose steps come first. May be null.</param>
        /// <param name="reference">The reference whose steps come second. May be null.</param>
        /// <returns>
        /// A <see cref="ComplexReference"/> combining both operands; the sole non-null operand when the other is null;
        /// null when both operands are null, or when a non-null operand is an <see cref="IReference"/> that is not an
        /// <see cref="ISerializableReference"/> (such as a list cluster reference) and therefore cannot be a step.
        /// </returns>
        public static IReference? Reference(this IReference? reference_Base, IReference? reference)
        {
            if (reference_Base is null)
            {
                return reference;
            }

            if (reference is null)
            {
                return reference_Base;
            }

            if (reference_Base is not ISerializableReference serializableReference_Base || reference is not ISerializableReference serializableReference)
            {
                return null;
            }

            List<ISerializableReference> serializableReferences;

            if (serializableReference_Base is ComplexReference complexReference_Base)
            {
                serializableReferences = complexReference_Base.References;
            }
            else
            {
                serializableReferences = [serializableReference_Base];
            }

            if (serializableReference is ComplexReference complexReference)
            {
                serializableReferences.AddRange(complexReference.References);
            }
            else
            {
                serializableReferences.Add(serializableReference);
            }

            return new ComplexReference(serializableReferences);
        }

        /// <summary>
        /// Parses a string into a reference of type <typeparamref name="TReference"/>.
        /// <para>Returns <see langword="default"/> when the input is <see langword="null"/>, empty, whitespace, or cannot be parsed
        /// by <see cref="Query.TryParse{UReference}(string, out UReference)"/>.</para>
        /// </summary>
        /// <typeparam name="TReference">The type of reference to parse. Must implement <see cref="IReference"/>.</typeparam>
        /// <param name="text">The string representation to parse.</param>
        /// <returns>The parsed reference of type <typeparamref name="TReference"/>; otherwise, the default value of <typeparamref name="TReference"/>.</returns>
        public static TReference? Reference<TReference>(this string text) where TReference : IReference
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return default;
            }

            if (!Query.TryParse(text, out TReference? result))
            {
                return default;
            }

            return result;
        }
    }
}