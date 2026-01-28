using DiGi.Core.Classes;
using DiGi.Core.Interfaces;
using System.Text.Json.Nodes;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static T? SerializableObject<T>(this JsonObject? jsonObject) where T : ISerializableObject
        {
            if (jsonObject == null)
            {
                return default;
            }

            SerializationConstructor? serializationConstructor = null;

            string? fullTypeName = Query.FullTypeName(jsonObject);
            if (!string.IsNullOrWhiteSpace(fullTypeName))
            {
                serializationConstructor = Settings.SerializationManager.GetSerializationConstructor(fullTypeName);
            }

            serializationConstructor ??= Settings.SerializationManager.GetSerializationConstructor(typeof(SerializableObjectWrapper));

            if (serializationConstructor == null)
            {
                return default;
            }

            return serializationConstructor.Create<T>(jsonObject);
        }
    }
}