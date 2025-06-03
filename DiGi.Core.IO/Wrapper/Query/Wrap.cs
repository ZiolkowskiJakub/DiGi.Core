using DiGi.Core.IO.Wrapper.Interfaces;
using System.Collections.Generic;
using System.Text.Json.Nodes;

namespace DiGi.Core.IO.Wrapper
{
    public static partial class Query
    {
        internal static JsonObject Wrap(this JsonObject jsonObject, ref Dictionary<IWrapperUniqueReference, JsonObject> dictionary)
        {
            if (jsonObject == null)
            {
                return null;
            }

            JsonObject result = null;

            IWrapperUniqueReference wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject);
            if (wrapperUniqueReference != null && dictionary != null && dictionary.TryGetValue(wrapperUniqueReference, out result))
            {
                return result;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IWrapperUniqueReference, JsonObject>();
            }

            result = (JsonObject)jsonObject.DeepClone();

            foreach (KeyValuePair<string, JsonNode> keyValuePair in jsonObject)
            {
                if (keyValuePair.Value is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)keyValuePair.Value;

                    wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject_Temp);
                    if (wrapperUniqueReference != null)
                    {
                        dictionary[wrapperUniqueReference] = jsonObject_Temp;
                        result[keyValuePair.Key] = wrapperUniqueReference.ToJsonObject();
                    }
                }
                else if (keyValuePair.Value is JsonArray)
                {
                    result[keyValuePair.Key] = Wrap((JsonArray)keyValuePair.Value, ref dictionary);
                }
            }

            return result;
        }

        internal static JsonArray Wrap(this JsonArray jsonArray, ref Dictionary<IWrapperUniqueReference, JsonObject> dictionary)
        {
            if (jsonArray == null)
            {
                return null;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<IWrapperUniqueReference, JsonObject>();
            }

            JsonArray result = (JsonArray)jsonArray.DeepClone();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] is JsonObject)
                {
                    JsonObject jsonObject_Temp = (JsonObject)result[i];

                    IWrapperUniqueReference wrapperUniqueReference = Create.WrapperUniqueReference(jsonObject_Temp);
                    if (wrapperUniqueReference != null)
                    {
                        dictionary[wrapperUniqueReference] = jsonObject_Temp;
                        result[i] = wrapperUniqueReference.ToJsonObject();
                    }
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

