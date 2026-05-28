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
        /// <summary>
        /// Initializes a new empty instance of the Size class.
        /// </summary>
        public Size()
        {
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
        /// Initializes a new instance of the Size class by copying another Size object.
        /// </summary>
        /// <param name="size">The source size to copy from.</param>
        public Size(Size? size)
            : base(size)
        {
            if (size != null)
            {
                Width = size.Width;
                Height = size.Height;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Size class with specified width and height.
        /// </summary>
        /// <param name="width">The width dimension.</param>
        /// <param name="height">The height dimension.</param>
        public Size(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Gets or sets the height dimension of the size.
        /// </summary>
        [JsonInclude, JsonPropertyName("Height"), Description("Height")]
        public double Height { get; set; } = 0;

        /// <summary>
        /// Gets or sets the width dimension of the size.
        /// </summary>
        [JsonInclude, JsonPropertyName("Width"), Description("Width")]
        public double Width { get; set; } = 0;

        public static implicit operator Size(System.Drawing.SizeF size)
        {
            return new Size(size.Width, size.Height);
        }

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