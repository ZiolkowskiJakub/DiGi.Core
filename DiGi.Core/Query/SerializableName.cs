using System.Reflection;
using System.Text.Json.Serialization;


namespace DiGi.Core
{
    public static partial class Query
    {
        public static string SerializableName(this MemberInfo memberInfo)
        {
            if (memberInfo == null)
            {
                return null;
            }

            string result = memberInfo.Name;

            JsonPropertyNameAttribute[] jsonPropertyNameAttributes = memberInfo.GetCustomAttributes(typeof(JsonPropertyNameAttribute), false) as JsonPropertyNameAttribute[];
            if(jsonPropertyNameAttributes == null || jsonPropertyNameAttributes.Length == 0)
            {
                return result;
            }

            for (int i = 0; i < jsonPropertyNameAttributes.Length; i++)
            {
                string name = jsonPropertyNameAttributes[i].Name;

                if(!string.IsNullOrWhiteSpace(name))
                {
                    return name;
                }
            }

            return result;
        }

    }

}
