using DiGi.Core.Classes;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Drawing.Classes
{
    public class Pen : SerializableObject
    {
        [JsonInclude, JsonPropertyName("Color")]
        private Color color;

        [JsonInclude, JsonPropertyName("Thickness")]
        private double thickness;

        public Pen(Color color, double thickness)
            : base()
        {
            this.color = color;
            this.thickness = thickness;
        }

        public Pen(Pen pen)
            : base(pen)
        {
            if (pen != null)
            {
                color = pen.color?.Clone<Color>();
                thickness = pen.thickness;
            }
        }

        public Pen(JsonObject jsonObject)
            :base(jsonObject)
        {

        }

        public double Thickness
        {
            get
            {
                return thickness;
            }
        }

        public Color Color
        {
            get
            {
                return color?.Clone<Color>();
            }
        }
    }
}