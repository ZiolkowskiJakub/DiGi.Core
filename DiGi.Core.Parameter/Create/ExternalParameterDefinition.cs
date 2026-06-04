using DiGi.Core.Parameter.Classes;
using DiGi.Core.Parameter.Enums;
using System;

namespace DiGi.Core.Parameter
{
    public static partial class Create
    {
        /// <summary>
        /// Creates a new external parameter definition with the specified properties.
        /// </summary>
        public static ExternalParameterDefinition? ExternalParameterDefinition(Guid guid, string? name, string? description, ParameterType parameterType, Type? type, AccessType accessType = AccessType.ReadWrite, bool nullable = true, string? groupName = null)
        {
            if (guid == Guid.Empty || name == null || parameterType == ParameterType.Undefined || type == null)
            {
                return null;
            }

            ParameterValue? parameterValue = null;
            switch (parameterType)
            {
                case ParameterType.Double:
                    parameterValue = new DoubleParameterValue(nullable);
                    break;
            }

            if (parameterValue == null)
            {
                return null;
            }

            return new ExternalParameterDefinition(guid, name, description, accessType, parameterValue, new AssociatedTypes(type), groupName);
        }

        /// <summary>
        /// Creates a new external parameter definition with specified range constraints.
        /// </summary>
        public static ExternalParameterDefinition? ExternalParameterDefinition(Guid guid, string? name, string? description, double min, double max, Type? type, AccessType accessType = AccessType.ReadWrite, bool nullable = true, string? groupName = null)
        {
            if (guid == Guid.Empty || name == null || type == null)
            {
                return null;
            }

            return new ExternalParameterDefinition(guid, name, description, accessType, new DoubleParameterValue(nullable, min, max), new AssociatedTypes(type), groupName);
        }
    }
}