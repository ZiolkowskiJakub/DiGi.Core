using System.Reflection;
using System.Text.Json.Serialization;

namespace DiGi.Core
{
    public static partial class Query
    {
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