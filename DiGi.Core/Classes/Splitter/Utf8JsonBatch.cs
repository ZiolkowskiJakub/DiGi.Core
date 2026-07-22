using DiGi.Core.Interfaces;
using System.Collections.Generic;

namespace DiGi.Core.Classes
{
    /// <summary>A batch of serializable objects together with the UTF-8 JSON array that represents them.</summary>
    /// <typeparam name="TSerializableObject">The type of the serializable object.</typeparam>
    public class Utf8JsonBatch<TSerializableObject> where TSerializableObject : ISerializableObject
    {
        private readonly List<TSerializableObject> serializableObjects;
        private readonly byte[] utf8Json;

        /// <summary>
        /// Initializes a new instance of the <see cref="Utf8JsonBatch{TSerializableObject}"/> class.
        /// </summary>
        /// <param name="serializableObjects">The objects making up the batch, in payload order.</param>
        /// <param name="utf8Json">The complete UTF-8 JSON array representing <paramref name="serializableObjects"/>.</param>
        public Utf8JsonBatch(List<TSerializableObject> serializableObjects, byte[] utf8Json)
        {
            this.serializableObjects = serializableObjects;
            this.utf8Json = utf8Json;
        }

        /// <summary>
        /// Gets the objects making up the batch, in the same order as they appear in <see cref="Utf8Json"/>.
        /// </summary>
        public List<TSerializableObject> SerializableObjects => serializableObjects;

        /// <summary>
        /// Gets the complete UTF-8 JSON array representing <see cref="SerializableObjects"/>, ready to be sent as a request body.
        /// </summary>
        public byte[] Utf8Json => utf8Json;
    }
}
