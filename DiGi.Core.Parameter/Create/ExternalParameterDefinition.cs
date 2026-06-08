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
        /// <param name="guid">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">A description of the parameter.</param>
        /// <param name="parameterType">The type category of the parameter.</param>
        /// <param name="type">The underlying system type of the parameter.</param>
        /// <param name="accessType">The access level of the parameter.</param>
        /// <param name="nullable">Whether the parameter can be null.</param>
        /// <param name="groupName">The name of the group this parameter belongs to.</param>
        /// <returns>A new instance of <see cref="DiGi.Core.Parameter.Classes.ExternalParameterDefinition"/>, or null if creation fails.</returns>
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
        /// <param name="guid">The unique identifier for the parameter.</param>
        /// <param name="name">The name of the parameter.</param>
        /// <param name="description">A description of the parameter.</param>
        /// <param name="min">The minimum value constraint.</param>
        /// <param name="max">The maximum value constraint.</param>
        /// <param name="type">The type of the parameter.</param>
        /// <param name="accessType">The access level of the parameter.</param>
        /// <param name="nullable">Whether the parameter can be null.</param>
        /// <param name="groupName">The name of the group this parameter belongs to.</param>
        /// <returns>A new instance of <see cref="DiGi.Core.Parameter.Classes.ExternalParameterDefinition"/>, or null if creation fails.</returns>
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