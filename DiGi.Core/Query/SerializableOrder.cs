using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core
{
    public static partial class Query
    {
        /// <summary>
        /// Gets the serialization order of the specified member, as defined by the <see cref="JsonPropertyOrderAttribute"/>.
        /// </summary>
        /// <param name="memberInfo">The member to evaluate.</param>
        /// <returns>The serialization order if the attribute is present; otherwise, null.</returns>
        public static int? SerializableOrder(this MemberInfo? memberInfo)
        {
            if (memberInfo == null)
            {
                return null;
            }

            if (memberInfo.GetCustomAttributes(typeof(JsonPropertyOrderAttribute), false) is not JsonPropertyOrderAttribute[] jsonPropertyOrderAttributes || jsonPropertyOrderAttributes.Length == 0)
            {
                return null;
            }

            return jsonPropertyOrderAttributes[0].Order;
        }
    }
}