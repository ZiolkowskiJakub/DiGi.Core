using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a specific member (property or field) targeted for serialization, containing its reflection metadata and name.
    /// </summary>
    public class SerializationMethod
    {
        private readonly FieldInfo? fieldInfo;
        private readonly MemberInfo memberInfo;
        private readonly string name;
        private readonly PropertyInfo? propertyInfo;
        private readonly bool readable;

        internal SerializationMethod(MemberInfo memberInfo, string name)
        {
            this.memberInfo = memberInfo;
            this.name = name;

            propertyInfo = memberInfo as PropertyInfo;
            fieldInfo = memberInfo as FieldInfo;

            if (propertyInfo != null)
            {
                MethodInfo? methodInfo = propertyInfo.GetMethod;
                readable = methodInfo != null && methodInfo.GetParameters().Length == 0;
            }
            else
            {
                readable = fieldInfo != null;
            }
        }

        /// <summary>
        /// Gets the field information when the member is a field; otherwise, null.
        /// </summary>
        public FieldInfo? FieldInfo
        {
            get
            {
                return fieldInfo;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the member value can be read (a field, or a property with a parameterless getter).
        /// </summary>
        public bool IsReadable
        {
            get
            {
                return readable;
            }
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

        /// <summary>
        /// Gets the property information when the member is a property; otherwise, null.
        /// </summary>
        public PropertyInfo? PropertyInfo
        {
            get
            {
                return propertyInfo;
            }
        }
    }
}
