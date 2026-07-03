using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a physical mailing address including street, city, postal code, and country code.
    /// </summary>
    public class Address : SerializableObject, IAddress
    {
        [JsonInclude, JsonPropertyName(nameof(City))]
        private readonly string? city;

        [JsonInclude, JsonPropertyName(nameof(CountryCode))]
        private readonly CountryCode countryCode;

        [JsonInclude, JsonPropertyName(nameof(PostalCode))]
        private readonly string? postalCode;

        [JsonInclude, JsonPropertyName(nameof(Street))]
        private readonly string? street;

        /// <summary>
        /// Initializes a new instance of the Address class with specified address details.
        /// </summary>
        /// <param name="street">The street name and number.</param>
        /// <param name="city">The city name.</param>
        /// <param name="postalCode">The postal or zip code.</param>
        /// <param name="countryCode">The ISO country code.</param>
        public Address(string? street, string? city, string? postalCode, CountryCode countryCode)
            : base()
        {
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
            this.countryCode = countryCode;
        }

        /// <summary>
        /// Initializes a new instance of the Address class using another Address object.
        /// </summary>
        /// <param name="address">The source address to copy from.</param>
        public Address(Address? address)
            : base(address)
        {
            if (address != null)
            {
                street = address.street;
                city = address.city;
                postalCode = address.postalCode;
                countryCode = address.countryCode;
            }
        }

        /// <summary>
        /// Initializes a new instance of the Address class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing address data.</param>
        public Address(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the city name of the address.
        /// </summary>
        [JsonIgnore]
        public string? City
        {
            get
            {
                return city;
            }
        }

        /// <summary>
        /// Gets the ISO country code of the address.
        /// </summary>
        [JsonIgnore]
        public CountryCode CountryCode
        {
            get
            {
                return countryCode;
            }
        }

        /// <summary>
        /// Gets the postal or zip code of the address.
        /// </summary>
        [JsonIgnore]
        public string? PostalCode
        {
            get
            {
                return postalCode;
            }
        }

        /// <summary>
        /// Gets the street name and number of the address.
        /// </summary>
        [JsonIgnore]
        public string? Street
        {
            get
            {
                return street;
            }
        }
    }
}