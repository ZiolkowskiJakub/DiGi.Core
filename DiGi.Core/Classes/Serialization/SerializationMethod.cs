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

        public MemberInfo MemberInfo
        {
            get
            {
                return memberInfo;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}