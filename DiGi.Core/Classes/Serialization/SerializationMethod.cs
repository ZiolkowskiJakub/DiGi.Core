using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a specific member (property or field) targeted for serialization, containing its reflection metadata and name.
    /// </summary>
    public class SerializationMethod
    {
        private readonly MemberInfo memberInfo;
        private readonly string name;

        internal SerializationMethod(MemberInfo memberInfo, string name)
        {
            this.memberInfo = memberInfo;
            this.name = name;
        }

        /// <summary>
        /// Gets the member information associated with this instance.
        /// </summary>
        public MemberInfo MemberInfo
        {
            get
            {
                return memberInfo;
            }
        }

        /// <summary>
        /// Gets the name of the serialization component.
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}