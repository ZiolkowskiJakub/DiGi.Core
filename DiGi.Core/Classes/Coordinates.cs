using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a geographic location using Latitude and Longitude.
    /// </summary>
    public class Coordinates : SerializableObject, ICoordinates
    {
        [JsonInclude, JsonPropertyName(nameof(Latitude))]
        private readonly double latitude;

        [JsonInclude, JsonPropertyName(nameof(Longitude))]
        private readonly double longitude;

        /// <summary>
        /// Initializes a new instance of the Coordinates class with specified latitude and longitude.
        /// </summary>
        /// <param name="latitude">The geographic latitude.</param>
        /// <param name="longitude">The geographic longitude.</param>
        public Coordinates(double latitude, double longitude)
            : base()
        {
            this.longitude = longitude;
            this.latitude = latitude;
        }

        /// <summary>
        /// Initializes a new instance of the Coordinates class by copying another Coordinates object.
        /// </summary>
        /// <param name="coordinates">The source coordinates to copy from.</param>
        public Coordinates(Coordinates? coordinates)
            : base(coordinates)
        {
            if (coordinates != null)
            {
                latitude = coordinates.latitude;
                longitude = coordinates.longitude;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Coordinates class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing coordinate data.</param>
        public Coordinates(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the geographic latitude of the location.
        /// </summary>
        [JsonIgnore]
        public double Latitude
        {
            get
            {
                return latitude;
            }
        }

        /// <summary>
        /// Gets the geographic longitude of the location.
        /// </summary>
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