using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Address : SerializableObject, IAddress
    {
        [JsonInclude, JsonPropertyName("City")]
        private readonly string? city;

        [JsonInclude, JsonPropertyName("CountryCode")]
        private readonly CountryCode countryCode;

        [JsonInclude, JsonPropertyName("PostalCode")]
        private readonly string? postalCode;

        [JsonInclude, JsonPropertyName("Street")]
        private readonly string? street;
        public Address(Address? address)
            : base()
        {
            if (address != null)
            {
                street = address.street;
                city = address.city;
                postalCode = address.postalCode;
                countryCode = address.countryCode;
            }
        }

        public Address(string? street, string? city, string? postalCode, CountryCode countryCode)
            : base()
        {
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
            this.countryCode = countryCode;
        }

        public Address(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public string? City
        {
            get
            {
                return city;
            }
        }

        [JsonIgnore]
        public CountryCode CountryCode
        {
            get
            {
                return countryCode;
            }
        }

        [JsonIgnore]
        public string? PostalCode
        {
            get
            {
                return postalCode;
            }
        }

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
