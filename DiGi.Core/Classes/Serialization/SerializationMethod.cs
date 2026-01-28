using System.Reflection;

namespace DiGi.Core.Classes
{
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