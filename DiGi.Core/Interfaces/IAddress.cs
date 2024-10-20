using DiGi.Core.Enums;

namespace DiGi.Core.Interfaces
{
    public interface IAddress : ILocation
    {
        string Street { get; }
        string City { get; }
        string PostalCode { get; }
        CountryCode CountryCode { get; }
    }
}
