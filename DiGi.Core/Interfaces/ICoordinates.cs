namespace DiGi.Core.Interfaces
{
    public interface ICoordinates : ILocation
    {
        double Latitude { get; }

        double Longitude { get; }

    }
}
