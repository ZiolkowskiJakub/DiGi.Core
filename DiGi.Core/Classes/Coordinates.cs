using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Coordinates : SerializableObject, ICoordinates
    {
        [JsonInclude, JsonPropertyName("Latitude")]
        private double latitude;

        [JsonInclude, JsonPropertyName("Longitude")]
        private double longitude;

        public Coordinates(Coordinates coordinates)
            : base()
        {
            if(coordinates != null)
            {
                latitude = coordinates.latitude;
                longitude = coordinates.longitude;
            }
        }

        public Coordinates(double latitude, double longitude)
            : base()
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }

        public Coordinates(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public double Latitude
        {
            get
            {
                return latitude;
            }
        }

        [JsonIgnore]
        public double Longitude
        {
            get
            {
                return longitude;
            }
        }
    }
}
