using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static JsonObject Wrap(this JsonObject jsonObject, ref Dictionary<IWrapperReference, JsonObject> dictionary)
        {
            dictionary = null;

            if (jsonObject == null)
            {
                return null;
            }

            JsonObject result = null;

            IWrapperReference wrapperReference = Create.WrapperReference(jsonObject);
            if (wrapperReference != null && dictionary != null && dictionary.TryGetValue(wrapperReference, out result))
            {
                return result;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IWrapperReference, JsonObject>();
            }

            result = (JsonObject)jsonObject.DeepClone();

            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                if (keyValuePair.Value is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)keyValuePair.Value;

                    wrapperReference = Create.WrapperReference(jsonObject_Temp);
                    if (wrapperReference != null)
                    {
                        dictionary[wrapperReference] = jsonObject_Temp;
                        result[keyValuePair.Key] = wrapperReference.ToJsonObject();
                    }
                }
                else if (keyValuePair.Value is JsonArray)
                {
                    result[keyValuePair.Key] = Wrap((JsonArray)keyValuePair.Value, ref dictionary);
                }
            }

            return result;
        }

        internal static JsonArray Wrap(this JsonArray jsonArray, ref Dictionary<IWrapperReference, JsonObject> dictionary)
        {
            dictionary = null;
            if (jsonArray == null)
            {
                return null;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IWrapperReference, JsonObject>();
            }

            JsonArray result = (JsonArray)jsonArray.DeepClone();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] is JsonObject)
                {
                    result[i] = Wrap((JsonObject)result[i], ref dictionary);
                }
                else if (result[i] is JsonArray)
                {
                    result[i] = Wrap((JsonArray)result[i], ref dictionary);
                }
            }

            return result;

        }
    }
}

