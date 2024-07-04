using System;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    [Description("Color described as alpha, red, green blue")]
    public class Color : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Alpha"), Description("Color Alpha")]
        private byte alpha;

        [JsonInclude, JsonPropertyName("Blue"), Description("Color Blue")]
        private byte blue;

        [JsonInclude, JsonPropertyName("Green"), Description("Color Green")]
        private byte green;

        [JsonInclude, JsonPropertyName("Red"), Description("Color Red")]
        private byte red;
        public Color(byte alpha, byte red, byte green, byte blue)
        {
            this.alpha = alpha;
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        public Color(int value)
        {
            alpha = (byte)(value >> 24);
            red = (byte)(value >> 16);
            green = (byte)(value >> 8);
            blue = (byte)(value);
        }

        public Color(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public Color(System.Drawing.Color color)
        {
            alpha = color.A;
            red = color.R;
            green = color.G;
            blue = color.B;
        }

        [JsonIgnore]
        public byte Alpha
        {
            get
            {
                return alpha;
            }
        }

        [JsonIgnore]
        public byte Blue
        {
            get
            {
                return blue;
            }
        }

        [JsonIgnore]
        public byte Green
        {
            get
            {
                return green;
            }
        }

        [JsonIgnore]
        public byte Red
        {
            get
            {
                return red;
            }
        }

        [JsonIgnore]
        public int Value
        {
            get
            {
                return (alpha << 24) | (red << 16) | (green << 8) | blue;
            }
        }


        public static implicit operator System.Drawing.Color(Color color)
        {
            if (color == null)
            {
                return System.Drawing.Color.Empty;
            }

            return System.Drawing.Color.FromArgb(color.alpha, color.red, color.Green, color.Blue);
        }


        public static implicit operator Color(System.Drawing.Color color)
        {
            return new Color(color.A, color.R, color.G, color.B);
        }


        public static implicit operator Color(int value)
        {
            return new Color(value);
        }

        public static bool operator !=(Color color_1, Color color_2)
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

        public static bool operator ==(Color color_1, Color color_2)
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

        public override bool Equals(object @object)
        {
            Color color = @object as Color;
            if (color == null)
            {
                return false;
            }

            return color.alpha == alpha && color.red == red && color.green == green && color.blue == blue;
        }

        public override int GetHashCode()
        {
            return (new Tuple<byte, byte, byte, byte>(alpha, red, green, blue)).GetHashCode();
        }
    }
}
