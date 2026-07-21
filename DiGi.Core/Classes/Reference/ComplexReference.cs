using DiGi.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a reference reached by walking an ordered chain of references, so that an object nested inside a
    /// containment hierarchy can be addressed from its root - for example a wall inside a building inside an area
    /// inside a country.
    /// <para>Each step is an ordinary reference and is nested inside the rendered string, which is what allows a
    /// chain of any depth to be parsed back in a single pass without knowing any step's shape in advance.</para>
    /// <para>This is an <see cref="IComplexReference"/> and deliberately not an
    /// <see cref="IUniqueReference"/>: a path has no unique identifier of its own, and keeping it out of the
    /// unique-reference APIs keeps long paths out of storage keys.</para>
    /// <para>The chain is structural only. DiGi.Core has no containment model, so nothing here validates that the
    /// steps actually contain one another; that belongs to whichever repository knows the hierarchy.</para>
    /// </summary>
    /// <example>
    /// A country, area, building and wall chain renders and parses (via
    /// <see cref="Core.Query.TryParse(string?, out IReference?)"/>) as the discriminator followed by one nested step
    /// per level (shown wrapped for readability; the actual string has no whitespace):
    /// <code>
    /// Complex::(TypeExternal::POLAND::(Type::DiGi.GIS.Classes.Country,DiGi.GIS))
    ///         ::(UniqueId::(Type::DiGi.GIS.Classes.Area,DiGi.GIS)::Mazowieckie)
    ///         ::(UniqueId::(Type::DiGi.GIS.Classes.Building,DiGi.GIS)::BLD-001)
    ///         ::(Guid::(Type::DiGi.Analytical.Building.Classes.Wall,DiGi.Analytical.Building)::0f8fad5bd9cb469fa16570867728950e)
    /// </code>
    /// </example>
    public class ComplexReference : SerializableReference, IComplexReference
    {
        [JsonInclude, JsonPropertyName(nameof(References))]
        private readonly List<ISerializableReference> references = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexReference"/> class from an ordered chain of references.
        /// </summary>
        /// <param name="references">The steps of the chain, from the root inwards. Null steps are skipped.</param>
        public ComplexReference(IEnumerable<ISerializableReference?>? references)
            : base()
        {
            if (references is not null)
            {
                foreach (ISerializableReference? reference in references)
                {
                    if (reference is null)
                    {
                        continue;
                    }

                    this.references.Add(reference);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexReference"/> class by copying an existing reference.
        /// </summary>
        /// <param name="complexReference">The existing reference to copy.</param>
        public ComplexReference(ComplexReference? complexReference)
            : base(complexReference)
        {
            if (complexReference is not null)
            {
                foreach (ISerializableReference reference in complexReference.references)
                {
                    if (Query.Clone(reference) is ISerializableReference reference_Clone)
                    {
                        references.Add(reference_Clone);
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexReference"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public ComplexReference(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the steps of the chain, from the root inwards.
        /// </summary>
        [JsonIgnore]
        public List<ISerializableReference> References
        {
            get
            {
                return [.. references];
            }
        }

        /// <summary>
        /// Gets the number of steps in the chain.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                return references.Count;
            }
        }

        /// <summary>
        /// Gets the step at the specified position in the chain.
        /// </summary>
        /// <param name="index">The zero-based position, counted from the root.</param>
        /// <returns>The step, or null when the position is outside the chain.</returns>
        public ISerializableReference? this[int index]
        {
            get
            {
                if (index < 0 || index >= references.Count)
                {
                    return null;
                }

                return references[index];
            }
        }

        /// <summary>
        /// Gets the segments of this reference's string form: one nested segment per step, in order.
        /// <para>The only reference with a variable number of segments; every other type declares a fixed count.</para>
        /// </summary>
        [JsonIgnore]
        protected override IEnumerable<string?> Segments
        {
            get
            {
                List<string?> result = [];
                foreach (ISerializableReference reference in references)
                {
                    result.Add(Query.Segment(reference));
                }

                return result;
            }
        }

        /// <summary>
        /// Creates a deep copy of the current object.
        /// </summary>
        /// <returns>A deep copy of the current object.</returns>
        public override ISerializableObject? Clone()
        {
            return new ComplexReference(this);
        }
    }
}