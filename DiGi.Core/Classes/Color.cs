using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents an ARGB color, providing conversions between integer values and System.Drawing.Color.
    /// </summary>
    [Description("Color described as alpha, red, green blue")]
    public class Color : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Alpha"), Description("Color Alpha")]
        private readonly byte alpha;

        [JsonInclude, JsonPropertyName("Blue"), Description("Color Blue")]
        private readonly byte blue;

        [JsonInclude, JsonPropertyName("Green"), Description("Color Green")]
        private readonly byte green;

        [JsonInclude, JsonPropertyName("Red"), Description("Color Red")]
        private readonly byte red;

        /// <summary>
        /// Initializes a new instance of the Color class with specified ARGB components.
        /// </summary>
        /// <param name="alpha">The alpha component.</param>
        /// <param name="red">The red component.</param>
        /// <param name="green">The green component.</param>
        /// <param name="blue">The blue component.</param>
        public Color(byte alpha, byte red, byte green, byte blue)
        {
            this.alpha = alpha;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        /// <summary>
        /// Initializes a new instance of the Color class from an integer value.
        /// </summary>
        /// <param name="value">The ARGB integer value.</param>
        public Color(int value)
        {
            alpha = (byte)(value >> 24);
            red = (byte)(value >> 16);
            green = (byte)(value >> 8);
            blue = (byte)(value);
        }

        /// <summary>
        /// Initializes a new instance of the Color class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing color data.</param>
        public Color(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Initializes a new instance of the Color class from a System.Drawing.Color object.
        /// </summary>
        /// <param name="color">The source color.</param>
        public Color(System.Drawing.Color color)
        {
            alpha = color.A;
            red = color.R;
            green = color.G;
            blue = color.B;
        }

        /// <summary>
        /// Gets the alpha component of the color.
        /// </summary>
        [JsonIgnore]
        public byte Alpha
        {
            get
            {
                return alpha;
            }
        }

        /// <summary>
        /// Gets the blue component of the color.
        /// </summary>
        [JsonIgnore]
        public byte Blue
        {
            get
            {
                return blue;
            }
        }

        /// <summary>
        /// Gets the green component of the color.
        /// </summary>
        [JsonIgnore]
        public byte Green
        {
            get
            {
                return green;
            }
        }

        /// <summary>
        /// Gets the red component of the color.
        /// </summary>
        [JsonIgnore]
        public byte Red
        {
            get
            {
                return red;
            }
        }

        /// <summary>
        /// Gets the integer representation (ARGB) of the color.
        /// </summary>
        [JsonIgnore]
        public int Value
        {
            get
            {
                return (alpha << 24) | (red << 16) | (green << 8) | blue;
            }
        }

        /// <summary>
        /// Implicitly converts a Color instance to a System.Drawing.Color object.
        /// </summary>
        public static implicit operator System.Drawing.Color(Color? color)
        {
            if (color is null)
            {
                return System.Drawing.Color.Empty;
            }

            return System.Drawing.Color.FromArgb(color.alpha, color.red, color.Green, color.Blue);
        }

        /// <summary>
        /// Implicitly converts a System.Drawing.Color object to a Color instance.
        /// </summary>
        public static implicit operator Color(System.Drawing.Color color)
        {
            return new Color(color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// Implicitly converts an integer (ARGB) to a Color instance.
        /// </summary>
        public static implicit operator Color(int value)
        {
            return new Color(value);
        }

        /// <summary>
        /// Determines whether two Color instances are not equal.
        /// </summary>
        public static bool operator !=(Color? color_1, Color? color_2)
        {
            if (Equals(color_1, color_2))
            {
                return false;
            }

            if (Equals(color_1, null))
            {
                return true;
            }

            if (Equals(color_2, null))
            {
                return true;
            }

            return color_1.alpha != color_2.alpha || color_1.red != color_2.red || color_1.green != color_2.green && color_1.blue != color_2.blue;
        }

        /// <summary>
        /// Determines whether two Color instances are equal.
        /// </summary>
        public static bool operator ==(Color? color_1, Color? color_2)
        {
            if (Equals(color_1, color_2))
            {
                return true;
            }

            if (Equals(color_1, null))
            {
                return false;
            }

            if (Equals(color_2, null))
            {
                return false;
            }

            return color_1.alpha == color_2.alpha && color_1.red == color_2.red && color_1.green == color_2.green && color_1.blue == color_2.blue;
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current Color instance.
        /// </summary>
        /// <param name="object">The object to compare with.</param>
        /// <returns>True if the objects are equal; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is not Color color)
            {
                return false;
            }

            return color.alpha == alpha && color.red == red && color.green == green && color.blue == blue;
        }

        /// <summary>
        /// Returns a hash code for the current Color instance.
        /// </summary>
        /// <returns>The hash code of the color.</returns>
        public override int GetHashCode()
        {
            return (new Tuple<byte, byte, byte, byte>(alpha, red, green, blue)).GetHashCode();
        }
    }
}