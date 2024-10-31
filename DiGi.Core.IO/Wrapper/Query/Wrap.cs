using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        public static JsonObject Wrap(this JsonObject jsonObject, Dictionary<IObjectReference, JsonObject> dictionary = null)
        {
            dictionary = null;

            if (jsonObject == null)
            {
                return null;
            }

            JsonObject result = null;

            IObjectReference objectReference = Create.ObjectReference(jsonObject);
            if (objectReference != null && dictionary != null && dictionary.TryGetValue(objectReference, out result))
            {
                return result;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IObjectReference, JsonObject>();
            }

            result = (JsonObject)jsonObject.DeepClone();

            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                if (keyValuePair.Value is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)keyValuePair.Value;

                    objectReference = Create.ObjectReference(jsonObject_Temp);
                    if (objectReference != null)
                    {
                        dictionary[objectReference] = jsonObject_Temp;
                        result[keyValuePair.Key] = objectReference.ToJsonObject();
                    }
                }
                else if (keyValuePair.Value is JsonArray)
                {
                    result[keyValuePair.Key] = Wrap((JsonArray)keyValuePair.Value, dictionary);
                }
            }

            return result;
        }

        public static JsonArray Wrap(this JsonArray jsonArray, Dictionary<IObjectReference, JsonObject> dictionary = null)
        {
            dictionary = null;
            if (jsonArray == null)
            {
                return null;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IObjectReference, JsonObject>();
            }

            JsonArray result = (JsonArray)jsonArray.DeepClone();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] is JsonObject)
                {
                    result[i] = Wrap((JsonObject)result[i], dictionary);
                }
                else if (result[i] is JsonArray)
                {
                    result[i] = Wrap((JsonArray)result[i], dictionary);
                }
            }

            return result;

        }
    }
}

