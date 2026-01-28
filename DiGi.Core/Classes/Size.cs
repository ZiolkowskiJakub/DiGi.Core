using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Size : SerializableObject
    {
        public Size()
        {
        }

        public Size(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        public Size(Size? size)
            : base(size)
        {
            if (size != null)
            {
                Width = size.Width;
                Height = size.Height;
            }
        }

        public Size(double width, double height)
        {
            Width = width;
            Height = height;
        }

        [JsonInclude, JsonPropertyName("Height"), Description("Height")]
        public double Height { get; set; } = 0;

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
    }
}