using DiGi.Core.Classes;
using System.Reflection;

namespace DiGi.Core
{
    public static partial class Create
    {
        /// <summary>Creates a reference constructor from a method marked with <see cref="ReferenceFactoryAttribute"/>.</summary>
        /// <param name="methodInfo">The candidate factory method.</param>
        /// <returns>A <see cref="ReferenceConstructor"/> if the method is a valid factory; otherwise, <c>null</c>.</returns>
        public static ReferenceConstructor? ReferenceConstructor(this MethodInfo? methodInfo)
        {
            ReferenceFactoryAttribute? referenceFactoryAttribute = methodInfo?.GetCustomAttribute<ReferenceFactoryAttribute>();
            if (referenceFactoryAttribute == null)
            {
                return null;
            }

            System.Type? type = referenceFactoryAttribute.ReferenceType;
            if (type == null)
            {
                return null;
            }

            string? fullTypeName = Query.FullTypeName(type);
            if (string.IsNullOrWhiteSpace(fullTypeName))
            {
                return null;
            }

            ReferenceConstructor result = new(type, fullTypeName, referenceFactoryAttribute.Kind, methodInfo);
            if (!result.Valid)
            {
                return null;
            }

            return result;
        }
    }
}