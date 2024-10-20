using DiGi.Core.Enums;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    public class Address : SerializableObject, IAddress
    {
        [JsonInclude, JsonPropertyName("Street")]
        private string street;

        [JsonInclude, JsonPropertyName("City")]
        private string city;

        [JsonInclude, JsonPropertyName("PostalCode")]
        private string postalCode;

        [JsonInclude, JsonPropertyName("CountryCode")]
        private CountryCode countryCode;

        public Address(Address address)
            : base()
        {
            street = address.street;
            city = address.city;
            postalCode = address.postalCode;
            countryCode = address.countryCode;
        }

        public Address(string street, string city, string postalCode, CountryCode countryCode)
            : base()
        {
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
            this.countryCode = countryCode;
        }

        public Address(JsonObject jsonObject)
            : base(jsonObject)
        {
        }

        [JsonIgnore]
        public string Street
        {
            get
            {
                return street;
            }
        }

        [JsonIgnore]
        public string City
        {
            get
            {
                return city;
            }
        }

        [JsonIgnore]
        public string PostalCode
        {
            get
            {
                return postalCode;
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
    }
}
