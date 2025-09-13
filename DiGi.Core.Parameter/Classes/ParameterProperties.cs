using DiGi.Core.Parameter.Enums;
using System;

namespace DiGi.Core.Parameter.Classes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class ParameterProperties : Attribute
    {
        private readonly string? uniqueId = null;
        private readonly string? name = null;
        private readonly string? description = null;
        private readonly AccessType accessType = AccessType.ReadWrite;
        private readonly string? groupName = null;

        public ParameterProperties(string? uniqueId, string? name)
        {
            this.uniqueId = uniqueId;
            this.name = name;
        }

        public ParameterProperties(string? uniqueId, string? name, string? description)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
        }

        public ParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        public ParameterProperties(string? uniqueId, string? name, string? description, AccessType accessType, string? groupName)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
            this.groupName = groupName;
        }

        public ParameterProperties(string? name)
        {
            this.name = name;
        }

        public ParameterProperties(string? name, string? description, AccessType accessType)
        {
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        public string? Name
        {
            get
            {
                return name;
            }
        }

        public string? Description
        {
            get
            {
                return description;
            }
        }

        public string? UniqueId
        {
            get
            {
                return uniqueId ?? name;
            }
        }

        public string? GroupName
        {
            get
            {
                return groupName;
            }
        }

        public AccessType AccessType
        {
            get
            {
                return accessType;
            }
        }
    }
}
