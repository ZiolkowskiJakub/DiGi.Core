using DiGi.Core.Classes;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper.Classes
{
    /// <summary>
    /// Represents a cluster of wrapper item values.
    /// </summary>
    public class WrapperItemValueCluster : ValueCluster<TypeReference, UniqueReference, WrapperItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WrapperItemValueCluster"/> class.
        /// </summary>
        public WrapperItemValueCluster()
        {
        }

        /// <summary>
        /// Retrieves the JSON value associated with the specified unique reference.
        /// </summary>
        /// <param name="uniqueReference">The unique reference used to identify the value.</param>
        /// <returns>The JSON value associated with the specified unique reference, or <see langword="null"/> if not found.</returns>
        public JsonNode? GetValue(UniqueReference? uniqueReference)
        {
            if (uniqueReference is null)
            {
                return null;
            }

            return GetValue<WrapperItem>(uniqueReference.TypeReference, uniqueReference)?.JsonNode;
        }

        /// <summary>
        /// Retrieves the typed JSON value associated with the specified unique reference.
        /// </summary>
        /// <typeparam name="TJsonNode">The type of the JSON node to return.</typeparam>
        /// <param name="uniqueReference">The unique reference used to identify the value.</param>
        /// <returns>The typed JSON value associated with the specified unique reference, or <see langword="null"/> if not found.</returns>
        public TJsonNode? GetValue<TJsonNode>(UniqueReference? uniqueReference) where TJsonNode : JsonNode
        {
            if (uniqueReference is null)
            {
                return null;
            }

            return GetValue<WrapperItem>(uniqueReference.TypeReference, uniqueReference)?.JsonNode as TJsonNode;
        }

        protected override TypeReference? GetKey_1(WrapperItem? value)
        {
            return value?.UniqueReference?.TypeReference;
        }

        protected override UniqueReference? GetKey_2(WrapperItem? value)
        {
            return value?.UniqueReference;
        }
    }
}