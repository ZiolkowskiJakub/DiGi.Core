using DiGi.Core.Interfaces;
using System;

namespace DiGi.Core.Parameter.Interfaces
{
    public interface IUniqueParametrizedObject : IParametrizedObject, IUniqueObject
    {
        Guid Guid { get; }
    }
}
