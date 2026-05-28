using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// An abstract base class for defining options used during data conversion processes.
    /// </summary>
    public abstract class ConvertOptions : SerializableOptions, IConvertOptions
    {
        /// <summary>
        /// Initializes a new instance of the ConvertOptions class.
        /// </summary>
        public ConvertOptions()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConvertOptions class by copying another ConvertOptions object.
        /// </summary>
        /// <param name="convertOptions">The source options to copy from.</param>
        public ConvertOptions(ConvertOptions? convertOptions)
            : base(convertOptions)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ConvertOptions class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing conversion options.</param>
        public ConvertOptions(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }
    }
}