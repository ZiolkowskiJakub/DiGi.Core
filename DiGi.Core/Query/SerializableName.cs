using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the serializable name (e.g. from JsonPropertyNameAttribute) for a MemberInfo.
        /// </summary>
        /// <param name="memberInfo">The MemberInfo.</param>
        /// <returns>The serializable name.</returns>
        public static string? SerializableName(this MemberInfo? memberInfo)
        {
            if (memberInfo == null)
            {
                return null;
            }

            string result = memberInfo.Name;

            if (memberInfo.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false) is not JsonPropertyNameAttribute[] jsonPropertyNameAttributes || jsonPropertyNameAttributes.Length == 0)
            {
                return result;
            }

            for (int i = 0; i < jsonPropertyNameAttributes.Length; i++)
            {
                string name = jsonPropertyNameAttributes[i].Name;

                if (!string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
            }

            return result;
        }
    }
}