using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Drawing.Classes
{
    /// <summary>
    /// Represents a pen with a color and thickness.
    /// </summary>
    public class Pen : SerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Color))]
        private readonly Color? color;

        [JsonInclude, JsonPropertyName(nameof(Thickness))]
        private readonly double thickness;

        /// <summary>
        /// Initializes a new instance of the Pen class with specified color and thickness.
        /// </summary>
        /// <param name="color">The color of the pen.</param>
        /// <param name="thickness">The thickness of the pen.</param>
        public Pen(Color? color, double thickness)
            : base()
        {
            this.color = color;
            this.thickness = thickness;
        }

        /// <summary>
        /// Initializes a new instance of the Pen class by copying another pen.
        /// </summary>
        /// <param name="pen">The source pen to copy from.</param>
        public Pen(Pen? pen)
            : base(pen)
        {
            if (pen != null)
            {
                color = pen.color?.Clone<Color>();
                thickness = pen.thickness;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Pen class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing pen data.</param>
        public Pen(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the color of the pen.
        /// </summary>
        [JsonIgnore]
        public Color? Color
        {
            get
            {
                return color?.Clone<Color>();
            }
        }

        /// <summary>
        /// Gets the thickness of the pen.
        /// </summary>
        [JsonIgnore]
        public double Thickness
        {
            get
            {
                return thickness;
            }
        }
    }
}