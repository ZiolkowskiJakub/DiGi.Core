using System.Reflection;

namespace DiGi.Core.Classes
{
    public class SerializationMethod
    {
        private MemberInfo memberInfo;
        private string name;

        internal SerializationMethod(MemberInfo memberInfo, string name)
        {
            this.memberInfo = memberInfo;
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public MemberInfo MemberInfo
        {
            get
            {
                return memberInfo;
            }
        }
    }
}
