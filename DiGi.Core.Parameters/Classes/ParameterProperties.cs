using DiGi.Core.Parameters.Enums;
using System;

namespace DiGi.Core.Parameters
{
    public class ParameterProperties : Attribute
    {
        private string uniqueId = null;
        private string name = null;
        private string description = null;
        private AccessType accessType = AccessType.ReadWrite;
        private string groupName = null;

        public ParameterProperties(string uniqueId, string name)
        {
            this.uniqueId = uniqueId;
            this.name = name;
        }

        public ParameterProperties(string uniqueId, string name, string description)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
        }

        public ParameterProperties(string uniqueId, string name, string description, AccessType accessType)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        public ParameterProperties(string uniqueId, string name, string description, AccessType accessType, string groupName)
        {
            this.uniqueId = uniqueId;
            this.name = name;
            this.description = description;
            this.accessType = accessType;
            this.groupName = groupName;
        }

        public ParameterProperties(string name)
        {
            this.name = name;
        }

        public ParameterProperties(string name, string description, AccessType accessType)
        {
            this.name = name;
            this.description = description;
            this.accessType = accessType;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
        }

        public string UniqueId
        {
            get
            {
                return uniqueId == null ? name : uniqueId;
            }
        }

        public string GroupName
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
