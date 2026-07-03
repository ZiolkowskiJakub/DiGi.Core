using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Defines two-dimensional dimensions (Width and Height) with scaling utilities.
    /// </summary>
    public class Size : SerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(Height)), Description("Height")]
        private double height = 0;

        [JsonInclude, JsonPropertyName(nameof(Width)), Description("Width")]
        private double width = 0;

        /// <summary>
        /// Initializes a new empty instance of the Size class.
        /// </summary>
        public Size()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Size class with specified width and height.
        /// </summary>
        /// <param name="width">The width dimension.</param>
        /// <param name="height">The height dimension.</param>
        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        /// Initializes a new instance of the Size class by copying another Size object.
        /// </summary>
        /// <param name="size">The source size to copy from.</param>
        public Size(Size? size)
            : base(size)
        {
            if (size != null)
            {
                width = size.width;
                height = size.height;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Size class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing size data.</param>
        public Size(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets or sets the height dimension of the size.
        /// </summary>
        [JsonIgnore]
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        /// <summary>
        /// Gets or sets the width dimension of the size.
        /// </summary>
        [JsonIgnore]
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        /// <summary>
        /// Implicitly converts a <see cref="System.Drawing.SizeF"/> object to a <see cref="Size"/> instance.
        /// </summary>
        /// <param name="size">The <see cref="System.Drawing.SizeF"/> object to convert.</param>
        /// <returns>A new <see cref="Size"/> instance created from the provided dimensions.</returns>
        public static implicit operator Size(System.Drawing.SizeF size)
        {
            return new Size(size.Width, size.Height);
        }

        /// <summary>
        /// Implicitly converts a <see cref="System.Drawing.Size"/> object to a <see cref="Size"/> instance.
        /// </summary>
        /// <param name="size">The <see cref="System.Drawing.Size"/> object to convert.</param>
        /// <returns>A new <see cref="Size"/> instance created from the provided dimensions.</returns>
        public static implicit operator Size(System.Drawing.Size size)
        {
            return new Size(size.Width, size.Height);
        }

        /// <summary>
        /// Calculates the total area of the size (Width * Height).
        /// </summary>
        /// <returns>The calculated area.</returns>
        public double GetArea()
        {
            return Width * Height;
        }

        /// <summary>
        /// Returns a new Size object scaled by the given factor.
        /// </summary>
        /// <param name="value">The scaling factor.</param>
        /// <returns>A new scaled Size instance.</returns>
        public Size GetScaled(double value)
        {
            return new Size(Width * value, Height * value);
        }

        /// <summary>
        /// Scales the current size dimensions by the given factor.
        /// </summary>
        /// <param name="value">The scaling factor.</param>
        public void Scale(double value)
        {
            Width *= value;
            Height *= value;
        }
    }
}