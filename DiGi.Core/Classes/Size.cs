using System.Text.Json.Nodes;

namespace DiGi.Core.Classes
{
    public class Size : SerializableObject
    {
        public double Width { get; set; } = 0;

        public double Height { get; set; } = 0;

        public Size()
        {

        }

        public Size(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Size(double width, double height)
        {
            Width = width;
            Height = height;
        }

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
