using DiGi.Core.Interfaces;

namespace DiGi.Core.Parameter.Interfaces
{
    /// <summary>Defines the contract for a GUID-based unique object that can be parameterized.</summary>
    public interface IParametrizedGuidObject : IParametrizedUniqueObject, IGuidObject
    {
    }
}