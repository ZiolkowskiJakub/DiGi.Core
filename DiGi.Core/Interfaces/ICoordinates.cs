namespace DiGi.Core.Interfaces
{
    /// <summary>Defines a contract for an object that represents geographic coordinates.</summary>
    public interface ICoordinates : ILocation
    {
        /// <summary>Gets the latitude coordinate.</summary>
        double Latitude { get; }

        /// <summary>Gets the longitude coordinate.</summary>
        double Longitude { get; }
    }
}